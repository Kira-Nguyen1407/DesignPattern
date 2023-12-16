namespace BuilderPattern{
    public interface IHouseBuilder
    {
        void BuildFoundation();
        void BuildWalls();
        void BuildRoof();
        void BuildInterior();
        House GetHouse(); // GetHouse method in the interface
    }
}