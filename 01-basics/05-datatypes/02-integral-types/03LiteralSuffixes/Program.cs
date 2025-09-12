using System;

namespace _03LiteralSuffixes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demonstrate how suffixes work (L, U, etc.) with literals.

            ulong num1 = 40UL;
            long num2 = 30L;
            uint num3 = 50U;
            Console.WriteLine($"{num1}: {num1.GetType()}\n{num2}: {num2.GetType()}\n{num3}: {num3.GetType()}");

            float num4 = 3.85f;
            double num5 = 5.383454d;
            decimal num6 = 9.2324348924m;

            Console.WriteLine($"{num4}: {num4.GetType()}\n{num5}: {num5.GetType()}\n{num6}: {num6.GetType()}");
        }
    }
}
