using System;

namespace _01ValueTypeCopyBehavior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program showing that changing one value type variable doesn’t affect another.

            int numberOne = 5;
            int numberTwo = numberOne;
            numberOne = 10;

            Console.WriteLine(numberOne + "\n" + numberTwo);
        }
    }
}
