namespace StatePattern{
    public class ConcreteStateB : State
    {
        public override void HandleA() { /*do nothing*/ }

        public override void HandleB()
        {
            Console.WriteLine("ConcreteStateB handles requestB.");
            Console.WriteLine("Transitioning to state A");
            _context?.Transition(new ConcreteStateA());
        }
    }
}