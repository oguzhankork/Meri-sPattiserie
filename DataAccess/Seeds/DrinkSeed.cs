using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeds
{
    public class DrinkSeed
    {
        public static List<Drink> drinks = new List<Drink>()
        {
            new Drink
            {
                ID= 1,
                DrinkName="Meri's Lemonade",
                Price=80,               
                DrinkDescription="With Fresh Lemons",
                CategoryId=2,
                CreatedTime= DateTime.Now,
            },
            new Drink
            {
                ID = 2,
                DrinkName="Meri's Tea",
                Price=25,
                DrinkDescription ="From Meri's Handmade",
                CreatedTime=(DateTime)DateTime.Now,
                CategoryId=2
            }

        };
    }
}
