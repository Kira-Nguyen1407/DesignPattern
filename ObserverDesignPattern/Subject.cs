using System;
using System.Threading;

namespace ObserverPattern{
    public class Subject : ISubject
    {
        public int State{get; set;}
        private List<IObserver> _observers = new();
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Add observer " + observer);
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Console.WriteLine("Removed observer " + observer);
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(var observer in _observers){
                observer.Update(this);
            }
        }

        public void BusinessLogic(){
            Console.WriteLine("\nSubject: I'm doing something important.");
            State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Subject: My state has just changed to: " + State);
            Notify();
        }
    }
}