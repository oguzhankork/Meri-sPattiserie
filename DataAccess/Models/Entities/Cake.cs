namespace DataAccess.Models.Entities
{
    public class Cake:BaseProduct
    {
        public string CakeName { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
