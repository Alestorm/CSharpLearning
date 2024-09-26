using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using ProductCategory.Controllers.Dtos;
using ProductCategory.Entities;
using ProductCategory.Repositories.Categories;
using ProductCategory.Repositories.Products;

namespace ProductCategory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        [HttpPost]
        public IActionResult AddProduct([FromBody] ProductDto productDto)
        {
            Category category = _categoryRepository.GetCategory(productDto.IdCategory);
            if (category == null)
            {
                return NotFound("Category not found");
            }
            if (productDto.Stock < 0)
            {
                return BadRequest("Stock cannot be negative");
            }
            Product product = new Product()
            {
                Name = productDto.Name,
                Price = productDto.Price,
                Description = productDto.Description,
                Stock = productDto.Stock,
                Image = productDto.Image,
                Brand = productDto.Brand,
                Category = category
            };
            return Created("", _productRepository.AddProduct(product));
        }
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(_productRepository.GetAllProducts());
        }
        [HttpGet("{id}")]
        public IActionResult GetProduct([FromRoute] int id)
        {
            try
            {
                return Ok(_productRepository.GetProduct(id));
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public IActionResult UpdateProduct([FromRoute] int id, [FromBody] ProductDto productDto)
        {
            try
            {
                Category category = _categoryRepository.GetCategory(productDto.IdCategory);
                if (category == null)
                {
                    return NotFound("Category not found");
                }
                if (productDto.Stock < 0)
                {
                    return BadRequest("Stock cannot be negative");
                }

                Product product = new Product()
                {
                    Name = productDto.Name,
                    Price = productDto.Price,
                    Description = productDto.Description,
                    Stock = productDto.Stock,
                    Image = productDto.Image,
                    Brand = productDto.Brand,
                    Category = category
                };
                return Ok(_productRepository.UpdateProduct(id, product));
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct([FromRoute] int id)
        {
            try
            {
                _productRepository.DeleteProduct(id);
                return Ok("Deleted");
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
