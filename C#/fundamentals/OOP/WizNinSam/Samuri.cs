namespace WizNinSam
{
    class Samuri : Human
    {
        public Samuri(string name) : base(name)
        {
            health = 200;
        }
        public override int Attack(Human target)
        {
            int dmg = base.Attack(target);
            if (target.health <= 50)
            {
                dmg += target.health;
                target.health = 0;
                Console.WriteLine($"{target.Name}'s health is critically low! {Name} lands a killing blow!");
                return dmg;
            }
            else
            {
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
                return dmg;
            }
        }
        public void Meditate()
        {
            health = 200;
            Console.WriteLine($"{Name} meditated and restored full health!");
        }
    }
}