using DesignPatterns.CreationalPattern.AbstractFactory.ConcretClassProducts_Victorian;
using DesignPatterns.CreationalPattern.AbstractFactory.ProductsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPattern.AbstractFactory
{
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ICoffeTable CreateCoffeTable()
        {
            return new VictorianCoffeeTable();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }
}
