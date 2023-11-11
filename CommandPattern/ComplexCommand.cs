namespace CommandPattern{
    public class ComplexCommand : ICommand
    {
        private readonly Receiver _receiver;

        private readonly string _a;
        private readonly string _b;

        public ComplexCommand(Receiver receiver, string a, string b){
            _receiver = receiver;
            _a = a;
            _b = b;
        }

        public void Execute()
        {
            Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
            Receiver.DoSomething(this._a);
            Receiver.DoSomethingElse(this._b);
        }
    }
}