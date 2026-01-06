using System;

namespace practice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //You get a string of names separated by commas, and you want to format it nicely for display.

            string names = "alice,bob,charlie,david";

            string[] namesArr = names.Split(',');
            
            for (int i = 0; i < namesArr.Length; i++)
            {
                string name = namesArr[i];
                string nameWithUpperFirst = char.ToUpper(name[0]) + name.Substring(1);
                namesArr[i] = nameWithUpperFirst;
                //Console.Write(namesArr[i] + " ");
            }

            string table = string.Join(" | ", namesArr);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(table);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\nExiting...");
            Console.ResetColor();
        }
    }
}