using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantApp.Models
{
    public interface IResturantRequirement
    {
        string Address { get; set; }
        string Logo { get; set; }
        Food Serve();

    }
}
