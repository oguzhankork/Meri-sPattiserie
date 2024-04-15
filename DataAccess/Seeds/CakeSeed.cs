using DataAccess.Models.Entities;

namespace DataAccess.Seeds
{
    internal class CakeSeed
    {
        public static List<Cake> cakes = new List<Cake>()
        {
            new Cake
            {
                ID=1,
                CakeName="Meri's Berliner",
                CreatedTime=DateTime.Now,
                Price=150,
                Description="Orman Meyveli",
                CategoryId=1
            },
            new Cake
            {
                ID = 2,
                CakeName="Meri's Ice Cream",
                CreatedTime=DateTime.Now,
                Price=169,
                Description="Tuzlu Karamelli",
                CategoryId=1
            }
        };
    }
}
