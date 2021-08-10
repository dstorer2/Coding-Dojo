namespace WizNinSam
{
    class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            health = 50;
            Intelligence = 25;
        }
        public override int Attack(Human target)
        {
            int dmg = Intelligence*5;
            target.health -= dmg;
            Console.WriteLine($"{Name} cast a spell on {target.Name} for {dmg} damage!");
            return target.health;
        }
        public int Heal(Human target)
        {
            int restore = 10*Intelligence;
            target.health += restore;
            Console.WriteLine($"{Name} cast a healing spell on {target.Name} whose health has increased by {restore}. What a guy!");
            return restore;
        }
    }
}