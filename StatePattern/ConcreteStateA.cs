namespace StatePattern{
    public class ConcreteStateA : State
    {
        public override void HandleA()
        {
            Console.WriteLine("ConcreteStateA handles requestA.");
            Console.WriteLine("Transitioning to state B");
            _context?.Transition(new ConcreteStateB());
        }

        public override void HandleB() { /*Do nothing*/}
    }
}