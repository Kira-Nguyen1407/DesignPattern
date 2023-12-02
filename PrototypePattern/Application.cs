namespace PrototypePattern{
    public class Application{
        private static readonly List<Shape> _shapes = new();

        
        public static void BusinessLogic(){
            Circle circle = new()
            {
                X = 10,
                Y = 10,
                Radius = 20
            };
            _shapes.Add(circle);

            Circle anotherCircle = (Circle)circle.Clone();
            _shapes.Add(anotherCircle);

            Rectangle rectangle = new()
            {
                Width = 10,
                Height = 20
            };
            _shapes.Add(rectangle);

            // Prototype lets you produce a copy of an object without knowing its type.
            List<Shape> shapesCopy = new();

            foreach (Shape s in _shapes)
            {
                shapesCopy.Add(s.Clone());
            }

            Console.WriteLine("Original list of shapes");
            PrintShape(_shapes);

            Console.WriteLine("");

            Console.WriteLine("Copied list of shapes");
            PrintShape(shapesCopy);
        }

        private static void PrintShape(List<Shape> shapes){
            foreach(Shape s in shapes){
                if(s is Rectangle rectangle){
                    Console.WriteLine( $"Rectangle: Height : {rectangle.Height}, Width : {rectangle.Width}");
                }
                else if(s is Circle circle){
                    Console.WriteLine($"Circle: Radius : {circle.Radius}");
                }
            }
        }
    }
}