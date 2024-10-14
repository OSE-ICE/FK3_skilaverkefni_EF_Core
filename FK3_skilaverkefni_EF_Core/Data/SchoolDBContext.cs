using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FK3_skilaverkefni_EF_Core.Data
{
    public class SchoolDBContext : DbContext
    {
        public DbSet<Models.Students> Students { get; set; }
        public DbSet<Models.Groups> Groups { get; set; }
        public DbSet<Models.Subjects> Subjects { get; set; }
        public DbSet<Models.Marks> Marks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectModels;Database=SchoolDB;Trusted_Connection=True;");
        }
    }
}
