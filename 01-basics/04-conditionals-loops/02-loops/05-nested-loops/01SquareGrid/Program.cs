using System;

namespace _01SquareGrid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Square grid of numbers
            //1 2 3
            //1 2 3
            //1 2 3

            for(int row = 1; row <= 3; row++)
            {
                for(int col = 1; col <= 3; col++)
                {
                    Console.Write($"{col} ");
                }
                Console.WriteLine();
            }
        }
    }
}
