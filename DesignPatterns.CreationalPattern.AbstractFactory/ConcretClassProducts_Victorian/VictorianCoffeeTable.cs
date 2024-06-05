using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CreationalPattern.AbstractFactory.ProductsInterfaces;

namespace DesignPatterns.CreationalPattern.AbstractFactory.ConcretClassProducts_Victorian
{
    public class VictorianCoffeeTable : ICoffeTable
    {

        public void PlaceItemsOn()
        {
            Console.WriteLine("Placing items on a victorian coffee table.");
        }
    }
}
