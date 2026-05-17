using BtkAkademiAIblog.WebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace BtkAkademiAIblog.WebApi.Context
{
    public class BlokAIContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=BtkAkademiAIBlogDb;" +
                "Trusted_Connection=True;TrustServerCertificate=True;");


        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<TradingVideo> TradingVideos { get; set; }




    }
}
