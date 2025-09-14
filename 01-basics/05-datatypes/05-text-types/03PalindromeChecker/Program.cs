using System;

namespace _03PalindromeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that checks if a string is a palindrome (reads the same forwards and backwards).

            Console.Write("Enter a word to check palindrome: ");
            string userInput = Console.ReadLine().Trim().ToLower();

            for(int i = 0; i < userInput.Length/2; i++)
            {
                if(userInput[i] == userInput[userInput.Length - 1 - i])
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("It is not a palindrome.");
                    return;
                }
            }
            Console.WriteLine("It is a palindrome");
        }
    }
}
