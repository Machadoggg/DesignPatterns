using DesignPatterns.CreationalPattern.AbstractFactory.ConcretClassProducts_ArtDeco;
using DesignPatterns.CreationalPattern.AbstractFactory.ProductsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPattern.AbstractFactory
{
    public class ArtDecoFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ArtDecoChair();
        }

        public ICoffeTable CreateCoffeTable()
        {
            return new ArtDecoCoffeeTable();
        }

        public ISofa CreateSofa()
        {
            return new ArtDecoSofa();
        }
    }
}
