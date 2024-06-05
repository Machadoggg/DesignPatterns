using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPattern.AbstractFactory
{
    public class VictorianSofa : ISofa
    {
        public void LieOn()
        {
            Console.WriteLine("Lying on a victorian sofa.");
        }
    }
}
