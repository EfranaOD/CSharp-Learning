using System;

namespace _03NumberClassification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given an integer num.
            //First check if it’s positive.
            //  If true → then check if it’s even or odd.
            //Else → print "Number is negative or zero".

            Console.Write("Enter a number: ");
            bool success = int.TryParse(Console.ReadLine(), out int number);

            if (!success)
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            if( number > 0)
            {
                if(number%2 == 0)
                {
                    Console.WriteLine($"{number} is Even");
                }
                else
                {
                    Console.WriteLine($"{number} is Odd");
                }
            }
            else
            {
                if(number < 0)
                {
                    Console.WriteLine("Negative number");
                }
                else if(number == 0)
                {
                    Console.WriteLine("Number is Zero");
                }
            }
        }
    }
}
