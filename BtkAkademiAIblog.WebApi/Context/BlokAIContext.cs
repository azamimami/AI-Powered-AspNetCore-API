using BtkAkademiAIblog.WebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace BtkAkademiAIblog.WebApi.Context
{
    public class BlokAIContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=blog.db");
        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<TradingVideo> TradingVideos { get; set; }
    }
}
