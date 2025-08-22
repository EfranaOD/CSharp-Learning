using System;

namespace _03_login_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask username & password. If both are correct and NOT empty, print “Login successful.”

            Console.Write("Enter username: ");
            string userName = Console.ReadLine()?.ToLower();
            Console.Write("Enter password: ");
            string password = Console.ReadLine()    ;

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Invalid input!");
            }
            else if (userName == "user" && password == "pwd")
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Your username or password didn't match.");
            }

            //just for some fun
            //if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            //{
            //    Console.WriteLine("Invalid input!");
            //}
            //else if (userName == "admin" && password == "password@123")
            //{
            //    Console.WriteLine("Login successful! Welcome back, Admin.");
            //}
            //else if(userName == "user" && password == "pwd")
            //{
            //    Console.WriteLine("You're not an admin");
            //}
        }
    }
}
