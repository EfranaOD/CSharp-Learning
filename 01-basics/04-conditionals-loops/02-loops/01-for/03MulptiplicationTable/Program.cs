using System;

namespace _03MulptiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print the multiplication table of 5 (from 5 x 1 to 5 x 10).

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"5 x {i} = {5 * i}");
            }
        }
    }
}
