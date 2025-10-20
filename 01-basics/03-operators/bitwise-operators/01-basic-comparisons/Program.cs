using System;
using System.Net;

namespace _01_basic_comparisons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Take two ints from user. Print a & b, a | b, a ^ b.


            Console.Write("Enter a number: ");
            string userInput1 = Console.ReadLine();
            Console.Write("Enter another number: ");
            string userInput2 = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(userInput1) || string.IsNullOrWhiteSpace(userInput2))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            if(!int.TryParse(userInput1, out int result1) || !int.TryParse(userInput2, out int result2))
            {
                Console.WriteLine("Invalid input format.");
                return;
            }

            Console.WriteLine("\nBitwise Operations result:");
            Console.WriteLine($"{result1} & {result2} -> {result1 & result2}");
            Console.WriteLine($"{result1} | {result2} -> {result1 | result2}");
            Console.WriteLine($"{result1} ^ {result2} -> {result1 ^ result2}");

            //ex: 5 & 3 -> 0101 - 5
            //             0011 - 3
            //           ----------
            //           & 0001 - 1

            //    5 | 3 -> 0101 - 5
            //             0011 - 3
            //           ----------
            //           | 0111 - 7

            //    5 | 3 -> 0101 - 5
            //             0011 - 3
            //           ----------
            //           ^ 0110 - 6

            //  0  0  0  0   0 0 0 0
            // 128 64 32 16  8 4 2 1

            //  1  0  1  0   1 0 0 1  -> 179

            //  2147483648 1073741824 536870912 268435456
            //  134217728  67108864   33554432  16777216
            //  8388608    4194304    2097152   1048576
            //  524288     262144     131072    65536
            //  32768      16384      8192      4096
            //  2048       1024       512       256
            //  128        64         32        16
            //  8          4          2         1


        }
    }
}
