namespace HungryNinja
{
    abstract class Ninja
    {
        public string Name;
        public int calorieIntake;
        public List<IConsumable> consumptionHistory;
        public Ninja(string name)
        {
            Name = name;
            calorieIntake = 0;
            consumptionHistory = new List<IConsumable>();
        }
        public abstract bool IsFull {get;}
        public abstract void Consume(IConsumable item);
    }
}