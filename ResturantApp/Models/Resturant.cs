using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantApp.Models
{
    public class Resturant : IResturantRequirement
    {
        public string Name { get; set; }
        public int Start { get; }
        public bool HealthyLicense { get; set; }
        public string Manager { get; set; }
        public List<Food> Foods { get; }
        public string Address { get; set; }
        public string Logo { get; set; }

        public Resturant(int start)
        {
            Start = start;
            Foods = new List<Food>();
        }

        public virtual ResturantType Type()
        {
            return ResturantType.Mixed;
        }

        public Food Serve()
        {
            return Foods.FirstOrDefault();
        }
    }
}
