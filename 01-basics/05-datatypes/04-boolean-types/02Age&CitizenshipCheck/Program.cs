using System;

namespace _02Age_CitizenshipCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that asks the user:
            //Age (int)
            //Whether they are a citizen (bool: true/false)
            //If the age is 18 or above AND they are a citizen, print "Eligible to Vote". Otherwise print "Not Eligible".

            Console.Write("Enter your age: ");
            bool ageInputSuccess = int.TryParse(Console.ReadLine().Trim(), out int age);
            if (!ageInputSuccess) { Console.WriteLine("Invalid age!"); return; }
            Console.Write("Are you a citizen?(true/false)");
            bool isCitizenSuccess = bool.TryParse(Console.ReadLine(), out bool isCitizen);

            if(age >= 18 && isCitizen)
            {
                Console.WriteLine("Eligible to Vote");
            }
            else
            {
                Console.WriteLine("Not Eligible");
            }
            Console.WriteLine("\nExiting...");
        }
    }
}
