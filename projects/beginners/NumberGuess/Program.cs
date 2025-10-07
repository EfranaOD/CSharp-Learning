using System;
using GameUtilitiesLibrary;

namespace NumberGuess
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //step 1
            NumberGuessGame game = new NumberGuessGame();

            //step 2
            game.GenerateNumber(1, 11);

            char userResetChoice;
            do
            {
                //step 3
                bool isSuccess = false;
                int userGuess;
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Enter a number to guess: ");
                    isSuccess = int.TryParse(Console.ReadLine(), out userGuess);
                    if (!isSuccess) { Console.WriteLine("Invalid input!\nTry again\n"); }

                    //step 4
                    if (game.CheckGuess(userGuess))
                    {
                        Console.WriteLine($"Correct!\n\n");
                        break;
                    }
                    else if (isSuccess)
                    {
                        Console.WriteLine(game.GetHint(userGuess) + "\n");
                    }
                }
                Console.WriteLine($"The target number was, {game.GetTargetNumber()}!\n");

                Console.WriteLine("Do you want to reset/play again?(y/n)");
                bool isSuccessTwo = char.TryParse(Console.ReadLine().Trim().ToLower(), out userResetChoice);
                if (!isSuccessTwo) { Console.WriteLine("Invalid input. Taking 'n'as default"); userResetChoice = 'n'; }
                if(userResetChoice == 'y')
                {
                    Console.WriteLine("Game will be reset!");
                    Console.Clear();
                    game.ResetGame(1, 11);
                }
                else if(userResetChoice == 'n')
                {
                    Console.WriteLine("\nOkay.\nWell played!\n");
                }
                else
                {
                    Console.WriteLine("Invalid input. Taking 'n' as default"); 
                    userResetChoice = 'n';
                }
            } while (userResetChoice == 'y');

            Console.WriteLine("\n\nExiting...");
        }
    }
}