using System;

namespace _02CalculateDistance
{
    internal class Program
    {
        public static void CalculateDistance(in int x1, in int y1, in int x2, in int y2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            //x1 = x2 - distance; Cannot assign to variable 'coordinateOne' or use it as right hand side of a ref parameter because it is a readonly variable
            Console.WriteLine($"\nThe Euclidean distance between ({x1}, {y1}) and ({x2}, {y2}) is {distance}");
        }
        static void Main(string[] args)
        {
            //Write a method CalculateDistance that takes two points (x1, y1) and (x2, y2) as in parameters.
            //It should calculate the Euclidean distance between them using the formula:
            //distance=squareroot of((x2−x1)power2+(y2−y1)power2)
            //Print the result inside the method.
            //From Main(), pass two pairs of coordinates (like in int x1, in int y1 etc.).
            //Show that the original variables are untouched, and also demonstrate that trying to change them inside the method results in a compile-time error.

            Console.Write("Enter x1 coordinates: ");
            bool x1Succ = int.TryParse(Console.ReadLine(), out int x1);
            Console.Write("Enter y1 coordinates: ");
            bool y1Succ = int.TryParse(Console.ReadLine(), out int y1);
            Console.Write("Enter x2 coordinates: ");
            bool x2Succ = int.TryParse(Console.ReadLine(), out int x2);
            Console.Write("Enter y2 coordinates: ");
            bool y2Succ = int.TryParse(Console.ReadLine(), out int y2);

            if (!x1Succ || !x2Succ || !y1Succ || !y2Succ) { Console.WriteLine("Invalid input"); return; }

            CalculateDistance(x1, y1, x2, y2);

            Console.WriteLine($"\nThe values after the method was called: ({x1}, {y1}), ({x2}, {y2}). They remain untouched.");
        }
    }
}