using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCoreDepartman.Models
{
    public class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdminID { get; set; }

        [Column(TypeName="Varchar(20)")]
        public string Kullanici { get; set; }

        [Column(TypeName = "Varchar(10)")]
        public string Sifre { get; set; }
    }
}
