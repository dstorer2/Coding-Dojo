namespace HungryNinja
{
    class Buffet
    {
        public List<IConsumable> Menu;

        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Burrito", 1000, true, false),
                new Food("Chicken", 400, false, false),
                new Food("Sandwich", 500, false, false),
                new Food("Spaghetti", 900, false, false),
                new Food("Cake", 1000, false, true),
                new Food("Pad Thai", 1000, true, true),
                new Food("Mac 'N Cheese", 600, false, false),
                new Drink("Soda", 300, false, true),
                new Drink("Coffee", 10, false, false),
                new Drink("Sweet Tea", 20, false, true),
                new Drink("Water", 0, false, false),
                new Drink("Bloody Mary", 400, true, false)
            };
        }
        public IConsumable Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(12)];
        }
    }
}