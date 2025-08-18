using System;

namespace _07_surprise_conv_challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create float f = 9.78f;
            //Convert it to int, then to byte, then to double.
            //Print each step and explain what’s happening.

            float f = 257.78f;
            Console.WriteLine("Float vers: " + f);

            int n = Convert.ToInt32(f); //the precision will be lost and the float value near to whole number will be assigned as int is a whole number
            Console.WriteLine("Integer vers: " + n);

            byte b = Convert.ToByte(f); //same like int, gets converted to whole number which is near from float point
            Console.WriteLine("Byte vers: " + b);

            double d = Convert.ToDouble(f); //double will give precise value with 16 decimals which is its avg range than float which has only 2 to 4 decimals
            Console.WriteLine("Double vers: " + d);
        }
    }
}
