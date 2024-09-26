using ProductCategory.Entities;

namespace ProductCategory.Repositories.Categories
{
    public interface ICategoryRepository
    {
        Category AddCategory(Category category);
        Category GetCategory(int idCategory);
        List<Category> GetAllCategories();
        Category UpdateCategory(int idCategory,Category category);
        void DeleteCategory(int idCategory);

    }
}
