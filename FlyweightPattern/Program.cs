namespace FlyweightPattern{
    public class Program{
        public static void Main(string[] args){
            Forest forest = new();

            forest.PlantTree(1, 2, "Oak", "Green", "OakTexture");
            forest.PlantTree(3, 4, "Pine", "Brown", "PineTexture");
            forest.PlantTree(5, 6, "Oak", "Green", "OakTexture");

            forest.Draw();
        }
    }
}