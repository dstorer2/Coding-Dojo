namespace WizNinSam
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int health;
        public int Health
        {
            get { return health; }
        }
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }
        public virtual int Attack(Human target)
        {
            int dmg = Strength*3;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return dmg;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name is {Name}");
            Console.WriteLine($"Strength is {Strength}");
            Console.WriteLine($"Intelligence is {Intelligence}");
            Console.WriteLine($"Dexterity is {Dexterity}");
            Console.WriteLine($"Health is {health}");
        }
    }
}