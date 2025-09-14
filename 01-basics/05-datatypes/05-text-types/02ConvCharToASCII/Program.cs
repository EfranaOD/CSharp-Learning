using System;

namespace _02ConvCharToASCII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input: a char.
            //Output: its ASCII(Unicode) numeric value.

            Console.Write("Enter a character: ");
            bool chatInputSucc = char.TryParse(Console.ReadLine(), out char userInputChar);
            if( !chatInputSucc ) { Console.WriteLine("Invalid input."); return; }

            Console.WriteLine($"Your input is, {userInputChar}");

            int asciiValue = (int)userInputChar;

            Console.Write($"ASCII value for {userInputChar} is {asciiValue}");
        }
    }
}
