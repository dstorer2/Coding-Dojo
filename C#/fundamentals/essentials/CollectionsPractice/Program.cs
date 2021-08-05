// See https://aka.ms/new-console-template for more information

int[] ints = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
string[] names = {"Tim", "Martin", "Nikki", "Sara"};
bool[] valid = {true, false, true, false, true, false, true, false, true, false};


List<string> flavors = new List<string>();
flavors.Add("Chocolate");
flavors.Add("Vanilla");
flavors.Add("Moose Tracks");
flavors.Add("Rocky Road");
flavors.Add("Superman");
flavors.Add("Cookies 'n Cream");

Console.WriteLine(flavors.Count);
Console.WriteLine(flavors[2]);
flavors.Remove(flavors[2]);
Console.WriteLine(flavors.Count);

Random rand = new Random();

Dictionary<string, string> peoplesFavs = new Dictionary<string, string>();

foreach (string name in names)
{
    peoplesFavs.Add(name, flavors[rand.Next(0,5)]);
}

foreach(KeyValuePair<string, string> entry in peoplesFavs)
{
    Console.WriteLine($"{entry.Key} likes {entry.Value}");
}
