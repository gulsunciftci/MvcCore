using System.ComponentModel.DataAnnotations;

namespace CoreDepartment.Models
{
    public class departments
    {
        [Key]
        public int Id { get; set; }
        public string departmanAd { get; set; }
        
        public List<personel> personels { get; set; } //bire çok bir ilişkiyle bir departmana ait birçok personel olabilir
    }
}
