using System;

namespace _04Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculate factorial of a number (e.g., 5! = 120) using a while loop.

            Console.Write("Enter a number: ");
            bool success = int.TryParse(Console.ReadLine(), out int userInputNumber);
            if (!success) { Console.WriteLine("Invalid input"); return; }

            int count = 1, i = 1;
            while ( i <= userInputNumber)
            {
                count *= i;
                i++;
            }
            Console.WriteLine($"Factorial of {userInputNumber} is {count}");
        }
    }
}
