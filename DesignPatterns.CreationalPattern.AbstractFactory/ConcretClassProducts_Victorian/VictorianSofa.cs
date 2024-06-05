using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CreationalPattern.AbstractFactory.ProductsInterfaces;

namespace DesignPatterns.CreationalPattern.AbstractFactory.ConcretClassProducts_Victorian
{
    public class VictorianSofa : ISofa
    {
        public void LieOn()
        {
            Console.WriteLine("* Lying on a victorian sofa.");
        }
    }
}
