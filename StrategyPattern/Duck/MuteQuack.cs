namespace StrategyDesignPattern{
    public class MuteQuack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Silence");
        }
    }
}