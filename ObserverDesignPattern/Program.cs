namespace ObserverPattern{
    public class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            var observerA = new ObserverA();
            var observerB = new ObserverB();

            subject.Attach(observerA);
            subject.Attach(observerB);

            subject.BusinessLogic();
            subject.BusinessLogic();

            subject.Detach(observerA);

            subject.BusinessLogic();
        }
    }
}