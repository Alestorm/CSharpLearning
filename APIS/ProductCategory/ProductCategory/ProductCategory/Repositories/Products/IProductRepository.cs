using ProductCategory.Entities;

namespace ProductCategory.Repositories.Products
{
    public interface IProductRepository
    {
        Product AddProduct(Product product);
        Product UpdateProduct(int idProduct, Product product);
        void DeleteProduct(int idProduct);
        Product GetProduct(int idProduct);
        List<Product> GetAllProducts();
    }
}
