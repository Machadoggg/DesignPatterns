using DesignPatterns.CreationalPattern.AbstractFactory.ProductsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPattern.AbstractFactory.ConcretClassProducts_ArtDeco
{
    public class ArtDecoCoffeeTable : ICoffeTable
    {
        public void PlaceItemsOn()
        {
            Console.WriteLine("Placing items on an ART DECO coffee table.");
        }
    }
}
