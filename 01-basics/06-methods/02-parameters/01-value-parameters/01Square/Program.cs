using System;

namespace _01Square
{
    internal class Program
    {
        public static void Square(int number)
        {
            number = number*number;
            Console.WriteLine($"Square value inside method: {number}");
        }
        static void Main(string[] args)
        {
            int number = 50;
            Square(number);

            Console.WriteLine($"Original value outside method: {number}");
        }
    }
}
