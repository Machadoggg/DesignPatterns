﻿using DesignPatterns.CreationalPattern.AbstractFactory.ProductsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPattern.AbstractFactory.ConcretClassProducts_ArtDeco
{
    public class ArtDecoSofa : ISofa
    {
        public void LieOn()
        {
            Console.WriteLine("- Lying on an Art Deco sofa.");
        }
    }
}
