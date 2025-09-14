using System;

namespace _01CharCategoryChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that takes a char as input and prints whether it’s:
            //a letter,
            //a digit,
            //whitespace,
            //or a special symbol.

            Console.Write("Enter a character: ");
            bool charConvSucc = char.TryParse(Console.ReadLine(), out char userInputCharacter);
            if (!charConvSucc) { Console.WriteLine("Invalid input!"); return; }

            if (char.IsLetter(userInputCharacter))
            {
                Console.WriteLine("You have entered a letter.");
            }
            else if (char.IsDigit(userInputCharacter))
            {
                Console.WriteLine("You have entered a digit.");
            }
            else if (char.IsWhiteSpace(userInputCharacter))
            {
                Console.WriteLine("You entered a whitespace character.");
            }
            else if(userInputCharacter == '\t' || userInputCharacter == '\n' || userInputCharacter == '\'' || userInputCharacter == '\\' || userInputCharacter == '@' || userInputCharacter == '!' || userInputCharacter == '#' || userInputCharacter == '$' || userInputCharacter == '&' || userInputCharacter == '*')
            {
                Console.WriteLine("You have entered a special character.");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

            Console.WriteLine("\nExiting...");
        }
    }
}
