using System;

namespace _03_shift_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input a number, left shift by 1, 2, 3. Right shift by 1, 2, 3. Print results.

            int num = -7;

            Console.WriteLine(num);
            Console.WriteLine($"\nLeft shift on {num} by 1: {num << 1}");
            Console.WriteLine($"Left shift on {num} by 2: {num << 2}");
            Console.WriteLine($"Left shift on {num} by 3: {num << 3}");

            Console.WriteLine($"\nRight shift on {num} by 1: {num >> 1}");
            Console.WriteLine($"Right shift on {num} by 2: {num >> 2}");
            Console.WriteLine($"Right shift on {num} by 3: {num >> 3}");

            // 0 1 1 1 -> 7

            // LEFT SHIFT
            // 7 << 1
            // 0 0 0 0  1 1 1 0 -> the bits are shifted to Left by '1' -> 14
            // 7 << 2
            // 0 0 0 1  1 1 0 0 -> the bits are shifted to Left by '2' -> 28
            // 7 << 3
            // 0 0 1 1  1 0 0 0 -> the bits are shifted to Left by '3' -> 56

            // 7 >> 1
            // 0 0 0 0  0 0 1 1 -> the bits are shifted to right by '1' -> 3
            // 7 >> 2
            // 0 0 0 0  0 0 0 1 -> the bits are shifted to right by '2' -> 1
            // 7 >> 3
            // 0 0 0 0  0 0 0 0 -> the bits are shifted to right by '3' -> 0

            // shortcut to remember this is, for left shift(<<), num << k -> num * 2^k
            //                               for right shift(>>), num >> k -> num / 2^k -> rounded to floor

            // for negatives in right shift (>>)
            // before shifting is performed on the negative number its stored in the memory.. in signed bit format
            // to store -7:
            // 0 0 0 0  0 1 1 1 - 7
            // 1 1 1 1  1 0 0 0 - flipped. one's complement
            // add 1:
            // 1 1 1 1  1 0 0 1 = -7 -> this is -7 inside the memory. thats how compiler interprets the negative sign and stores it
            // now performing right shift on the -7, signed bit
            // 1 1 1 1  1 0 0 1 >> 1
            // 1 1 1 1  1 1 0 0
            // 
            // to get the value of ~(-7), we will perform two's complement again,
            // 1 1 1 1  1 1 0 0 -> MSB is 1, so the sign will be negative
            // 0 0 0 0  0 0 1 1 -> flipped. one's complement
            // add 1,
            // 0 0 0 0  0 1 0 0 -> 4
            // -4

            // shortcut for right shift on negative number, num>>k num / 2^k -> rounded to ceil  

        }
    }
}
