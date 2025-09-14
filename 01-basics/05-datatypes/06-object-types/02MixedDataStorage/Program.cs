using System;

namespace _02MixedDataStorage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare an array of type object[].
            //Store inside it: an int, a double, a string, and a bool.
            //Loop through the array and print each element with its GetType().

            object[] items = { 146, 4.98, "Test", true };
            foreach (object item in items)
            {
                Console.WriteLine($"Value: {item} - Type: {item.GetType()}");
            }
        }
    }
}
