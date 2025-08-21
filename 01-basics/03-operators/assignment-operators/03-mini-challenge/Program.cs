
using System;

namespace _03_mini_challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start with a score = 50.
            //Add 20 points for completing Level 1.
            //Subtract 15 points for taking damage.
            //Double the score because of a power-up.
            //Divide the score by 5 as a penalty.
            //Finally, print the remainder when divided by 3 (using %=).

            Console.WriteLine("Enter your name before starting the game, player.");
            string playerName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(playerName))
            {
                Console.WriteLine("Bruh.. Invalid Name.");
                return;
            }

            int score = 50;

            Console.WriteLine($"\nWelcome {playerName}! Your current score: {score}");

            score += 20;
            Console.WriteLine($"\nHurray! You have successfully finished Level 1.\nYour updated score is: {score}");

            score -= 15;
            Console.WriteLine($"\nOops! You took some damage there.\nYour updated score with deducted points: {score}");

            score *= 2;
            Console.WriteLine($"\nWOAH! You just hit the jackpot!\n{playerName}, you have obtained the legendary POWER-UP!\nYour score is updated again according to the Power-Up: {score}");

            score /= 5;
            Console.WriteLine($"\nUh oh- You just accidentally hit an INNOCENT PASSERBY!\n{playerName.ToUpper()}! PENALTY!\nYour updated score: {score}");

            score %= 3;
            Console.WriteLine($"\nUh.. so.. {playerName}, finally, Your score: {score}\nWell Played. GG!\nSee you again");
        }
    }
}
