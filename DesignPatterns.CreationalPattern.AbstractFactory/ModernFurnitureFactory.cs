using DesignPatterns.CreationalPattern.AbstractFactory.ConcretClassProducts_Modern;
using DesignPatterns.CreationalPattern.AbstractFactory.ProductsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPattern.AbstractFactory
{
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ICoffeTable CreateCoffeTable()
        {
            return new ModernCoffeeTable();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
