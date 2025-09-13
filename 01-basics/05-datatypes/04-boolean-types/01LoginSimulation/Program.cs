using System;

namespace _01LoginSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that asks the user for a username and password.
            //If the username is "admin" and password is "1234", print "Login Successful".
            //Otherwise, print "Access Denied".

            Console.Write("Enter your username: ");
            string userName = Console.ReadLine().Trim().ToLower();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine().Trim();

            if(userName == "admin" && password == "1234")
            {
                Console.WriteLine("Login Successful!\nWelcome back, admin.");
            }
            else
            {
                Console.WriteLine("Access denied!");
            }
            Console.WriteLine("\nExiting...");
        }
    }
}
