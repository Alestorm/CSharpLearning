using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductCategory.Entities;

namespace ProductCategory.Repositories.Database
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.IdProduct);
            builder.Property(p => p.IdProduct).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasMaxLength(100);
            builder.Property(p => p.Description).HasMaxLength(500);
            builder.Property(p => p.Image).HasMaxLength(2083); //url
            builder.Property(p => p.Brand).HasMaxLength(50);
        }
    }
}
