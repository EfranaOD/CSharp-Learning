using System;

namespace _01LoginSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Have two variables: username and password.
            //First check if username == "admin".
            //  If true → then check if password == "1234".
            //    If true → print "Login successful".
            //    Else → print "Wrong password".
            //  Else → print "User not found".

            Console.Write("Enter your user name: ");
            string userNameInput = Console.ReadLine().Trim();
            Console.Write("Enter your password: ");
            string passwordInput = Console.ReadLine().Trim();

            if ( userNameInput == "admin" )
            {
                if ( passwordInput == "1234" )
                {
                    Console.WriteLine("Login Successful!");
                }
                else
                {
                    Console.WriteLine("Password incorrect!");
                }
            }
            else
            {
                Console.WriteLine("User Not Found!");
            }
        }
    }
}
