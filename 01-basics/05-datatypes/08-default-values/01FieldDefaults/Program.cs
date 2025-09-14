using System;

namespace _01FieldDefaults
{
    internal class Program
    {
        class DefaultDemo
        {
            int number;
            bool isActive;
            char grade;
            string name;
            int? nullableNumber;
            public void PrintDetails()
            {
                Console.WriteLine("----- Default Field Values -----");
                Console.WriteLine($"Integer: {number}");
                Console.WriteLine($"Boolean: {isActive}");
                Console.WriteLine($"Character: '{grade}'");
                Console.WriteLine($"String: {name}");
                Console.WriteLine($"Nullable Integer: {nullableNumber}");
                Console.WriteLine("--------------------------------\n");
            }
        }
        static void Main(string[] args)
        {
            //Create a class DefaultsDemo with uninitialized fields: int, bool, char, string, int?.
            //Create a method to print each field.
            //Observe the default values.

            DefaultDemo demo = new DefaultDemo();
            demo.PrintDetails();
        }
    }
}
