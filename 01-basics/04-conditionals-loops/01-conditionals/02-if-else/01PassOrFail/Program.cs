using System;

namespace _01PassOrFail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program where marks is an integer.
            //If marks >= 40 → print "Pass".
            //Else → print "Fail".

            Console.Write("Enter your marks: ");
            bool success = int.TryParse(Console.ReadLine(), out int studentMarks);
            if ( success && studentMarks >= 40)
            {
                Console.WriteLine($"You got {studentMarks}, You pass!");
            }
            else
            {
                Console.WriteLine($"You got {studentMarks}, You fail!");
            }
        }
    }
}
