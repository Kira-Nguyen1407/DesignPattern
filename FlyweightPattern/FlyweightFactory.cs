namespace FlyweightPattern{
    // The Flyweight Factory creates and manages the Flyweight objects. It
    // ensures that flyweights are shared correctly. When the client requests a
    // flyweight, the factory either returns an existing instance or creates a
    // new one, if it doesn't exist yet.
    public class FlyweightFactory{
        private readonly List<Tuple<Flyweight, string>> flyweights = new();

        public FlyweightFactory(params Car[] args)
        {
            foreach (var elem in args)
            {
                flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(elem), GetKey(elem)));
            }
        }

        // Returns a Flyweight's string hash for a given state.
        public static string GetKey(Car key)
        {
            List<string> elements = new()
            {
                key.Model,
                key.Color,
                key.Company
            };

            if (key.Owner != null && key.Number != null)
            {
                elements.Add(key.Number);
                elements.Add(key.Owner);
            }

            elements.Sort();

            return string.Join("_", elements);
        }

        // Returns an existing Flyweight with a given state or creates a new
        // one.
        public Flyweight GetFlyweight(Car sharedState)
        {
            string key = GetKey(sharedState);

            var existingFlyweight = flyweights.FirstOrDefault(t => t.Item2 == key);
            
            if (existingFlyweight == null)
            {
                Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating a new one.");
                var newFlyweight = new Flyweight(sharedState);
                flyweights.Add(new Tuple<Flyweight, string>(newFlyweight, key));
                return newFlyweight;
            }
            else
            {
                Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
                return existingFlyweight.Item1;
            }
        }

        public void ListFlyweights()
        {
            var count = flyweights.Count;
            Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
            foreach (var flyweight in flyweights)
            {
                Console.WriteLine(flyweight.Item2);
            }
        }
    }
}