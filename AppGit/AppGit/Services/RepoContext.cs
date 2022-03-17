using AppGit.Models;
using Microsoft.EntityFrameworkCore;


namespace AppGit.Services
{
    public class RepoContext : DbContext
    {
        public RepoContext(DbContextOptions<RepoContext> options) : base(options)
        {
        }
    

        public DbSet<Repo> Courses { get; set; }
        public DbSet<User> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Repo>().ToTable("Repo");
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}