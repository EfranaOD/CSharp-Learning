using System;

namespace _02ValueAndType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program where you declare one variable of each integral type (byte, sbyte, short, ushort, int, uint, long, ulong, char) and print both their value and type using GetType().

            Console.WriteLine("Integral Types:");
            byte n1 = 255;
            sbyte n2 = -128;
            short n3 = 32767;
            ushort n4 = 65535;
            //int n5 = -2147483648;
            //uint n6 = 4294967295;
            //long n7 = 9223372036854775807;
            //ulong n8 = 18446744073709551615;
            char l = 'A';

            Console.WriteLine($"{n1.GetType()}: {n1}\n{n2.GetType()}: {n2}\n{n3.GetType()}: {n3}\n{l.GetType()}: {l}");
        }
    }
}
