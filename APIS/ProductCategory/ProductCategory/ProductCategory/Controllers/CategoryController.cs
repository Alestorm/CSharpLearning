using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductCategory.Entities;
using ProductCategory.Repositories.Categories;

namespace ProductCategory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        [HttpPost]
        public IActionResult AddCategory([FromBody] Category category)
        {
            Category newCategory = _categoryRepository.AddCategory(category);
            return Created("", newCategory);
        }
        [HttpGet]
        public IActionResult GetAllCategories()
        {
            return Ok(_categoryRepository.GetAllCategories());
        }
        [HttpGet("{id}")]
        public IActionResult GetCategory([FromRoute] int id)
        {
            var category = _categoryRepository.GetCategory(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory([FromRoute] int id)
        {
            _categoryRepository.DeleteCategory(id);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateCategory([FromRoute] int id, [FromBody] Category category)
        {
            try
            {
                Category updatedCategory = _categoryRepository.UpdateCategory(id, category);
                return Ok(updatedCategory);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
