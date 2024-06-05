using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPattern.Builder
{
    public interface IHouseBuilder
    {
        IHouseBuilder BuildWalls();
        IHouseBuilder BuildDoors();
        IHouseBuilder BuildWindows();
        IHouseBuilder BuildRoof();
        IHouseBuilder BuildGarage();
        IHouseBuilder BuildSwimPool();
        IHouseBuilder BuildStatues();
        IHouseBuilder BuildGarden();
        House GetHouse();
    }
}
