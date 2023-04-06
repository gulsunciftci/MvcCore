using Microsoft.EntityFrameworkCore;

namespace CoreDepartment.Models
{
    public class Context:DbContext
    {
        public DbSet<departments> departmanlars { get; set; }
        public DbSet<personel>   personels{ get; set; }
    }
}
