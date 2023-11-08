using System;

namespace StrategyDesignPattern{
    public class Ticket{
        private IPromoteStrategy _promoteStrategy;
        private double _price;
        private string _name;

        public IPromoteStrategy GetPromoteStrategy(){
            return _promoteStrategy;
        }

        public void SetPromoteStrategy(IPromoteStrategy value){
            _promoteStrategy = value;
        }

        public string GetName(){
            return _name;
        }

        public void SetName(string value){
            _name = value;
        }

        public double GetPrice(){
            return _price;
        }

        public void SetPrice(double value){
            _price = value;
        }

        public Ticket(IPromoteStrategy value){
            _promoteStrategy = value;
            _price = 0d;
            _name = "";
        }

        public Ticket(){
            _promoteStrategy = new NoDiscountStrategy();
            _price = 0d;
            _name = "";
        }

        public double GetPromotedPrice(){
            return _promoteStrategy.DoDiscount(_price);
        }
    }
}