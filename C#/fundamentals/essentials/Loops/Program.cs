// See https://aka.ms/new-console-template for more information
// loop from 1 to 5 including 5


// for (int i = 1; i <= 5; i++)
// {
//     Console.WriteLine(i);
// }
// // loop from 1 to 5 excluding 5
// for (int i = 1; i < 5; i++)
// {
//     Console.WriteLine(i);
// }

Random rand = new Random();

for (int val = 0; val < 10; val++)
{
    Console.WriteLine(rand.NextDouble());
}