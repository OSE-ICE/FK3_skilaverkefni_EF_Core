using FK3_skilaverkefni_EF_Core.Models;
using Microsoft.EntityFrameworkCore;

namespace FK3_skilaverkefni_EF_Core.Data
{
    public class SchoolDBContext : DbContext
    {
        public DbSet<Students> Students { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<Marks> Marks { get; set; }
        public DbSet<Subject_teacher> Subject_teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectModels;Database=SchoolDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subject_teacher>()
                .HasKey(st => new { st.SubjectId, st.TeacherId });
        }
    }
}
