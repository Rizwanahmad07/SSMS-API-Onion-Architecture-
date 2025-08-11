using SSECSAPI.Models;

namespace SSECSAPI.Data.Interface
{
    public interface ICategory
    {
        public List<Category> GetAllCategory();
        public Category GetCategoryById(int id);
        public string AddCategory(Category category);
        public string UpdateCategory(Category category);
        public string DeleteCategory(int id);
    }
}
