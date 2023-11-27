namespace FactoryMethod{
    public class Program
    {
        public static void Main(string[] args){
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            Client.ClientCode(new ConcreteCreator1());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            Client.ClientCode(new ConcreteCreator2());
        }
    }
}