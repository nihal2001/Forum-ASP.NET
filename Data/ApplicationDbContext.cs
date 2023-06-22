using Microsoft.EntityFrameworkCore;
using Forum.Models;

namespace Forum.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
    
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    Title = "Test Post 1",
                    Content = "This is a test post.",
                    // Add other properties as required
                },
                new Post
                {
                    Id = 2,
                    Title = "Test Post 2",
                    Content = "This is another test post.",
                    // Add other properties as required
                }
            );
        }
        */

    }
}
