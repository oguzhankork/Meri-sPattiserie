using DataAccess.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Seeds;

namespace DataAccess.Models.Configurations
{
    public class CakeConfiguration : IEntityTypeConfiguration<Cake>
    {
        public void Configure(EntityTypeBuilder<Cake> builder)
        {
            builder.Property(x => x.CreatedTime).IsRequired(true);
            builder.Property(x=>x.CakeName).IsRequired(true);                       builder.Property(x=>x.Price).IsRequired(true);



            builder.HasData(CakeSeed.cakes);           
        }
    }
}
