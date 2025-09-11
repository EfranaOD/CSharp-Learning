using System;

namespace _02SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given an integer, calculate the sum of its digits using a while loop.
            //Example: 1234 → 1+2+3+4 = 10

            Console.Write("Enter a number: ");
            bool success = int.TryParse(Console.ReadLine(), out int userInputNumber);
            if (!success) { Console.WriteLine("Invalid input!"); return; }

            int count = 0;
            while (userInputNumber > 0)
            {
                int digit = userInputNumber % 10; //gives us the last digit 
                count += digit;
                userInputNumber /= 10; //gives us without last digit
            }
            Console.WriteLine($"The sum of digits is {count}");
        }
    }
}
