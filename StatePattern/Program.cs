namespace StatePattern{
    public class Program{
        public static void Main(string[] args){

            // Client Code
            Context context = new(new ConcreteStateA());
            context.RequestA();
            context.RequestB();
        }
    }
}