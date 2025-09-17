using System;

namespace _01DoubleValue
{
    internal class Program
    {
        public static void DoubleValue(ref int number)
        {
            number = number * 2;
        }
        static void Main(string[] args)
        {
            //Takes an int parameter by reference using ref.
            //Multiplies the number by 2 inside the method.
            //Call it from Main() and show that the original variable is updated.

            int number = 10;
            Console.WriteLine($"Value before calling the method {number}");

            DoubleValue(ref number);

            Console.WriteLine($"Value after calling the method {number}");

        }
    }
}