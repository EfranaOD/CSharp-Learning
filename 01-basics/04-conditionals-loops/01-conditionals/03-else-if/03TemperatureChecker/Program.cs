using System;

namespace _03TemperatureChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program with a variable temp (Celsius).
            //temp < 10 → "Cold"
            //10–25 → "Warm"
            //26–35 → "Hot"
            //Above 35 → "Very Hot"

            Console.WriteLine("What is the temperature(-10 - 50) there?");
            bool success = int.TryParse(Console.ReadLine(), out int temperature);
            if ( !success || temperature < -10 || temperature > 50)
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            if ( temperature < 0 )
            {
                Console.WriteLine("VERY Cold!");
            }
            else if ( temperature < 10 )
            {
                Console.WriteLine("Cold!");
            }
            else if ( temperature >= 10 && temperature <= 25 )
            {
                Console.WriteLine("Warm!");
            }
            else if ( temperature >= 26 && temperature <= 35 )
            {
                Console.WriteLine("Hot!");
            }
            else if ( temperature > 35)
            {
                Console.WriteLine("VERY Hot!");
            }
        }
    }
}
