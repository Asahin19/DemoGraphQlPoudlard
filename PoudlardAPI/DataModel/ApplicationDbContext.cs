using Microsoft.EntityFrameworkCore;
using PoudlardAPI.Entities;

namespace PoudlardAPI
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>(Student.BuildEntityType);
        }
    }
}
