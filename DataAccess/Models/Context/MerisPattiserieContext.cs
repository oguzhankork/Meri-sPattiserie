using DataAccess.Models.Configurations;
using DataAccess.Models.Entities;
using Microsoft.EntityFrameworkCore;
namespace DataAccess.Models.Context
{
    public class MerisPattiserieContext:DbContext
    {
        public DbSet<Cake>Cakes { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) optionsBuilder.UseSqlServer("server=DESKTOP-CQ3AEIG;database=MerisPattiserie;uid=sa;pwd=1;TrustServerCertificate=true");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CakeConfiguration());
            modelBuilder.ApplyConfiguration(new DrinkConfiguration());
            modelBuilder.ApplyConfiguration(new DrinkConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
