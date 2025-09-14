using System;

namespace _03TypeSafety
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program where you store a number in an object.
            //Try to unbox it into the wrong type (like storing int but unboxing to double).
            //Observe and handle the exception.

            object number = 146;

            //double intnumber = (double)number; //System.InvalidCastException: 'Specified cast is not valid.'

            double intNumber = Convert.ToDouble(number);

            Console.WriteLine($"Value: {intNumber} - Type: {intNumber.GetType()}");
        }
    }
}
