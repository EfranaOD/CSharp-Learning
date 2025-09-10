using System;

namespace _02GradingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that takes marks (0–100) and prints:
            //90+ → "Grade A"
            //75–89 → "Grade B"
            //50–74 → "Grade C"
            //Below 50 → "Fail"

            Console.Write("Enter your marks(1-100): ");
            bool success = int.TryParse(Console.ReadLine(), out int studentMarksInput);
            if ( !success || (studentMarksInput < 0 || studentMarksInput > 100) )
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            if( studentMarksInput >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if( studentMarksInput >= 75)
            {
                Console.WriteLine("Grade B");
            }
            else if( studentMarksInput >= 50)
            {
                Console.WriteLine("Grade C");
            }
            else if( studentMarksInput < 50)
            {
                Console.WriteLine("Fail");
            }
            else
            {
                Console.WriteLine("hmm...");
            }
        }
    }
}
