using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FileUpload.Models;
using Microsoft.EntityFrameworkCore;

namespace FileUpload.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions <DataContext> options ) : base(options)
        {

        }
        public DbSet<DbFile>Files{get;set;}
}
}