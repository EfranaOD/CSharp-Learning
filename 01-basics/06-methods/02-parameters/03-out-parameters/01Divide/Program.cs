using System;

namespace _01Divide
{
    internal class Program
    {
        public static void Divide(int dividend, int divisor, out double quotient, out double remainder)
        {
            double dividendD = dividend;
            double divisorD = divisor;
            quotient = dividendD / divisorD;    
            remainder = dividendD % divisorD;
        }
        static void Main(string[] args)
        {
            //Takes two integers (dividend, divisor). Returns the quotient and remainder using out parameters. Call it from Main() and print both values.

            Console.Write("Enter dividend: ");
            bool dividendSucc = int.TryParse(Console.ReadLine(), out int dividend);
            Console.Write("Enter divisor: ");
            bool divisorSucc = int.TryParse(Console.ReadLine(), out int divisor);
            if(!dividendSucc || !divisorSucc) { Console.WriteLine("Invalid input."); return; }

            if(divisor == 0) { Console.WriteLine("Divisor cannot be Zero."); return; }

            Divide(dividend, divisor, out double quotient, out double remainder);

            Console.WriteLine($"Quotient: {quotient}, Remainder: {remainder}");
        }
    }
}