namespace PrototypePattern{
    public abstract class Shape{
        public int X{ get; set; }
        public int Y{ get; set; }
        public string Color{get; set;} = "";

        // Default constructor
        public Shape(){ }

        // The prototype constructor. Initialize a new object with values from an existing object.
        public Shape(Shape source){
            X = source.X;
            Y = source.Y;
            Color = source.Color;
        }

        public abstract Shape Clone();
    }
}