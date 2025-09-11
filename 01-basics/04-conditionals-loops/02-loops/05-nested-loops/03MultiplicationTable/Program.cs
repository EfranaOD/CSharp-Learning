using System;

namespace _03MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Multiplication table (1 to 5)
            //1  2  3  4  5
            //2  4  6  8  10
            //3  6  9  12 15
            //4  8  12 16 20
            //5  10 15 20 25

            for(int row = 1; row <= 5; row++)
            {
                for(int col = 1; col <= 5; col++)
                {
                    Console.Write($"{row * col,3} ");
                }
                Console.WriteLine("\n");
            }

        }
    }
}
