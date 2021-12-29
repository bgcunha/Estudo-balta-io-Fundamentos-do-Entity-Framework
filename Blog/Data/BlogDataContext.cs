using Microsoft.EntityFrameworkCore;
using Blog.Models;
using System;
using Blog.Data.Mappings;

namespace Blog.Data
{
    class BlogDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-BKLEGIN\\SQLEXPRESS2019; Database=BlogFluentMap; User ID=sa;Password=sa123");
            //options.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new PostMap());
            modelBuilder.ApplyConfiguration(new UserMap());
        }

    }
}
