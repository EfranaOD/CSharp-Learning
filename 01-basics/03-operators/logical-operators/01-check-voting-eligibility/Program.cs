using System;
using System.Configuration;

namespace _01_check_voting_eligibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask age and nationality. User can vote if (age >= 18 && nationality == "Indian").

            Console.Write("Enter your age: ");
            bool success = int.TryParse(Console.ReadLine(), out int userAge);
            Console.Write("Enter your nationality: ");
            string userNationality = Console.ReadLine()?.ToLower();

            if (!success || string.IsNullOrWhiteSpace(userNationality))
            {
                Console.WriteLine("Invalid input!");
            }
            else if (userAge >= 18 && userNationality == "indian")
            {
                Console.WriteLine("You are eligible to vote!");
            }
            else
            {
                Console.WriteLine("Either you are under age or not Indian. So, you are not eligible to vote!");
            }
        }
    }
}
