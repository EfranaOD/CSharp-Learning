using System;

namespace _01_arichmetic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create two variables: int a = 7; and double b = 2.5;
            //Perform arithmetic(addition, multiplication) and store the result in all three types: int, double, float.
            //Print each result and explain why each value looks different.

            int a = 7;
            double b = 2.53349283; //i changed b value from 2.5 to 2.53349283, to check float and double

            //addition
            int addInt = Convert.ToInt32(a + b); //needs explicit conversion
            double addDouble = a + b; //implicit conversion
            float addFloat = Convert.ToSingle(a + b); //large(double) value to smaller type, so needs explicit conv

            //multiplication
            int mulInt = Convert.ToInt32(a * b); //needs explicit conv
            double mulDouble = a * b; //again implicit conv
            float mulFloat = Convert.ToSingle(a * b); //explicit conv needed

            Console.WriteLine($"addition of {a} and {b} in integer type {addInt}");
            Console.WriteLine($"addition of {a} and {b} in double type {addDouble}");
            Console.WriteLine($"addition of {a} and {b} in float type {addFloat}");

            Console.WriteLine($"multiplication of {a} and {b} in integer type {mulInt}");
            Console.WriteLine($"multiplication of {a} and {b} in doouble type {mulDouble}");
            Console.WriteLine($"multiplication of {a} and {b} in float type {mulFloat}");
        }
    }
}
