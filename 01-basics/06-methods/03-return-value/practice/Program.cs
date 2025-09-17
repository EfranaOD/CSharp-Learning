using System;

namespace practice
{
    internal class Program
    {
        public static int Square(int number)
        {
            return number * number;
        }
        public static bool IsEven(int number)
        {
            return number%2 == 0;
        }
        public static string GetFullName(string firstName, string lastName)
        {
            return firstName + " " +lastName;
        }
        public static double Divide(int numberOne, int numberTwo)
        {
            return (double)(numberOne/numberTwo);           
        }
        static void Main(string[] args)
        {
            //Write a method Square that takes an int and returns its square.
            Console.Write("Enter a number: ");
            bool inputNumSucc = int.TryParse(Console.ReadLine(), out int number);
            if (!inputNumSucc) { Console.WriteLine("Invalid input"); return; }

            Console.WriteLine($"Square of {number} is {Square(number)}");

            //Write a method IsEven that takes an int and returns a bool.
            string isEven = IsEven(number) ? "even" : "not even";
            Console.WriteLine($"\n{number} is {isEven}.");

            //Write a method GetFullName that takes first and last name, returns a single string "First Last".
            Console.Write("\nEnter your first name: ");
            string? firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string? lastName = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                Console.WriteLine("Firstname or lastname cannot be empty!");
                return;
            }

            Console.WriteLine($"\nYour fullname is {GetFullName(firstName, lastName)}.");

            //Write a method Divide that takes two numbers and returns the result as double.
            Console.Write("\nEnter dividend: ");
            bool dividendSucc = int.TryParse(Console.ReadLine(), out int dividend);
            Console.Write("Enter divisor: ");
            bool divisorSucc = int.TryParse(Console.ReadLine(), out int divisor);
            if (!dividendSucc || !divisorSucc) { Console.WriteLine("Invalid input"); return; }
            if(divisor == 0) 
            {
                Console.WriteLine("Divisor cannot be zero.");
                return;
            }
            Console.WriteLine($"\nDivision of {dividend} and {divisor} is {Divide(dividend, divisor)}");
        }
    }
}
