using System;

namespace _02Cube
{
    internal class Program
    {
        public static void Cube(int number)
        {
            number = number * number * number;
            Console.WriteLine($"Cube value inside method: {number}");
        }
        static void Main(string[] args)
        {
            //Write a method that takes an integer as a value parameter, calculates its cube (number * number * number), and prints the cube inside the method.

            int number = 5;
            Cube(number);

            Console.WriteLine($"Original value outside method: {number}");
        }
    }
}
