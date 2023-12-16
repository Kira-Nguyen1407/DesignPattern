namespace BuilderPattern{
    public class ModernHouseBuilder : IHouseBuilder
    {
        private readonly House _house = new();
        public void BuildFoundation()
        {
            _house.Foundation = "Modern Foundation";
        }

        public void BuildInterior()
        {
            _house.Walls = "Modern Walls";
        }

        public void BuildRoof()
        {
            _house.Roof = "Modern Roof";
        }

        public void BuildWalls()
        {
            _house.Interior = "Modern Interior";
        }

        public House GetHouse(){
            return _house;
        }
    }
}