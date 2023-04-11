using Microsoft.EntityFrameworkCore;

namespace MvcCoreFood.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\ProjectModels;database=FoodDB;integrated security=true;");
        }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }
    
    }
}
