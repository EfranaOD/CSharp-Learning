using System;

namespace _02ReferenceTypeSharedBehavior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program showing that changing one reference type variable does affect another.

            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int[] number = numbers;
            number[0] = 50;

            Console.WriteLine(number[0] + "\n" + numbers[0]);
        }
    }
}
