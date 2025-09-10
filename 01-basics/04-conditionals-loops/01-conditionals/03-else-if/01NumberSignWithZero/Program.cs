using System;

namespace _01NumberSignWithZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program to check if a number is positive, negative, or zero using an else if ladder.

            Console.Write("Enter a number: ");
            bool success = int.TryParse(Console.ReadLine(), out int userInputNumber);
            if ( success &&  userInputNumber > 0)
            {
                Console.WriteLine("Positive!");
            }
            else if ( success && userInputNumber < 0)
            {
                Console.WriteLine("Negative!");
            }
            else if ( success && userInputNumber == 0)
            {
                Console.WriteLine("Zero!");
            }
            else
            {
                Console.WriteLine("Invalid!");
            }
        }
    }
}
