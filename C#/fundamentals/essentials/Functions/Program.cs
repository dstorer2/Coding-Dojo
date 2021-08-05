using System;
using System.Collections.Generic;
namespace ConsoleApplication
{
    public class Program
    {
        public static void SayHello(string firstName = "Buddy")
        {
            Console.WriteLine($"Hello how are you doing today, {firstName}?");
        }
        public static void Main(string[] args)
        {
            SayHello();
        }
    }
}

