using System;

namespace _03Toggle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First, print the current state ("Light is Off").
            //Then toggle it (if off → on, if on → off) and print the new state.
            //Do this toggle twice using the NOT (!) operator.

            bool lightOn = false;
            string toggle = lightOn ? "On" : "Off";
            Console.WriteLine($"Light is {toggle}!");

            for(int i = 0; i < 3; i++)
            {
                lightOn = !lightOn;
                toggle = lightOn ? "On" : "Off";
                if (lightOn)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Light is {toggle}!");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"Light is {toggle}!");
                }
            }
            Console.WriteLine("\nExiting...");

        }
    }
}
