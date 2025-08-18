using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace _03_boxing_unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Box an int into an object.
            //Add 10 to it without unboxing first.
            //Observe what happens, then fix it correctly using unboxing.
            //Explain why direct arithmetic on a boxed object doesn’t work.

            int n = 5;
            object obj = n;
            //obj = obj + 10; doesn't work on boxed object as 10 is a int literal and obj is object and both different types
            obj = (int)obj + 10;
            Console.WriteLine($"{obj}, {n}");

            //Console.WriteLine(obj * n);

            int num = (int)obj;
            Console.WriteLine($"product of int and unboxed int, {num * n}");

        }
    }
}
