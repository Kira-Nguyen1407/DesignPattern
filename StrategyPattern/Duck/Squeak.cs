namespace StrategyDesignPattern{
    public class Squeak : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}