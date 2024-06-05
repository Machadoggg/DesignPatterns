using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPattern.AbstractFactory
{
    public class VictorianChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Sitting on a victorian chair.");
        }
    }
}
