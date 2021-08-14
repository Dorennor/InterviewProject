using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InterviewProject.Models
{
    public sealed class AccountsDbContext : IdentityDbContext
    {
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Post> Posts { get; set; }
        public AccountsDbContext(DbContextOptions<AccountsDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
