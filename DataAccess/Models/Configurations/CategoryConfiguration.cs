using Microsoft.EntityFrameworkCore;
using DataAccess.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Seeds;

namespace DataAccess.Models.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {            
            builder.Property(x => x.CategoryName).IsRequired(true);
            builder.Property(x => x.CategoryName).HasMaxLength(100);

            builder.HasData(CategorySeed.categories);
        }
    }
}
