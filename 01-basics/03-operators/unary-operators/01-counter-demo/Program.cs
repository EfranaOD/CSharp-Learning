using System;

namespace _01_counter_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start with int count = 0;. Print values using both prefix and postfix increments to show the difference.

            Console.Write("Enter any number: ");
            bool success = int.TryParse(Console.ReadLine(), out int userInput);

            Console.WriteLine(++userInput);
            Console.WriteLine(userInput++);

            Console.WriteLine(userInput);

        }
    }
}
