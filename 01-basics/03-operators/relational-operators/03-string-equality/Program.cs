using System;

namespace _03_string_equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Take two string inputs, check if they are equal (case-sensitive).

            Console.Write("Enter something: ");
            string userInputOne = Console.ReadLine();
            Console.Write("Enter something again: ");
            string userInputTwo = Console.ReadLine();

            if(userInputOne == userInputTwo)
            {
                Console.WriteLine($"Your first input matches second input, {userInputOne}, {userInputTwo}");
            }
            else
            {
                Console.WriteLine($"Your inputs doesn't match, {userInputOne}, {userInputTwo}");
            }
        }
    }
}
