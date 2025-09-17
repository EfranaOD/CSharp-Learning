using System;

namespace _01ShowCoordinates
{
    internal class Program
    {
        public static void ShowCoordinates(in int coordinateOne, in int coordinateTwo)
        {
            //coordinateOne = coordinateOne / 2; Cannot assign to variable 'coordinateOne' or use it as right hand side of a ref parameter because it is a readonly variable
            Console.WriteLine($"Coordinates inside the method, coordinate one : {coordinateOne}, coordinate two : {coordinateTwo}");
        }
        static void Main(string[] args)
        {
            //Accepts two integers (x and y) as in parameters.
            //Prints them inside the method.
            //Verify that trying to modify them inside the method causes a compile error.

            int coordinateOne = 5, coordinateTwo = 10;

            ShowCoordinates(coordinateOne, coordinateTwo);
        }
    }
}