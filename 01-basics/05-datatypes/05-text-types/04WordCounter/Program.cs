using System;

namespace _04WordCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that counts how many words are in a sentence.

            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Total number of words in your sentence are: " + words.Length);
        }
    }
}
