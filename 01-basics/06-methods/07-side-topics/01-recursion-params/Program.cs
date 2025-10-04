using System;

namespace _01_recursion_params
{
    internal class Program
    {
        public static int Factorial(int n)
        {
            if (n == 0) return 1;        // base case
            return n * Factorial(n - 1); // recursive call
        }
        public static int Average(params int[] numbers)
        {
            if(numbers.Length == 0) return 0;
            int total = 0;
            foreach (var n in numbers)
                total += n;
            return total/numbers.Length;
        }
        static void Main(string[] args)
        {
            //Write a recursive function to calculate factorial of a number.
            //Write a method using params to calculate average of numbers.
            //Call both methods in Main.

            Console.WriteLine(Factorial(6));
            Console.WriteLine(Average(3, 5, 9, 23, 2, 0));
        }
    }
}