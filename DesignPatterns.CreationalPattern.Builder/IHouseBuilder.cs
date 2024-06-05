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
