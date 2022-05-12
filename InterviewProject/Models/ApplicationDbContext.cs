using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace InterviewProject.Models
{
    public sealed class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedRoles(modelBuilder);
            SeedUsers(modelBuilder);
            SeedUserRoles(modelBuilder);
            SeedTopics(modelBuilder);
            SeedPosts(modelBuilder);
        }

        private void SeedRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "eb9ed444-104b-4f39-a1fb-da6f02682970",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                new IdentityRole
                {
                    Id = "a063d567-7af0-4db0-ab52-7737a999dcf5",
                    Name = "User",
                    NormalizedName = "USER"
                });
        }

        private void SeedUsers(ModelBuilder modelBuilder)
        {
            User admin = new User()
            {
                Id = "a8dcb9d5-5d82-427f-b37c-b808c7ebe9af",
                Email = "vova.rud.00@gmail.com",
                NormalizedEmail = "VOVA.RUD.00@GMAIL.COM",
                UserName = "Administrator",
                NormalizedUserName = "ADMINISTRATOR",
                EmailConfirmed = true
            };
            User user = new User()
            {
                Id = "3e34e058-e269-4597-8a7e-92b83a45a954",
                Email = "vova.rud.1404@gmail.com",
                NormalizedEmail = "VOVA.RUD.1404@GMAIL.COM",
                UserName = "Vladimir",
                NormalizedUserName = "VLADIMIR",
                EmailConfirmed = true
            };

            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
            admin.PasswordHash = passwordHasher.HashPassword(admin, "administrator");
            user.PasswordHash = passwordHasher.HashPassword(user, "111111");

            modelBuilder.Entity<User>().HasData(admin, user);
        }

        private void SeedUserRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "eb9ed444-104b-4f39-a1fb-da6f02682970",
                UserId = "a8dcb9d5-5d82-427f-b37c-b808c7ebe9af"
            },
            new IdentityUserRole<string>
            {
                RoleId = "a063d567-7af0-4db0-ab52-7737a999dcf5",
                UserId = "3e34e058-e269-4597-8a7e-92b83a45a954"
            });
        }

        private void SeedTopics(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>().HasData(
            new Topic
            {
                Id = 1,
                UserId = "a8dcb9d5-5d82-427f-b37c-b808c7ebe9af",
                UserName = "Administrator",
                LastPostDateTime = DateTime.Now,
                Title = "Support",
                Description = "Support for users of forum.",
                NumberOfPosts = 1
            },
            new Topic
            {
                Id = 2,
                UserId = "a8dcb9d5-5d82-427f-b37c-b808c7ebe9af",
                UserName = "Administrator",
                LastPostDateTime = DateTime.Now,
                Title = "Instructions",
                Description = "Instructions how to use forum.",
                NumberOfPosts = 1
            });
        }

        private void SeedPosts(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
            new Post
            {
                Id = 1,
                PostDateTime = DateTime.Now,
                Text = "It's a topic where you can deal your problems with another users of forum and administration.",
                UserName = "Administrator",
                TopicId = 1
            },
            new Post
            {
                Id = 2,
                PostDateTime = DateTime.Now,
                Text = "It's a topic where you can read about rules and instructions.",
                UserName = "Administrator",
                TopicId = 2
            });
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}