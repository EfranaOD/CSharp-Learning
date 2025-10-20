using System;

namespace practice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //PRACTICE-------------------------------------------------------
            //using +
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string firstName = "Osamu";
            string lastName = "Dazai";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
            Console.ResetColor();

            //using string.Concat()
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine("\n" + fullName);
            Console.ResetColor();

            //using string.Join()
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string[] items = { "Apple", "Banana", "Cherry" };
            string joined = string.Join(", ", items);
            Console.WriteLine("\n" + joined + "\n"); // Apple, Banana, Cherry
            Console.ResetColor();
            //---------------------------------------------------------------

            //Create a console output that prints something like this:
            //  Inventory: Apple, Banana, Cherry
            //  Path: C:\Game\Data
            //  Player: Efrana OD

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(@"//Mini assignment:");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;

            string inventoryConcat = string.Join(",", items);
            Console.WriteLine("\n" + inventoryConcat);

            string path = "Path:";
            string pathAdd = @"C:\Game\Data";
            string pathConcat = string.Concat(path, " ", pathAdd);
            Console.WriteLine(pathConcat);

            string nameConcat = "Efrana" + " " + "OD";
            Console.WriteLine(nameConcat);

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\n\nExiting...");
            Console.ResetColor();
        }
    }
}