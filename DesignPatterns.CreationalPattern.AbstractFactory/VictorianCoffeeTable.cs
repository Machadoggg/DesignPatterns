using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPattern.AbstractFactory
{
    public class VictorianCoffeeTable : ICoffeTable
    {

        public void PlaceItemsOn()
        {
            Console.WriteLine("Placing items on a victorian coffee table.");
        }
    }
}
