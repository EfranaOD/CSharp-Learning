using System;

namespace _01NullableCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare int? x = null
            //Check if it has a value using .HasValue and print a message.
            //Assign a value and print it again.

            int? nullableNumber = null;

            if(nullableNumber.HasValue)
            {
                Console.WriteLine("Value: " + nullableNumber.Value);
            }
            else
            {
                Console.WriteLine("Value is not available.");
            }
            nullableNumber = 55;
            Console.WriteLine("Updated Value: " + nullableNumber);
        }
    }
}
