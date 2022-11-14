using Microsoft.EntityFrameworkCore;
using PoudlardAPI.Entities;

namespace PoudlardAPI
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {}

        public DbSet<Student> Students { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Reward> Awards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>(Student.BuildEntityType);
            modelBuilder.Entity<House>(House.BuildEntityType);
            modelBuilder.Entity<Professor>(Professor.BuildEntityType);
            modelBuilder.Entity<Reward>(Reward.BuildEntityType);
        }
    }
}
