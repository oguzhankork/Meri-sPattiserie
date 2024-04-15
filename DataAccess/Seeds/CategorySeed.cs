using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeds
{
    public class CategorySeed
    {
        public static List<Category> categories = new List<Category>()
        {
            new Category
            {
                ID=1,
                CategoryName="Tatlılar",
                CreatedTime=DateTime.Now
            },
            new Category
            {
                ID = 2,
                CategoryName="İçecekler",
                CreatedTime = DateTime.Now
            }
        };
    }
}
