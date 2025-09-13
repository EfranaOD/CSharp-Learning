using System;

namespace _01DoubleVsDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program showing the 0.1 + 0.2 rounding issue with double, and then fix it by using decimal.

            double a = 0.1, b = 0.2;
            double sum1 = a + b;

            Console.WriteLine($"{a} + {b} = {sum1}");
            Console.WriteLine(sum1 == 0.3 ? "Equal to 0.3" : "Not equal to 0.3");

            decimal c = 0.1m, d = 0.2m;
            decimal sum2 = c + d;
            Console.WriteLine($"{c} + {d} = {sum2}");
            Console.WriteLine(sum2 == 0.3m ? "Equal to 0.3" : "Not equal to 0.3");
        }
    }
}
