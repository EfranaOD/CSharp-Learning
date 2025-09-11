using System;

namespace _03SumOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given an array of numbers, calculate the sum using foreach.

            int[] numbers = { 2, 5, 3, 9, 12, 1 };
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum of elements in the array: {sum}");
        }
    }
}
