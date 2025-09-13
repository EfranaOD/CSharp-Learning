using System;

namespace _03MoneyCalcUsingDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a simple money calculation example (like 100.10m + 200.20m) and explain why decimal is the right choice there.

            Console.Write("Enter the amount: ");
            bool successOne = decimal.TryParse(Console.ReadLine(), out decimal userInputOne);

            Console.Write("Enter amount to add: ");
            bool successTwo = decimal.TryParse(Console.ReadLine(), out decimal userInputTwo);

            if(successOne && successTwo)
            {
                decimal result = userInputOne + userInputTwo;
                Console.WriteLine($"Your total amount is {result:C}");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.WriteLine("Decimal is used for money calculations because it avoids rounding issues and represents base-10 values exactly.");
        }
    }
}
