namespace StrategyDesignPattern{
    public class Duck{

        private IFlyBehavior _flyBehavior;
        private IQuackBehavior _quackBehavior;

        public void PerformFly(){
            _flyBehavior.Fly();
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior){
            _flyBehavior = flyBehavior;
        }

        public IFlyBehavior GetFlyBehavior(){
            return _flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior){
            _quackBehavior = quackBehavior;
        }

        public IQuackBehavior GetQuackBehavior(){
            return _quackBehavior;
        }

        public void PerformQuack(){
            _quackBehavior.Quack();
        }

        public static void Swim(){
            Console.WriteLine("All ducks float, even decoys!");
        }

        public Duck(){
            _flyBehavior = new FlyWithWings();
            _quackBehavior = new Quack();
        }
    }
}