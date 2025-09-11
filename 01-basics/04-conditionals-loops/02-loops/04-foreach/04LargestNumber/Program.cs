using System;

namespace _04LargestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given an array of integers, use a foreach loop to find the largest number.
            //Print the largest number at the end.

            int[] numbers = { 4, 7, 2, 9, 5 };
            int largestNumber = numbers[0];
            foreach (int number in numbers)
            {
                if(largestNumber < number)
                {
                    largestNumber = number;
                }
            }
            Console.WriteLine($"The largest number is {largestNumber}");
        }
    }
}
