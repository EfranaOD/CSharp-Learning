using System;

namespace _02_even_check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that takes an integer and prints "Even number" only if the number is divisible by 2.

            Console.Write("Enter a number: ");
            bool success = int.TryParse(Console.ReadLine(), out int result);
            if ( success && result % 2 == 0)
            {
                Console.WriteLine($"{result} is an Even number!");
            }
        }
    }
}
