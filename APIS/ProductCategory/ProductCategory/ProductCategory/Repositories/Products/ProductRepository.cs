using Microsoft.EntityFrameworkCore;
using ProductCategory.Entities;
using ProductCategory.Repositories.Database;

namespace ProductCategory.Repositories.Products
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }
        public Product AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public void DeleteProduct(int idProduct)
        {
            var product = _context.Products.FirstOrDefault(p => p.IdProduct == idProduct);
            if (product == null)
            {
                throw new KeyNotFoundException("Product not found");
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public List<Product> GetAllProducts()
        {

            var products = _context.Products.Include(p => p.Category).ToList();
            return products;
        }

        public Product GetProduct(int idProduct)
        {
            var product = _context.Products.Include(p=>p.Category).FirstOrDefault(p => p.IdProduct == idProduct) ?? throw new KeyNotFoundException("Product not found");
            return product;
        }

        public Product UpdateProduct(int idProduct, Product product)
        {
            var updateProduct = _context.Products.FirstOrDefault(p => p.IdProduct == idProduct) ?? throw new KeyNotFoundException("Product not found");

            updateProduct.Name = product.Name;
            updateProduct.Price = product.Price;
            updateProduct.Description = product.Description;
            updateProduct.Stock = product.Stock;
            updateProduct.Image = product.Image;
            updateProduct.Status = product.Status;
            updateProduct.Category = product.Category;

            _context.SaveChanges();
            return updateProduct;
        }
    }
}
