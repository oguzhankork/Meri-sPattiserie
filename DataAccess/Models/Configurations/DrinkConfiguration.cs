using DataAccess.Seeds;
using DataAccess.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Models.Configurations
{
    public class DrinkConfiguration : IEntityTypeConfiguration<Drink>
    {
        public void Configure(EntityTypeBuilder<Drink> builder)
        {
            builder.Property(x => x.CreatedTime).IsRequired(true);
            builder.Property(x => x.DrinkName).IsRequired(true);                        builder.Property(x => x.Price).IsRequired(true);

            builder.HasData(DrinkSeed.drinks);
        }
    }
}
