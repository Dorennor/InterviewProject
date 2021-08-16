using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InterviewProject.Models
{
    public sealed class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Post> Posts { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
