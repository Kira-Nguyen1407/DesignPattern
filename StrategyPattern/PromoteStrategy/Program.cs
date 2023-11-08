using System;

namespace StrategyDesignPattern{
    public class Program{
        static void Main(string[] args){
            Console.WriteLine("Starting get tickets!");

            var random = new Random();

            for(int i = 0; i < 5; i++){
                var strategyIndex = random.Next(0,3);

                var ticket = new Ticket();
                ticket.SetName("Ticket " + i);
                ticket.SetPrice(50*i);

                switch(strategyIndex)
                {
                    case 0:
                        ticket.SetPromoteStrategy(new NoDiscountStrategy());
                        break;
                    case 1:
                        ticket.SetPromoteStrategy(new QuarterDiscountStrategy());
                        break;
                    default:
                        ticket.SetPromoteStrategy(new HalfDiscountStrategy());
                        break;
                }

                Console.WriteLine("Promoted price of " + ticket.GetName() + " is " +
                    ticket.GetPromotedPrice() + " " + ticket.GetPromoteStrategy().GetType());
                Console.WriteLine();
            }
        }
    }
}