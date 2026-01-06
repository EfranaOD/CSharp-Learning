using System;

namespace practice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string paragraph = "In the forest of dreams, the secret lies between the moon and stars.";

            Console.WriteLine("Total characters: " + paragraph.Length);

            Console.WriteLine($"The word 'secret' starts at {paragraph.IndexOf("secret")}");

            Console.WriteLine($"The last space is at {paragraph.LastIndexOf(" ")}");

            int firstThe = paragraph.IndexOf("the ");
            int secondThe = paragraph.IndexOf("the ", firstThe + 1);
            int lies = paragraph.IndexOf(" lies");

            int start = secondThe + "the ".Length;
            
            Console.WriteLine($"The hidden word is: {paragraph.Substring(start, lies - start)}");
        }
    }
}