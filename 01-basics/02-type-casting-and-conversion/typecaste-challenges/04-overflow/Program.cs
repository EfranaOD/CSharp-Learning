using System;
using System.Net.NetworkInformation;

namespace _04_overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assign int max = int.MaxValue;
            //Convert it to short explicitly.
            //Print the result.Explain why the value is strange.

            int max = int.MaxValue;
            short min = (short)max;

            Console.WriteLine($"max value is {max} and short is {min}"); //it reallys is strange cause the short value was -1..? seriously.. but guess its because the 32 bits got truncated and the last 16 bits in the int 32 were assigned to short which prolly point to -1??
        }
    }
}
