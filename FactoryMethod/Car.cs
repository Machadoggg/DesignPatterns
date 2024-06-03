using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Car : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivery by car");
        }
    }
}
