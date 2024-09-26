namespace ProductCategory.Entities
{
    public class Product
    {
        public int IdProduct { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; } //url
        public string Brand { get; set; }
        public Int16 Status { get; set; } = 1;
        public Category Category { get; set; }
    }
}
