﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class TransportFactory
    {
        public abstract ITransport CreateTransport();
    }
}
