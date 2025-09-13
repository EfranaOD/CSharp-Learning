using System;

namespace _02TypesPrecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare the same real number (12345.6789) as float, double, and decimal. Print them all with ToString("G20") (20 digits) to see precision differences.

            float f = 12345.6789f;
            double d = 12345.6789d;
            decimal m = 12345.6789m;

            Console.WriteLine("Float precision: " + f.ToString("G20"));
            Console.WriteLine("Double precision: " + d.ToString("G20"));
            Console.WriteLine("Decimal precision: " + m.ToString("G20"));

            Console.WriteLine("Notice how float has fewer digits and may round, while decimal keeps exact precision for base-10 numbers.");
        }
    }
}
