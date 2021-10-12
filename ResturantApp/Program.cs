using ResturantApp.Models;
using System;

namespace ResturantApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Resturant beremji = new Resturant(1380);

            Drink noshabeh = new Drink();
            noshabeh.Name = "Noshabeh";

            beremji.Foods.Add(new Drink() { Name = "Noshabeh" });

            Food berger = new Traditional();
            berger.Name = "Double";

            beremji.Foods.Add(berger);

            beremji.Foods.Remove(berger);

            berger.Name = "Cheese Duble";

            beremji.Foods.Add(berger);


        }
    }
}
