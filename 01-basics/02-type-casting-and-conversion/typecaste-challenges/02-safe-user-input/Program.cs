using System;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace _02_safe_user_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask the user to input a number.
            //Safely convert it to int using TryParse.
            //If conversion fails, ask again until they enter a valid number.
            //Print the final number and its type.

            int userInput;
            Console.Write("Enter any number: ");

            for(int i = 0; i < 3; i++)
            {
                bool success = int.TryParse(Console.ReadLine(), out userInput);
                if (success)
                {
                    Console.WriteLine($"You have entered a number. input: {userInput}");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid! Enter numbers only. try again.");
                }
            }
        }
    }
}
