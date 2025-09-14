using System;

namespace _02LocalVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inside Main(), declare a local int x; and try to print it.
            //Observe the compiler error. Then assign a value and print again.

            int x;
            //Console.WriteLine(x); //Use of unassigned local variable "x"
            x = 45;
            Console.WriteLine(x);

            double y;
            //Console.WriteLine(y); //Use of unassigned local variable "y"
            Console.Write("Enter a real number: ");
            bool userInputSuccess = double.TryParse(Console.ReadLine(), out y);
            if (!userInputSuccess) { Console.WriteLine("Invalid input"); return; }

            double sum = x + y;
            Console.WriteLine($"Addition: {sum}");
        }
    }
}
