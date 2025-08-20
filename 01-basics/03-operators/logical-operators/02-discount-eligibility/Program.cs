using System;

namespace _02_discount_eligibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //If a customer is a student OR above 60 years, they get a discount.

            Console.WriteLine("Are you a student?");
            string isStud = Console.ReadLine()?.ToLower();
            bool custIsStud = (isStud == "yes");
            Console.Write("What is your age? ");
            bool success = int.TryParse(Console.ReadLine(), out int custAge);

            if(!success || string.IsNullOrWhiteSpace(isStud))
            {
                Console.WriteLine("Invalid input!");
            }
            else if (custAge > 60 || custIsStud)
            {
                Console.WriteLine("You are eligible for discount!");
            }
            else
            {
                Console.WriteLine("You are not eligible! you're not a student, nor above age of 60.");
            }
        }
    }
}
