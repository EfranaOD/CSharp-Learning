using System;

namespace practice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //using \t without formatting techniques for deeper escape sequences learning
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("+--------------------------------+");
            Console.WriteLine("| Item\t| Quantity\t| Name\t |");
            Console.WriteLine("|-------+---------------+--------|");
            Console.WriteLine("| Pixel\t| 2\t\t| Efrana |");
            Console.WriteLine("+--------------------------------+\n");
            Console.ResetColor();
            //--------------------------------------

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("E \br \ba \bs \be\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Path: C:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\Projects\\GameData\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Message:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" \"Welcome dear!\"\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\n\nExiting...");
            Console.ResetColor();
        }
    }
}