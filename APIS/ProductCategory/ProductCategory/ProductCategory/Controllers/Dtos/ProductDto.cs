using ProductCategory.Entities;

namespace ProductCategory.Controllers.Dtos
{
    public class ProductDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; } //url
        public string Brand { get; set; }
        public int IdCategory { get; set; }
    }
}