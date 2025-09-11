using System;

namespace _02PasswordCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hardcode a password (like "dotnet123").
            //Keep asking user input until they enter the correct one.
            //Show "Access granted!" once they get it right.

            string password = "dotnet123", userInputPassword;

            do
            {
                Console.Write("Enter the password: ");
                userInputPassword = Console.ReadLine();
            } while(userInputPassword != password);

            Console.WriteLine("\nAccess Granted!\n\nExiting...");
        }
    }
}
