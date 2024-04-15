namespace DataAccess.Models.Entities
{
    public class Drink:BaseProduct
    {
        public string DrinkName { get; set; }
        public string DrinkDescription { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
