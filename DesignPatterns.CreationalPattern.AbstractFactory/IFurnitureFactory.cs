using DesignPatterns.CreationalPattern.AbstractFactory.ProductsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPattern.AbstractFactory
{
    public interface IFurnitureFactory
    {
        IChair CreateChair();

        ISofa CreateSofa();

        ICoffeTable CreateCoffeTable();

    }
}
