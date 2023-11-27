namespace ObserverPattern{
    public class ObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if(subject is Subject {State: >= 3}){
                Console.WriteLine("ConcreteObserverB: Reacted to the event when State >= 3.");
            }
        }
    }
}