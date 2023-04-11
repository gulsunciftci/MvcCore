namespace MvcCoreFood.Models
{
    public class Food
    {
        public int FoodID { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public string ThumbNailImageURL { get; set; }
        public int Stock { get; set; }
       
    }
}
