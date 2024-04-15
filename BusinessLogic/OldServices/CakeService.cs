using DataAccess.Models.Context;
using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.OldServices
{
    public class CakeService
    {
        private MerisPattiserieContext _merisPattiserieContext=new MerisPattiserieContext();

        public List<Cake> GetCakes()
        {
            return _merisPattiserieContext.Cakes.ToList();
        }

    }
}
