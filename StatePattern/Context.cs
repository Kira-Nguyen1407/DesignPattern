namespace StatePattern{
    // The Context defines the interface of interest to clients. It also
    // maintains a reference to an instance of a State subclass, which
    // represents the current state of the Context.
    public class Context{
        // A reference to the current state of the Context.
        private State _state;

        public Context(State state){
            _state = state;
        }

        // The Context allows changing the State object at runtime.
        public void Transition(State state){
            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            _state = state;
        }

        // The Context delegates part of its behavior to the current State
        // object.
        public void RequestA(){
            _state.SetContext(this);
            if(_state is ConcreteStateA concreteStateA){
                concreteStateA.HandleA();
            }
        }

        public void RequestB(){
            _state.SetContext(this);
            if(_state is ConcreteStateB concreteStateB){
                concreteStateB.HandleB();
            }
        }
    }
}