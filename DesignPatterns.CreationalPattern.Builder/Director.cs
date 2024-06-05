namespace DesignPatterns.CreationalPattern.Builder
{
    public class Director
    {
        private IHouseBuilder _builder;

        public Director(IHouseBuilder builder)
        {
            _builder = builder;
        }


        public void Construct(bool hasGarage, bool hasSwimPool, bool hasStatues, bool hasGarden)
        {
            _builder.BuildWalls()
                    .BuildDoors()
                    .BuildWindows()
                    .BuildRoof();

            if (hasGarage)
            {
                _builder.BuildGarage();
            }

            if (hasSwimPool)
            {
                _builder.BuildSwimPool();
            }

            if (hasStatues)
            {
                _builder.BuildStatues();
            }

            if (!hasGarden)
            {
                _builder.BuildGarden();
            }
        }
    }
}
