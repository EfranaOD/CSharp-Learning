using System;

namespace constant_conversion_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Define const double InchesToCm = 2.54;
            //Using a loop, print a table converting inches(1 to 12) into cm.
            //Table format should be clean and use string literals for borders, but numeric values must be interpolated.

            const double InchesToCm = 2.54;
            Console.WriteLine("+----------+---------------+");
            Console.WriteLine("|  Inches  |  Centimeters  |");
            Console.WriteLine("+----------+---------------+");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"|  {i,-8}|  {i * InchesToCm,-13:F2}|");
            }
            Console.WriteLine("+----------+---------------+");
        }
    }
}
