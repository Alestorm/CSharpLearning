using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Products_Categories
{
    public class ProductsCategories
    {
        private List<Product> _products = new List<Product>();
        private List<Category> _categories = new List<Category>();
        public void Main()
        {
            //CATEGORIES
            Category electronics = new Category
            {
                IdCategory = 1,
                Name = "Electronics",
                Description = "Electronic products such as phones, computers and more."
            };

            Category home = new Category
            {
                IdCategory = 2,
                Name = "Home",
                Description = "Home products such as furniture, appliances and decor."
            };
            AddCategory(electronics);
            AddCategory(home);


            //PRODUCTS
            Product smartphone = new Product
            {
                IdProduct = 1,
                Name = "Smartphone XYZ",
                Price = 799.99m,
                Description = "Teléfono inteligente de última generación con pantalla OLED.",
                Stock = 50,
                Image = "https://example.com/smartphone.jpg",
                Brand = "XYZ",
                Status = 1,
                Category = electronics
            };
            Product laptop = new Product
            {
                IdProduct = 2,
                Name = "Laptop ABC",
                Price = 1299.99m,
                Description = "Laptop ultradelgada con gran rendimiento y batería de larga duración.",
                Stock = 30,
                Image = "https://example.com/laptop.jpg",
                Brand = "ABC",
                Status = 1,
                Category = electronics,
            };
            Product refrigerator = new Product
            {
                IdProduct = 101,
                Name = "Refrigerador ABC",
                Price = 799.99m,
                Description = "Refrigerador de última generación con tecnología de ahorro de energía.",
                Stock = 25,
                Image = "https://example.com/refrigerator.jpg",
                Brand = "ABC",
                Status = 1,
                Category = home
            };

            AddProduct(smartphone);
            AddProduct(laptop);
            AddProduct(refrigerator);

            GetProducts();

            string category = "home";
            Console.WriteLine($"\n{category.ToUpper()} - PRODUCTS");
            GetProductsByCategory(category);

            AddStock(refrigerator,2);
            TakeStock(laptop, 10);

            GetProducts();
        }
        public void AddCategory(Category category)
        {
            _categories.Add(category);
        }
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public void GetProducts()
        {
            Console.WriteLine("\nPRODUCT LIST");
            for (int i = 0; i < _products.Count; i++)
            {
                _products[i].PrintDetails();
            }
        }
        public void GetProductsByCategory(string category)
        {
            
            List<Product> productList = _products.Where(p => p.Category.Name.ToLower().Equals(category.ToLower())).ToList();
            for (int i = 0; i < productList.Count; i++)
            {
                productList[i].PrintDetails();
            }
        }
        public void AddStock(Product product, int quantity)
        {
            product.AddStock(quantity);
        }
        public void TakeStock(Product product, int quantity)
        {
            product.TakeStock(quantity);
        }
    }
}
