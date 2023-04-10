using System.ComponentModel.DataAnnotations;

namespace CoreDepartment.Models
{
    public class personel
    {
        [Key]
        public int perid { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string sehir { get; set; }

        public departments depart { get; set; }
    }
}
