using System;

namespace _01PrintNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for a number and keep printing it until they enter 0.
            int userInput;
            do
            {
                Console.Write("Enter a number: ");
                bool successOne = int.TryParse(Console.ReadLine(), out userInput);
                if (!successOne) { Console.WriteLine("Invalid input!"); return; }

                Console.WriteLine(userInput);
            } while (userInput != 0);
            Console.WriteLine($"\nExiting...");
        }
    }
}
