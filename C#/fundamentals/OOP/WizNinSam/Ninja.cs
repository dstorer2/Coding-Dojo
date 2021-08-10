namespace WizNinSam
{
    class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }
        public override int Attack(Human target)
        {
            Random rand = new Random();
            int r = rand.Next(5);
            int dmg = 5*Dexterity;
            if (r<1)
            {
                dmg +=10;
                Console.WriteLine($"{Name} hit {target.Name} with all 5 throwing stars for {dmg} damage!");
                return dmg;
            }
            else
            {
                Console.WriteLine($"{Name} attacked {target.Name} with thowing stars! 4 of 5 hit the target! {dmg} damage was dealt!");
                return dmg;
            }
        }
        public void Steal(Human target)
        {
            target.health -= 5;
            health += 5;
            Console.WriteLine($"{Name} stole 5 points of health from {target.Name}!");
        }
    }
}