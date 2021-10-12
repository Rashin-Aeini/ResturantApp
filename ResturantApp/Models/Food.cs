using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantApp.Models
{
    public abstract class Food
    {
        public string Name { get; set; }
        public string Recpie { get; set; }
        public IDictionary<string, string> Requirement { get; }


        public Food()
        {
            Requirement = new Dictionary<string, string>();
        }
    }
}
