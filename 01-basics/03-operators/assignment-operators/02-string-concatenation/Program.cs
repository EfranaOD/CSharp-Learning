using System;

namespace _02_string_concatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Take a first name and last name, then use += to build the full name.

            Console.Write("Enter your first name: ");
            string userName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(lastName))
              userName += " " + lastName;

            Console.WriteLine($"So, your name is {userName}!? Ooh.. Nice name you got there, bud. ;P");
        }
    }
}
