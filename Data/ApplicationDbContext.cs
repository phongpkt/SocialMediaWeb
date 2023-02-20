using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebDemo.Models;

namespace WebDemo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Ideas> Ideas { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedIdeas(builder);
        }

        public void SeedIdeas(ModelBuilder builder)
        {
            builder.Entity<Ideas>().HasData(
                new Ideas
                {
                    IdeasId = 1,
                    Publisher = "Your Name",
                    Title = "Title 1",
                    Content = "Content",
                    PublishedDate = DateTime.Parse("2023-02-20")
                },
                new Ideas
                {
                    IdeasId = 2,
                    Publisher = "Your Name",
                    Title = "Title 2",
                    Content = "Content",
                    PublishedDate = DateTime.Parse("2023-02-20")
                }
            );
        }
    }
}