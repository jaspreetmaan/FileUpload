using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileUpload.Models
{
    public class UploadFile
    {
        public int id { get; set; }
        public IFormFile files { get; set; }
    }
}