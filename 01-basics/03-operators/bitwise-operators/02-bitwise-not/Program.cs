using System;

namespace _02_bitwise_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input a number, print original and ~number.
            //(Explain why ~5 = -6 using two’s complement.)

            int num = 5;

            Console.WriteLine(num);
            Console.WriteLine(~num);

            // 8 4 2 1
            // 0 0 0 0  0 1 0 1 -> 5
            // 1 1 1 1  1 0 1 0 -> ~ -> ? bitwise NOT (~) flips all 0's to 1's and 1's to 0's. which also one's complement
            // in 8 bits it would look like this:
            // 1 1 1 1  1 0 1 0 -> ? so, whats happenening here is, int is 'SIGNED', meaning, it consists of 'Negatives' as well as 'Positives'
            //                       negatives in int were calculated while storing like this
            //                       the left most bit, most significant bit(MSB), is considered as the sign, like +/- depending on the digit.
            //                       if the digit 1, then MSB is considered as negative sign. if 0, then positive.
            // how is ~5 after its bits gets flipped interpreted by the compiler:
            // MSB, if negative, is substracted from the other bits like this,
            // 1(-)  1   1   1   1  0  1  0
            // 128  64  32  16  8  4  2  1 -> -128 + 64 + 32 + 16 + 8 + 0 + 2 + 0 = -6
              
            // there is another shortcut to remember this method:
            // ~num = -(num + 1)
        }
    }
}
