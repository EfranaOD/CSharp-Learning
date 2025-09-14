using System;

namespace _03NullableDefault
{
    internal class Program
    {
        class DefaultDemo
        {
            public int? number;
            public void PrintDetails()
            {
                Console.WriteLine(number == null ? "null" : number.ToString());
                Console.WriteLine($"'{number}'");
            }
        }
        static void Main(string[] args)
        {
            //Declare int? n; as a field in a class.
            //Print its value before assigning. Confirm it prints null.

            DefaultDemo demo = new DefaultDemo();
            demo.PrintDetails();
            demo.number = 42;
            demo.PrintDetails();
        }
    }
}
