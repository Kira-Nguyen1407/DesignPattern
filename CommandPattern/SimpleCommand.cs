using System.Runtime.CompilerServices;

namespace CommandPattern{
    public class SimpleCommand : ICommand
    {
        private readonly string _payload = "";

        public SimpleCommand(string payload){
            _payload = payload;
        }
        public void Execute()
        {
           Console.WriteLine($"SimpleCommand: See, I can do simple things like printing ({this._payload})");
        }
    }
}