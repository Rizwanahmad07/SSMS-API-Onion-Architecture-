using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSECSAPI.Data.Interface;
using SSECSAPI.Models;

namespace SSECSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public ICategory _category;
        public CategoryController(ICategory category)
        {
            _category = category;
        }

        [HttpGet]
        public IActionResult GetAllCatagory()
        {
            return Ok(_category.GetAllCategory());
        }
        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            return Ok(_category.GetCategoryById(id));
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            return Ok(_category.AddCategory(category));
        }
        [HttpPut]
        public IActionResult UpdateRole(Category category)
        {
            return Ok(_category.UpdateCategory(category));
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            return Ok(_category.DeleteCategory(id));
        }
    }
}
