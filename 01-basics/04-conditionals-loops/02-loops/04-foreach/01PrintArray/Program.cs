using System;

namespace _01PrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given an array of integers, use foreach to print them.

            int[] numbers = { 1, 2, 3, 5, 7, 11 };
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
