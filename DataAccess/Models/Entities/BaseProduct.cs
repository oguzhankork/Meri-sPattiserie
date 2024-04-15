namespace DataAccess.Models.Entities
{
    public abstract class BaseProduct
    {
        public int ID { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedTime { get; set; }
        public bool IsActive { get; set; }
    }
}
