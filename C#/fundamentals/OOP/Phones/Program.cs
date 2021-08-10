namespace Phones
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Galaxy s8 = new Galaxy("s8", 100, "Verison", "Dooo do doo dooo");
            Nokia elevenHundred = new Nokia("1100", 60, "MetroPCS", "**eye of the tiger**");

            s8.DisplayInfo();
            Console.WriteLine(s8.Ring());
            Console.WriteLine(s8.Unlock());
            Console.WriteLine("");

            elevenHundred.DisplayInfo();
            Console.WriteLine(elevenHundred.Ring());
            Console.WriteLine(elevenHundred.Unlock());
            Console.WriteLine("");
        }
    }
}