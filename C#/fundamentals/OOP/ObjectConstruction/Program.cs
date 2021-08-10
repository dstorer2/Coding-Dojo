public class Vehicle
{
    public int NumPassengers;

    public Vehicle(int val = 5)
    {
        NumPassengers = val;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Vehicle myVehicle = new Vehicle();
        Console.WriteLine($"My vehicle is holdiong {myVehicle.NumPassengers} people");
    }
}