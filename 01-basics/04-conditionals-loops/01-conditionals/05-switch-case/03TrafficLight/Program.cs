using System;

namespace _03TrafficLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable: signal = "Red" (string).
            //Use switch to print:
            //  "Red" → "Stop"
            //  "Yellow" → "Get Ready"
            //  "Green" → "Go"
            //  Anything else → "Invalid signal"

            Console.WriteLine("What is the signal color?\n(should only be Red, Yellow, Green)");
            string signal = Console.ReadLine().Trim(); 

            switch (signal)
            {
                case "Red":
                    Console.WriteLine("Stop");
                    break;

                case "Yellow":
                    Console.WriteLine("Get Ready");
                    break;

                case "Green":
                    Console.WriteLine("GO");
                    break;

                default:
                    Console.WriteLine("Invalid signal!");
                    break;
            }

        }
    }
}
