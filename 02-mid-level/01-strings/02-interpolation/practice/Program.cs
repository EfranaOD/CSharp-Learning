using System;

namespace practice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Practice embedding variables and expressions directly inside strings.
            string name = "Osamu";
            int level = 5;
            double score = 1200.0, reqFirstLvlScore = 1500.0, health = 85.0;
            Console.WriteLine($"Player {name} is at level {level} with {score} points and {health}% health.");

            Console.WriteLine($"Next level in {reqFirstLvlScore - score} points.");

            //Build a simple console table using interpolation and alignment.
            object[] itemsOne = { "Pixel", 2, 25.0d };
            object[] itemsTwo = { "Potion", 10, 5.50d };

            Console.WriteLine($"+{new string('-', 31)}+");
            Console.WriteLine("| {0, -10} | {1, -5} | {2, 8} |", "Item", "Qty", "Price");
            Console.WriteLine($"+{new string('-', 12)}+{new string('-', 7)}+{new string('-', 10)}+");
            Console.WriteLine("| {0,-10} | {1, 5} | {2, 8:C} |", itemsOne[0], itemsOne[1], itemsOne[2]);
            Console.WriteLine("| {0,-10} | {1, 5} | {2, 8:C} |", itemsTwo[0], itemsTwo[1], itemsTwo[2]);
            Console.WriteLine($"+{new string('-', 31)}+");

            //Practice a mini scoreboard.
            string[] names = { "Osamu", "Akutagawa", "Fyodor" };
            int[] scores = { 1200, 800, 1000 };

            Console.WriteLine($"+{new string('-', 20)}+");
            Console.WriteLine("| {0, -10} | {1, -5} |", "Name", "Score");
            Console.WriteLine($"+{new string('-', 12)}+{new string('-', 7)}+");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("| {0,-10} | {1, 5} |", names[0], scores[0]);
            Console.ResetColor();
            Console.WriteLine("| {0,-10} | {1, 5} |", names[1], scores[1]);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("| {0,-10} | {1, 5} |", names[2], scores[2]);
            Console.ResetColor();

            Console.WriteLine($"+{new string('-', 20)}+");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\n\nExiting...");
            Console.ResetColor();
        }
    }
}