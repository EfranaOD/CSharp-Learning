using System;

namespace _01ObjectInfoPrinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a few variables of different types (int, double, string, bool).
            //Store each of them in an object variable.
            //Print the type(GetType()) and value of each object.
            //Optionally, demonstrate casting back to the original type for one variable and perform a simple operation(like addition for int / double or string concatenation).

            int num = 146;
            double doub = 32.928;
            string name = "Test";
            bool isActive = false;

            object numObj = num;
            object doubleObj = doub;
            object stringObj = name;
            object boolObj = isActive;

            Console.WriteLine($"Value: {numObj}. Type: {numObj.GetType()}");
            Console.WriteLine($"Value: {doubleObj}. Type: {doubleObj.GetType()}");
            Console.WriteLine($"Value: {stringObj}. Type: {stringObj.GetType()}");
            Console.WriteLine($"Value: {boolObj}. Type: {boolObj.GetType()}");

            // Casting back example
            int number = (int)numObj;
            string concatenatedResult = name + number;
            Console.WriteLine($"Concatenated string: {concatenatedResult}");
        }
    }
}
