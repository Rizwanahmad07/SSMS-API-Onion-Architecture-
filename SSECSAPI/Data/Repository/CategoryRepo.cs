using SSECSAPI.Data.Interface;
using SSECSAPI.Models;

namespace SSECSAPI.Data.Repository
{
    public class CategoryRepo : ICategory
    {
        public AppDbContext _context;
        public CategoryRepo(AppDbContext context) 
        { 
            _context = context;
        }
        public string AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return "Category Added successfully!";
        }

        public string DeleteCategory(int id)
        {
            Category category = _context.Categories.Find(id);
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return "Category Deleted Successfully!";
        }

        public List<Category> GetAllCategory()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.Find(id);
        }

        public string UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return "Category Updated successfully!";
        }
    }
}
