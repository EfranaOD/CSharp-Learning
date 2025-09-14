using System;

namespace _05VowelReplacer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that takes a string and replaces all vowels (a, e, i, o, u) with *.

            Console.Write("Enter a word: ");
            string userInputWord = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("You have entered " + userInputWord);
            char[] letters = userInputWord.ToCharArray();

            for (int i = 0; i < userInputWord.Length; i++)
            {
                if(userInputWord[i] == 'a' || userInputWord[i] == 'e' || userInputWord[i] == 'i' || userInputWord[i] == 'o' || userInputWord[i] == 'u')
                {
                    letters[i] = '*';
                }
                else
                {
                    letters[i] = userInputWord[i];
                }
            }

            string result = new string(letters);

            Console.WriteLine("Modified word: " + result);
        }
    }
}
