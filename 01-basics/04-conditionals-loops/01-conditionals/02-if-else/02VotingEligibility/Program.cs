using System;

namespace _02VotingEligibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program where age is an integer.
            //If age >= 18 → print "Eligible to vote".
            //Else → print "Not eligible to vote".

            Console.Write("Enter your age: ");
            bool success = int.TryParse(Console.ReadLine(), out int userAge);
            if ( success && userAge >= 18)
            {
                Console.WriteLine($"Your age is {userAge}. Eligible to vote.");
            }
            else
            {
                Console.WriteLine($"Your age is {userAge}. Not eligible to vote");
            }
        }
    }
}
