using System;

namespace _03GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hardcode a number: secret = 7.
            //Keep asking the user for input until they guess correctly.
            //Print "Correct!" when they get it right.

            int secret = 7;
            Console.Write("Guess the number(Hint- MSD): ");
            bool success = int.TryParse(Console.ReadLine(), out int userGuessNumber);
            if (!success) { Console.WriteLine("Invalid input!"); return; }
            while (userGuessNumber != secret)
            {
                Console.WriteLine("Wrong guess! Guess again.");
                bool successOne = int.TryParse(Console.ReadLine(), out userGuessNumber);
                if (!successOne) { Console.WriteLine("Invalid input!"); return; }
            }
            Console.WriteLine("Correct!");
        }
    }
}
