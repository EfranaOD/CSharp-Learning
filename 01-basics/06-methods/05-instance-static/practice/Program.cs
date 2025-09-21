using System;

namespace practice
{
    internal class Program
    {
        class Converter
        {
            public double ToFahrenheit(double celsius)
            {
                return (celsius * 9 / 5) + 32;
            }
            public static double ToCelsius(double fahrenheit)
            {
                return (fahrenheit - 32) * 5 / 9;
            }
        }
        static void Main(string[] args)
        {
            //Create a class Converter.
            //    Instance method: ToFahrenheit(double celsius) → converts Celsius to Fahrenheit.
            //    Static method: ToCelsius(double fahrenheit) → converts Fahrenheit to Celsius.
            //Show calling one via object and one via class name.

            double defaultValCels = 37.00, defaultValFahr = 98.6;

            Console.Write("Enter the value of celsius to convert: ");
            bool celsiusSucc = double.TryParse(Console.ReadLine(), out double celsius);
            if(!celsiusSucc)
            { 
                Console.WriteLine("Invalid input");
                Console.WriteLine($"Taking a default value instead: {defaultValCels}");
                celsius = defaultValCels;
            }

            Converter converter = new Converter();
            Console.WriteLine($"Converting from celsius {celsius} to fahrenheit {converter.ToFahrenheit(celsius):F2}");

            Console.Write("Enter the value of fahrenheit to convert: ");
            bool fahrenheitSucc = double.TryParse(Console.ReadLine(), out double fahrenheit);
            if (!fahrenheitSucc)
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine($"Taking a default value instead: {defaultValFahr}");
                fahrenheit = defaultValFahr;
            }

            Console.WriteLine($"Converting from fahrenheit {fahrenheit} to celsius {Converter.ToCelsius(fahrenheit):F2}");
        }
    }
}