using System;

namespace _02NullCoalescing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare double? price = null
            //Use ?? to assign a default value of 99.99 if price is null. Print the result.

            double? price = null;

            double finalPrice = price ?? 99.99;
            Console.WriteLine($"Final Price: {finalPrice}");
        }
    }
}
