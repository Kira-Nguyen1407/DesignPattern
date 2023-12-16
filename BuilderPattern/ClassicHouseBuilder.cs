namespace BuilderPattern{
    public class ClassicHouseBuilder : IHouseBuilder
    {
        private readonly House _house = new();

        public void BuildFoundation()
        {
            _house.Foundation = "Classic Foundation";
        }

        public void BuildWalls()
        {
            _house.Walls = "Classic Walls";
        }

        public void BuildRoof()
        {
            _house.Roof = "Classic Roof";
        }

        public void BuildInterior()
        {
            _house.Interior = "Classic Interior";
        }

        public House GetHouse()
        {
            return _house;
        }
    }
}