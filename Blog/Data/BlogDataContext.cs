using Microsoft.EntityFrameworkCore;
using Blog.Models;

namespace Blog.Data
{
    class BlogDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=DESKTOP-BKLEGIN\\SQLEXPRESS2019; Database=Blog;User ID=sa;Password=sa123");
    }
}
