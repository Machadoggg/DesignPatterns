using DesignPatterns.CreationalPattern.AbstractFactory.ProductsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPattern.AbstractFactory.ConcretClassProducts_ArtDeco
{
    public class ArtDecoChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("- Sitting on an Art Deco chair.");
        }
    }
}
