namespace StrategyDesignPattern{
    public class Program{
        public static void Main(string[] args){
            Duck mallard_duck = new();
            mallard_duck.SetFlyBehavior(new FlyWithWings());
            mallard_duck.PerformFly();

            Duck rubberDuck = new();
            rubberDuck.SetFlyBehavior(new FlyNoWay());
            rubberDuck.PerformFly();
        }
    }
}
