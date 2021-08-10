class Human
{
    // Fields for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    private int health;
     
    // add a public "getter" property to access health
    public int Health
    {
        get
        {
            return health;
        }
        
    }
     
    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
    public Human(string name)
    {
        Name = name;
        Strength = 50;
        Intelligence = 50;
        Dexterity = 50;
        health = 50;
    }
         

    // Add a constructor to assign custom values to all fields
         public Human(string name, int strength, int intelligence, int dexterity, int healthVal)
    {
        Name = name;
        Strength = strength;
        Intelligence = intelligence;
        Dexterity = dexterity;
        health = healthVal;
    }

    // Build Attack method
    public int Attack(Human target)
    {
        Console.WriteLine($"AAAHHRRGGGG I AM ATTACKING YOU {target.Name}");
        target.health -= 5*Strength;
        Console.WriteLine($"Target health is now {target.health}");
        return target.health;
    }
}

