using System;

namespace practice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            string path = @"C:\Projects\GameData
";                                                  //literally new line in \n stead
            string message = @"Hello dear!
Welcome to the game!";

            Console.Error.WriteLine(path);
            Console.WriteLine(message);

            string quote = @"
He said, ""Welcome!""
";

            Console.Error.WriteLine(quote);

            string fileContent = @"PlayerName: John
Score: 2000
Level: 5";

            Console.Error.WriteLine(fileContent);
            Console.ResetColor();

            //Rewrite your previous escape sequence code using verbatim strings, so all those \\ disappear.

            Console.ForegroundColor = ConsoleColor.DarkRed;
            string erase = @"
E " + "\br " + "\ba " + "\bs " + "\be\n";
            Console.WriteLine(erase);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Path: C:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"\Projects\GameData
");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Message:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(@" ""Welcome dear!""
");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(@"

Exiting...");
            Console.ResetColor();

        }
    }
}