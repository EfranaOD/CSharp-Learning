using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulus_usage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for a number, check if it’s even or odd using %.
            int userInput;
            Console.Write("enter any number: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            if(userInput % 2 == 0)
            {
                Console.WriteLine($"{userInput} is even");
            }
            else
            {
                Console.WriteLine($"{userInput} is odd");
            }
        }
    }
}
