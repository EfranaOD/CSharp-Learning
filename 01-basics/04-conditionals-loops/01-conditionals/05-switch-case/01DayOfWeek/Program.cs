using System;

namespace _01DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable: day = 5.
            //Use switch to print the corresponding weekday (1 = Monday, 2 = Tuesday, …, 7 = Sunday).
            //If not 1–7 → print "Invalid day".

            Console.Write("Enter a week number(1-7): ");
            bool success = int.TryParse(Console.ReadLine(), out int day);

            if (!success)
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            switch (day)
            {
                case 1:
                    Console.WriteLine("It's Monday!");
                    break;

                case 2:
                    Console.WriteLine("It's Tuesday!");
                    break;

                case 3:
                    Console.WriteLine("It's Wednesday!");
                    break;

                case 4:
                    Console.WriteLine("It's Thursday!");
                    break;

                case 5:
                    Console.WriteLine("It's Friday!");
                    break;

                case 6:
                    Console.WriteLine("It's Saturday!");
                    break;

                case 7:
                    Console.WriteLine("It's Sunday!");
                    break;

                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
        }
    }
}
