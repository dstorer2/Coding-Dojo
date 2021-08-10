namespace HungryNinja
{
        public class Program
    {
        public static void Main(string[] args)
        {
            Buffet NinjaBuffet = new Buffet();
            SweetTooth jim = new SweetTooth("Jim");
            SpiceHound dwight = new SpiceHound("Dwight");
            jim.Consume(NinjaBuffet.Serve());
            jim.Consume(NinjaBuffet.Serve());
            jim.Consume(NinjaBuffet.Serve());
            jim.Consume(NinjaBuffet.Serve());
            jim.Consume(NinjaBuffet.Serve());
            dwight.Consume(NinjaBuffet.Serve());
            dwight.Consume(NinjaBuffet.Serve());
            dwight.Consume(NinjaBuffet.Serve());
            dwight.Consume(NinjaBuffet.Serve());
            dwight.Consume(NinjaBuffet.Serve());
            dwight.Consume(NinjaBuffet.Serve());
            dwight.Consume(NinjaBuffet.Serve());
            if(jim.consumptionHistory.Count > dwight.consumptionHistory.Count)
            {
                Console.WriteLine($"Jim consumed more than Dwight! Jim had {jim.consumptionHistory.Count} items while Dwight only had {dwight.consumptionHistory.Count} items");
            }
            else if (dwight.consumptionHistory.Count > jim.consumptionHistory.Count)
            {
                Console.WriteLine($"Dwight consumed more than Jim! Dwight had {dwight.consumptionHistory.Count} items while Jim only had {jim.consumptionHistory.Count} items");
            }
            else
            {
                Console.WriteLine($"Jim and dwight both ate {jim.consumptionHistory.Count} items!");
            }
        }
    }
}