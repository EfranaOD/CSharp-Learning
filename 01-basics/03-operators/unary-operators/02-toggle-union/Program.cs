using System;

namespace _02_toggle_union
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask user a yes/no input, store as bool, and flip it using !.

            Console.WriteLine("Would you like to check the toggle?");
            string userInput = Console.ReadLine()?.Trim().ToLower();
            if(userInput == "yes" || userInput == "no" )
            {
                bool toggle = userInput == "yes";
                Console.WriteLine($"Your input got toggled: {!toggle} ");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
