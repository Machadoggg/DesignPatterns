using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class BicycleFactory : TransportFactory
    {
        public override ITransport CreateTransport()
        {
            return new Bicycle();
        }
    }
}
