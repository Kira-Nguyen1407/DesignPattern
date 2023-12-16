namespace BuilderPattern{
    // Product : House
    public class House{
        public string Foundation{get; set;} = "";
        public string Walls{get; set;} = "";
        public string Roof{get; set;} = "";
        public string Interior{get; set;} = "";

        public void ShowDetails(){
            Console.WriteLine($"House with: {Foundation}, {Walls}, {Roof}, {Interior}");
        }
    }
}