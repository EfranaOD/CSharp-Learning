using System;

namespace _02_check_eligibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask age from user, print if they are eligible to vote (>=18).

            Console.Write("Enter your age: ");
            if(int.TryParse(Console.ReadLine(), out int userAge))
            {
                Console.WriteLine(userAge >= 18 ? "You are an adult." : "You are still a minor.");
            }
            else
            {
                Console.WriteLine("Invalid input! Numbers only.");
            }
        }
    }
}
