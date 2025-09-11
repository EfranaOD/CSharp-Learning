using System;

namespace _02SumOfN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Take an integer N and calculate the sum of numbers from 1 to N.

            Console.Write("Enter a number: ");
            bool success = int.TryParse(Console.ReadLine(), out int userInputNum);
            int count = 0;
            for(int i = 1; i <= userInputNum; i++)
            {
                count += i;
            }
            Console.WriteLine($"The sum of numbers from 1 to {userInputNum} is {count}.");
        }
    }
}
