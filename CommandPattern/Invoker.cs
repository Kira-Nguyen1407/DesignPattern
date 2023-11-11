namespace CommandPattern{
    public class Invoker{
        private ICommand? _onStart;
        private ICommand? _onFinish;

        public void SetOnStart(ICommand command){
            _onStart = command;
        }

        public void SetOnFinish(ICommand command){
            _onFinish = command;
        }

        public void DoSomethingImportant(){
            _onStart?.Execute();

            Console.WriteLine("Invoker: ...doing something really important...");
            Console.WriteLine("Invoker: Does anybody want something done after I finish?");

            _onFinish?.Execute();
        }
    }
}