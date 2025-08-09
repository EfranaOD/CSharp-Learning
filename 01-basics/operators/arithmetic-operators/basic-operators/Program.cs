using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Take two user inputs, print sum, difference, product, quotient, remainder.
            int userInputOne, userInputTwo;
            Console.Write("Enter any integer: ");
            userInputOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another integer: ");
            userInputTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Sum: {userInputOne + userInputTwo}");
            Console.WriteLine($"Diff: {userInputOne - userInputTwo}");
            Console.WriteLine($"Product: {userInputOne * userInputTwo}");
            Console.WriteLine($"Quotient: {userInputOne / userInputTwo}");
            Console.WriteLine($"Remainder: {userInputOne % userInputTwo}");
        }
    }
}
