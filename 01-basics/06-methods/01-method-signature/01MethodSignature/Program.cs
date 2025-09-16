using System;

namespace _01MethodSignature
{
    internal class Program
    {
        public static string FullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
        static void Main(string[] args)
        {
            //Takes first name and last name as parameters.
            //Returns the full name as a single string.
            //Call this method from Main() and print the result.

            string result = FullName("Efrana", "Mohammed");
            Console.WriteLine(result);
        }
    }
}
