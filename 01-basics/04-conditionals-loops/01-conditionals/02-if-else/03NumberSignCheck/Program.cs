using System;
namespace _03NumberSignCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that checks if a number is positive or negative.

            Console.Write("Enter a number: ");
            bool success = int.TryParse(Console.ReadLine(), out int userInputNumber);
            if ( success &&  userInputNumber > 0)
            {
                Console.WriteLine($"You've entered {userInputNumber}. Positive!");
            }
            else
            {
                Console.WriteLine($"You've entered {userInputNumber}. Negative!");
            }
        }
    }
}
