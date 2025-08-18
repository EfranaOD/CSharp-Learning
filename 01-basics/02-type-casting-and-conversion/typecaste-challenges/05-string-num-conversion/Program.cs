using System;
using System.Net.NetworkInformation;

namespace _05_string_num_conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Take a string "123.45"
            //Convert it to double, then to int, then back to string.
            //Print each step.Explain data loss at each step.

            string str = "123.45";
            double d = Convert.ToDouble(str); //string is converted to double without issues because the literal is in the double format
            int n = Convert.ToInt32(d); //if we tried string to int here it would throw error format exception, because stirng value is not a whole number, but double is a precise decimal which then would be converted into whole number. but also? .45 data would be lost

            Console.WriteLine($"string: {str} -> {str.GetType()}, double: {d} -> {d.GetType()}, integer: {n} -> {n.GetType()}");
        }
    }
}
