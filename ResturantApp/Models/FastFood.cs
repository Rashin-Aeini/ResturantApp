using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantApp.Models
{
    public class FastFood : Resturant
    {
        public FastFood(int start) : base(start)
        {
        }

        public override ResturantType Type()
        {
            return ResturantType.FastFood;
        }
    }
}
