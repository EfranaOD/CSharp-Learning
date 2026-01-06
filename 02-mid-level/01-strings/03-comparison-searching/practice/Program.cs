using System;

namespace practice
{
    internal class Program
    {
        public static void LoginSuccess()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Login successful!");
            Console.ResetColor();
        }
        public static void LoginFail()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Invalid user name.");
            Console.ResetColor();
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("=== STRING OPERATIONS DEMO ===\n");

            //Practice Equals(), Compare(), case-insensitive comparison, and trimming.

            Console.WriteLine("\n[1] LOGIN VALIDATION");

            string userName = "AdminUser";

            Console.Write("\nEnter your user name: ");
            string userInput = Console.ReadLine().Trim();

            if (userName.Equals(userInput))
            {
                LoginSuccess();
            }
            else
            {
                LoginFail();
            }

            if (userName.Equals(userInput, StringComparison.OrdinalIgnoreCase))
            {
                LoginSuccess();
            }
            else
            {
                LoginFail();
            }

            if (string.Compare(userName, userInput, true) == 0)
            {
                LoginSuccess();
            }
            else
            {
                LoginFail();
            }

            //Practice Contains(), StartsWith(), EndsWith(), and Replace().

            Console.WriteLine("\n[2] SENTENCE ANALYZER");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            string sentence = "C# is a powerful language. Learning C# is fun!";

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            if (sentence.Contains("C#")) { Console.WriteLine("\n'C#' does contain in the given sentense"); } else { Console.WriteLine("'C#' doesn't contain in the given sentence"); }

            if (sentence.StartsWith("C#")) { Console.WriteLine("Given sentence does start with 'C#'"); } else { Console.WriteLine("Given sentence doesn't start with 'C#'"); }

            if (sentence.EndsWith("fun!")) { Console.WriteLine("Given sentence does end with 'fun!'"); } else { Console.WriteLine("Given sentence doesn't end with 'fun!'"); }

            string updatedSentence = sentence.Replace("C#", "DotNet");

            Console.WriteLine("Updated sentence: " + updatedSentence);
            Console.ResetColor();

            //Combine trimming, equality, and comparison.

            Console.WriteLine("\n[3] STRING CLEAN & COMPARE\n");

            string str1 = "  hello world ";
            string str2 = "HELLO WORLD";

            str1 = str1.Trim();
            str2 = str2.Trim();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Equals case-sensitive: {str1.Equals(str2)}");
            Console.WriteLine($"Equals ignoring case: {str1.Equals(str2, StringComparison.OrdinalIgnoreCase)}");
            Console.WriteLine($"Compare result(0(equal)/ >0(false) / <0(true)): {string.Compare(str1, str2)}");
            Console.WriteLine($"CompareOrdinal result(0(equal)/ >0(false) / <0(true)): {string.CompareOrdinal(str1, str2)}");
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\nExiting...");
            Console.ResetColor();
        }
    }
}