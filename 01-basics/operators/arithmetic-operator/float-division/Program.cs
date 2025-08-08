using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace float_division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Take two double inputs and divide them, print result.
            double userInput1, userInput2;
            Console.Write("Enter any number: ");
            userInput1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            userInput2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Division: {userInput1 / userInput2}");
        }
    }
}
