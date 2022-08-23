using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileUpload.Models
{
    public class DbFile
    {
         public int id { get; set; }
        public int imageid { get; set; }
        public string files { get; set; } = string.Empty;
    }
}