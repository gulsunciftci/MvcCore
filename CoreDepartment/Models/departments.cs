using System.ComponentModel.DataAnnotations;

namespace CoreDepartment.Models
{
    public class departments
    {
        [Key]
        public int Id { get; set; }
        public string departmanAd { get; set; }

    }
}
