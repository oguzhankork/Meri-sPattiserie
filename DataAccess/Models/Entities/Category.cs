using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class Category:BaseProduct
    {
        public string CategoryName { get; set; }
        public virtual List<Cake>Cakes { get; set; }
        public virtual List<Drink> Drinks { get; set; }
    }
}
