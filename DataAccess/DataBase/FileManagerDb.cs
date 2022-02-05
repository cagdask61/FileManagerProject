using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DataBase
{
    public class FileManagerDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=CAGDASKOCAMAN\CAGDASKOCAMAN;Database=FileManagerDb;Trusted_Connection=true");
        }

        public DbSet<SystemFile> SystemFiles { get; set; }
    }
}
