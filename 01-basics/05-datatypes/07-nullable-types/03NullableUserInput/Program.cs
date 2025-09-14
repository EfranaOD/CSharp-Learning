using System;

namespace _03NullableUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for a number input.
            //If user enters nothing, print "No input".
            //If user enters a number, print its square using ?.. 
            //If parsing fails, print 0 (default) using ??.

            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
                        
            int? userNumber = string.IsNullOrWhiteSpace(userInput) 
                ? (int?)null 
                : int.TryParse(userInput, out int parsed) 
                    ? parsed 
                    : (int?)null;

            int? square = userNumber.HasValue ? userNumber.Value * userNumber.Value : (int?)null;

            int displaySquare = square ?? 0;

            Console.WriteLine(userNumber == null ? "No input" : $"Your number: {userNumber}");
            Console.WriteLine($"Square: {displaySquare}");
        }
    }
}
