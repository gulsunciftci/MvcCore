using Microsoft.EntityFrameworkCore;

namespace CoreDepartment.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\ProjectModels;database=corepersonel;integrated security=true;");
        } 
        public DbSet<departments> departments { get; set; }
        public DbSet<personel>   personel{ get; set; }
    }
}
