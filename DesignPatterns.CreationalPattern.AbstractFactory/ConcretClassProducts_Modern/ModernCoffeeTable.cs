using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CreationalPattern.AbstractFactory.ProductsInterfaces;

namespace DesignPatterns.CreationalPattern.AbstractFactory.ConcretClassProducts_Modern
{
    public class ModernCoffeeTable : ICoffeTable
    {
        public void PlaceItemsOn()
        {
            Console.WriteLine("Placing items on a modern coffe table");
        }
    }
}
