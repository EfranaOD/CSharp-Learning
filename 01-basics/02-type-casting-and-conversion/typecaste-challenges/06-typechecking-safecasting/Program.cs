using System;

namespace _06_typechecking_safecasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an object[] array with mixed types: int, double, string.
            //Loop through it and print only numbers, safely casting each

            object[] arr = { 123, "Efrana", true, 34.5454287d, "32", "2324.865213", "4"};

            for(int i = 0; i < arr.Length; i++)
            {
                object obj = arr[i];
                if(obj is int n)
                {
                    Console.WriteLine("Integer: " + n);
                }
                else if(obj is string)
                {
                    string str = (string)obj;
                    if (int.TryParse(str, out int val))
                    {
                        Console.WriteLine("Integer: " + val);
                    }
                    else if (double.TryParse(str, out double vale))
                    {
                        Console.WriteLine("Double: " + vale);
                    }
                    else
                    {
                        Console.WriteLine("String: " + str);
                    }
                }
                else if (obj is double d)
                {
                    Console.WriteLine("Double: " + d);
                }
                else
                {
                    Console.WriteLine("Remaining Type: " + obj);
                }
            }

        }
    }
}
