using DesignPatterns.CreationalPattern.AbstractFactory.ProductsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPattern.AbstractFactory
{
    public class FurnitureStore
    {
        private readonly IFurnitureFactory _furnitureFactory;

        public FurnitureStore(IFurnitureFactory furnitureFactory)
        {
            _furnitureFactory = furnitureFactory;
        }

        public void ProcessOrder()
        {
            IChair chair = _furnitureFactory.CreateChair();
            ISofa sofa = _furnitureFactory.CreateSofa();
            ICoffeTable coffeTable = _furnitureFactory.CreateCoffeTable();

            chair.SitOn();
            sofa.LieOn();
            coffeTable.PlaceItemsOn();
        }
    }
}
