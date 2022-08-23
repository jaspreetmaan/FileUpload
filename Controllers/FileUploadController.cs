using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FileUpload.Data;
using FileUpload.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FileUpload.Controllers

{
    [ApiController]
    [Route("[controller]")]
    public class FileUploadController : ControllerBase
    {
               private readonly ILogger<FileUploadController> _logger;
    private readonly IWebHostEnvironment webHostEnvironment;
    private readonly DataContext datacontext;


    public FileUploadController(ILogger<FileUploadController> logger , IWebHostEnvironment _webHostEnvironment ,DataContext  _datacontext)
        {
            _logger = logger;
      webHostEnvironment = _webHostEnvironment;
      datacontext = _datacontext;
    }
        [HttpPost("upload")]
        public async Task<string>Upload ([FromForm]UploadFile obj){

            if(obj.files.Length>0){
                try
                {
                        
                    if(!Directory.Exists(webHostEnvironment.WebRootPath+"\\Images\\")){
                        Directory.CreateDirectory(webHostEnvironment.WebRootPath+"\\Images\\");
                    }
                    _logger.LogInformation("saving path in filestream");
                    using(FileStream filestream = System.IO.File.Create(webHostEnvironment.WebRootPath +"\\Images\\"+obj.files.FileName))
                    {
                        obj.files.CopyTo(filestream);
                        filestream.Flush();
                         DbFile dbfile = new DbFile{
                            imageid = obj.id,
                            files= webHostEnvironment.WebRootPath+"\\Images\\"+obj.files.FileName

                        };
                         datacontext.Files.Add(dbfile);
                        datacontext.SaveChanges();

                        return  "\\Images\\"+obj.files.FileName;




                    }
                }
                catch (System.Exception ex)
                {

                    return ex.ToString();
                }
            }
            else
            {
                return "upload failed";
            }
        }
    }
}