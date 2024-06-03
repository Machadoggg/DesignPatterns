using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class CarFactory : TransportFactory
    {
        public override ITransport CreateTransport()
        {
            return new Car();
        }
    }
}
