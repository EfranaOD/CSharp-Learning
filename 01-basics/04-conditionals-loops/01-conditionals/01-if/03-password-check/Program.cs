using System;

namespace _03_password_check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hardcode a string variable password = "secret".
            //Use if to print "Access granted" only if the password matches "secret".

            string password = "secret";
            Console.Write("Enter the password: ");
            string userPassword = Console.ReadLine();
            if ( userPassword == password)
            {
                Console.WriteLine("Access granted!");
            }
        }
    }
}
