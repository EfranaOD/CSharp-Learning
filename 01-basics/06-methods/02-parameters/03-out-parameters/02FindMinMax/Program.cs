using System;

namespace _02FindMinMax
{
    internal class Program
    {
        public static void FindMinMax(int[] numbers, out int min, out int max)
        {
            min = max = numbers[0];
            for(int i = 0; i < numbers.Length; i++)
            {
                max = numbers[i] > max ? numbers[i] : max;
                min = numbers[i] < min ? numbers[i] : min;
            }
        }
        static void Main(string[] args)
        {
            //Takes an integer array as input. Uses out parameters to return the minimum and maximum values in the array.

            int[] numbers = { 3, 1, 9, 4, 2, 6, 10 };

            int min, max;

            FindMinMax(numbers, out min, out max);

            Console.WriteLine($"Min value: {min}. Max value: {max}");
        }
    }
}