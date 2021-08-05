using System;
using System.Collections.Generic;
namespace ConsoleApplication
{
    public class Program
    {
        public static void PrintNumbers()
        {
            for (int i = 1; i < 256; ++i)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintOdds()
        {
            for (int i = 1; i < 256; i +=2)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 0; i < 256; i++)
            {
                sum += i;
                Console.WriteLine($"New number: {i} Sum: {sum}");
            }
        }

        public static void LoopArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; ++i)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; ++i)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        public static int GetAverage(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; ++i)
            {
                sum += numbers[i];
            }
            int avg = sum / numbers.Length;
            return avg;
        }

        public static int[] OddArray()
        {
            int[] array = new int[255];
            int x = 1;
            for (int i = 0; i < 255; i += 2)
            {
                array[i] = x;
                ++x;
            }
        return array;
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; ++i)
            {
                if ( numbers[i] > y)
                {
                    count += 1;
                }
            }
            return count;
        }

        public static void SquareArrayValues(int[] numbers)
        {
            for (int i =0; i < numbers.Length; ++i)
            {
                Console.WriteLine(numbers[i]);
                numbers[i] *= numbers[i];
                Console.WriteLine(numbers[i]);
            }
        }

        public static void EliminateNegatives(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; ++i)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
                Console.WriteLine(numbers[i]);
            }
        }

        public static void MinMaxAverage(int[] numbers)
        {
            int max = numbers[0];
            int min = numbers[0];
            int sum = 0;
            for (int i = 1; i < numbers.Length; ++i)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                sum += numbers[i];
            }
            int avg = sum/numbers.Length;
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(avg);
        }

        public static void ShiftValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; ++i)
            {
                numbers[i] = numbers[i+1];
                Console.WriteLine(numbers[i]);
            }
            numbers[numbers.Length - 1] = 0;
            Console.WriteLine(numbers[numbers.Length - 1]);
        }

        public static object[] NumToString(int[] numbers)
        {
            object[] strings = new object[numbers.Length];
            for (int i = 0; i < numbers.Length; ++i)
            {
                if (numbers[i] < 0)
                {
                    strings[i] = "Dojo";
                }
                else
                {
                    strings[i] = numbers[i];
                }
                Console.WriteLine(strings[i]);
            }
            return strings;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(NumToString(new int[]{1,5,-3,6,-7,8,9}));
        }
    }
}