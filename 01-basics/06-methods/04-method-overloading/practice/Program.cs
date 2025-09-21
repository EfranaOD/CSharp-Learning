using System;

namespace practice
{
    internal class Program
    {
        class AreaCalculator
        {
            public double CalculateArea(int side) 
            {
                return (double)side * side;
            }

            public double CalculateArea(int length, int width)
            {
                return length * width;
            }

            public double CalculateArea(double radius)
            {
                return Math.PI * Math.Pow(radius, 2);
            }
        }
        static int GetInput(string prompt, int defaultValue)
        {
            int value = 0, attempts = 0;
            bool success = false;

            while (attempts < 3)
            {
                Console.Write(prompt);
                success = int.TryParse(Console.ReadLine(), out value);
                Console.WriteLine();

                if (success)
                    return value;

                attempts++;
                Console.WriteLine($"Invalid input. Attempts left: {3 - attempts}");
            }
            Console.WriteLine($"Invalid input entered 3 times. Using default value: {defaultValue}");
            return defaultValue;
        }
        static void Main(string[] args)
        {
            //Create a class AreaCalculator.
            //Overload a method CalculateArea:
            //  CalculateArea(int side) → area of square.
            //  CalculateArea(int length, int width) → area of rectangle.
            //  CalculateArea(double radius) → area of circle.
            //Call all overloads in Main() and print results.

            AreaCalculator areaCalculator = new AreaCalculator();

            int sideSquare = GetInput("Enter the side of a square: ", 5);
            int lengthRect = GetInput("Enter the length of a rectangle: ", 10);
            int widthRect = GetInput("Enter the width of a rectangle: ", 7);
            double radiusCirc = GetInput("Enter the radius of a circle: ", 12);

            Console.WriteLine($"Area of the square: {areaCalculator.CalculateArea(sideSquare)}\n");
                        
            Console.WriteLine($"Area of the rectangle: {areaCalculator.CalculateArea(lengthRect, widthRect)}\n");
                        
            Console.WriteLine($"Area of circle: {areaCalculator.CalculateArea(radiusCirc)}\n");
        }
    }
}
