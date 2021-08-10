namespace HungryNinja
{
    class SpiceHound : Ninja
    {
        public SpiceHound(string name) : base(name){}
        public override bool IsFull
        {
            get
            {
                if ( calorieIntake > 1200)
                {
                    return true;
                }
                return false;
            }
        }
        
        public override void Consume(IConsumable item)
        {
            if (!IsFull)
            {
                calorieIntake += item.Calories;
                if (item.IsSpicy)
                {
                    calorieIntake -= 5;
                }
                consumptionHistory.Add(item);
                item.GetInfo();
                Console.WriteLine($"{Name} had a {item.Name}!");
            }
            else
            {
                Console.WriteLine($"{Name} is too full! I don't think he can eat anymore!");
            }
        }
    }
}