using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CreationalPattern.AbstractFactory.ProductsInterfaces;

namespace DesignPatterns.CreationalPattern.AbstractFactory.ConcretClassProducts_Victorian
{
    public class VictorianChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("* Sitting on a victorian chair.");
        }
    }
}
