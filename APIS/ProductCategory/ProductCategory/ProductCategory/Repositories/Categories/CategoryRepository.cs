using ProductCategory.Entities;
using ProductCategory.Repositories.Database;

namespace ProductCategory.Repositories.Categories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }
        public Category AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }

        public void DeleteCategory(int idCategory)
        {
            var category = _context.Categories.FirstOrDefault(c => c.IdCategory == idCategory);
            if (category == null)
            {
                throw new KeyNotFoundException("Category not found");
            }
            _context.Categories.Remove(category);
            _context.SaveChanges();

        }

        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategory(int idCategory)
        {
            return _context.Categories.FirstOrDefault(c => c.IdCategory == idCategory);
        }

        public Category UpdateCategory(int idCategory, Category category)
        {
            var updateCategory = _context.Categories.FirstOrDefault(c => c.IdCategory == idCategory) ?? throw new KeyNotFoundException("Category not found");
            updateCategory.Name = category.Name;
            updateCategory.Description = category.Description;

            _context.SaveChanges();
            return updateCategory;
        }
    }
}
