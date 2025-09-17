using System;

namespace _02SwapNumbers
{
    internal class Program
    {
        public static void SwapNumbers(ref int numberOne, ref int numberTwo)
        {
            int numberThree = numberOne;
            numberOne = numberTwo;
            numberTwo = numberThree;
            Console.WriteLine($"In method - Swapped numbers, {numberOne} : {numberTwo}");
        }
        static void Main(string[] args)
        {
            //Takes two integers by reference (ref int a, ref int b). Swaps their values inside the method.

            Console.Write("Enter a number: ");
            bool numberOneSucc = int.TryParse(Console.ReadLine(), out int numberOne);
            Console.Write("Enter another number: ");
            bool numberTwoSucc = int.TryParse(Console.ReadLine(), out int numberTwo);
            if (!numberOneSucc || !numberTwoSucc) { Console.WriteLine("Invalid input"); return; }

            Console.WriteLine($"Numbers before calling method, {numberOne} : {numberTwo}");

            SwapNumbers(ref numberOne, ref numberTwo);
            Console.WriteLine($"Numbers after calling method, {numberOne} : {numberTwo}");
        }
    }
}