using System;

namespace _01_positive_check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that takes an integer and prints "Positive number" only if the number is greater than 0.

            Console.Write("Enter any number: ");
            bool success = int.TryParse(Console.ReadLine(), out int result);
            if ( success && result > 0)
            {
                Console.WriteLine($"{result} is a positive number!");
            }
        }
    }
}
