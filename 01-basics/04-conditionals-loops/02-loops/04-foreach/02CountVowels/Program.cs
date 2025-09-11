using System;

namespace _02CountVowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Use foreach on a string and count how many vowels (a, e, i, o, u) it has.

            string name = "Osamu Dazai";
            int count = 0;
            foreach(char n in name.Trim().ToLower())
            {
                if (n == 'a' ||  n == 'e' || n == 'i' || n == 'o' || n == 'u')
                {
                    Console.WriteLine(n);
                    count++;
                }
            }
            Console.WriteLine($"You have {count} vowels in your name {name}");
        }
    }
}
