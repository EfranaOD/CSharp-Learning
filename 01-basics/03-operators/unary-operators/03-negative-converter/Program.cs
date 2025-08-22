using System;

namespace _03_negative_converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask a number, print both its positive and negative using unary plus and minus.

            Console.Write("Enter a number:");
            bool result = int.TryParse(Console.ReadLine(), out int userInput);

            if (!result)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            Console.WriteLine($"Positive input: {+userInput}");
            Console.WriteLine($"Negative input: {-userInput}");
        }
    }
}
