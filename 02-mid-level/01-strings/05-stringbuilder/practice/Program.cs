using System;
using System.Text;

namespace practice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //You want to construct a sentence word by word efficiently.
            StringBuilder sb = new StringBuilder();

            string[] words = { "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog." };

            foreach (string word in words)
            {
                sb.Append(word + " ");
            }

            sb.Insert(9, ", aggressive");
            sb.Remove(9, 12);
            sb.Replace("lazy", "sleepy");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(sb.ToString());
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\nExiting...");
            Console.ResetColor();
        }
    }
}