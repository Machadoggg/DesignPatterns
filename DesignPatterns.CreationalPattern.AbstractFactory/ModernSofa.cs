using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPattern.AbstractFactory
{
    public class ModernSofa : ISofa
    {
        public void LieOn()
        {
            Console.WriteLine("Lying on a modern sofa.");
        }
    }
}
