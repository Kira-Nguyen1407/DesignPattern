namespace BuilderPattern{
    public class DirectorHouse{
        public static void Construct(IHouseBuilder builder)
        {
            builder.BuildFoundation();
            builder.BuildWalls();
            builder.BuildRoof();
            builder.BuildInterior();
        }
    }
}