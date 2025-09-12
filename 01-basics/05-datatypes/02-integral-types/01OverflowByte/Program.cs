using System;

namespace _01OverflowByte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Show an overflow case by trying to assign a value beyond the range of byte. Handle it with casting and show the wrapped result.

            //byte n1 = 300;
            int n2 = 300;
            byte n3 = (byte)n2;

            Console.WriteLine(n2 + " " + n3);
        }
    }
}
