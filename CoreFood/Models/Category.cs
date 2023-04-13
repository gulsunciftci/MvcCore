using System.ComponentModel.DataAnnotations;

namespace CoreFood.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "Category name cannot be empty")]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public List<Food> Foods { get; set; }
    }
}
