using BookProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<BookUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

    }
}
