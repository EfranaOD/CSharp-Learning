using System;

namespace _02CalculateAverage
{
    internal class Program
    {
        public static double CalculateAverage(int english, int maths, int science)
        {
            double average = (english + maths + science) / 3.0;
            return average;
        }
        static void Main(string[] args)
        {
            //Create a method that takes three integers (marks in 3 subjects), calculates the average, and returns it as a double.
            //In Main, call the method with sample values, store the result, and print:
            //the average and whether the student is Pass(average ≥ 40) or Fail.

            Console.WriteLine("Enter marks in three subjects.");
            Console.Write("English: ");
            bool englishMarksSucc = int.TryParse(Console.ReadLine(), out int englishMarks);
            if (!englishMarksSucc) { Console.WriteLine("Invalid input"); return; }

            Console.Write("Maths: ");
            bool mathsMarksSucc = int.TryParse(Console.ReadLine(), out int mathsMarks);
            if (!mathsMarksSucc) { Console.WriteLine("Invalid input"); return; }

            Console.Write("Science: ");
            bool scienceMarksSucc = int.TryParse(Console.ReadLine(), out int scienceMarks);
            if (!scienceMarksSucc) { Console.WriteLine("Invalid input"); return; }

            double average = CalculateAverage(englishMarks, mathsMarks, scienceMarks);
            string result = average >= 40 ? "Student pass" : "Student fail";
            Console.WriteLine($"Average marks: {average:F2} -> {result}");
        }
    }
}
