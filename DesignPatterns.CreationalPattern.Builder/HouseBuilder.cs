namespace DesignPatterns.CreationalPattern.Builder
{
    public class HouseBuilder : IHouseBuilder
    {
        private House _house = new House();


        public IHouseBuilder BuildWalls()
        {
            _house.HasWalls = true;
            return this;
        }

        public IHouseBuilder BuildDoors()
        {
            _house.HasDoors = true;
            return this;
        }

        public IHouseBuilder BuildWindows()
        {
            _house.HasWindows = true;
            return this;
        }

        public IHouseBuilder BuildRoof()
        {
            _house.HasRoof = true;
            return this;
        }

        public IHouseBuilder BuildGarage()
        {
            _house.HasGarage = true;
            return this;
        }

        public IHouseBuilder BuildSwimPool()
        {
            _house.HasSwimPool = true;
            return this;
        }

        public IHouseBuilder BuildStatues()
        {
            _house.HasStatues = true;
            return this;
        }

        public IHouseBuilder BuildGarden()
        {
            _house.HasGarden = true;
            return this;
        }



        public House GetHouse()
        {
            return _house;
        }
    }
}
