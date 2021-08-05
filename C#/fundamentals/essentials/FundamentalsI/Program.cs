// See https://aka.ms/new-console-template for more information

// for (int i = 1; i <= 255; i++)
// {
//     Console.WriteLine(i);
// }



// for (int i = 1; i < 101; i++)
// {
//     if (i % 3 == 0 && i % 5 !=0)
//     {
//         Console.WriteLine("Fizz");
//     }
//     else if (i % 3 != 0  && i % 5 == 0)
//     {
//         Console.WriteLine("Buzz");
//     }
//     else if(i % 3 == 0  && i % 5 == 0)
//     {
//         Console.WriteLine("FizzBuzz");
//     }
// }



int j = 1;
while (j < 101)
{
        if (j % 3 == 0 && j % 5 !=0)
    {
        Console.WriteLine("Fizz");
    }
    else if (j % 3 != 0  && j % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if(j % 3 == 0  && j % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    j++;
}