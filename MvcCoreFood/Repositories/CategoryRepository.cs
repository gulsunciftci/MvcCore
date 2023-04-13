using MvcCoreFood.Models;

namespace MvcCoreFood.Repositories
{
   
    public class CategoryRepository
    {
        Context c = new Context();
        public List<Category> CategoryList()
        {
            return c.Categories.ToList();
        }
    }
}
