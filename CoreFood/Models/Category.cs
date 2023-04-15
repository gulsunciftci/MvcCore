using System.ComponentModel.DataAnnotations;

namespace CoreFood.Models
{  
    public class Category
    {
        public int CategoryID { get; set; }
        
        [Required(ErrorMessage = "Category name cannot be empty")]
        [StringLength(maximumLength:20,MinimumLength =4,ErrorMessage ="Please enter maximum 4-20 length characters")]
        public string CategoryName { get; set; }

        public string? CategoryDescription { get; set; }

        public bool Status { get; set; }
        public List<Food>? Foods { get; set; }
    
        
    }
}
