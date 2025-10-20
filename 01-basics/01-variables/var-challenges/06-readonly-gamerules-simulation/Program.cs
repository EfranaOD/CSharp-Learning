using System;
using System.Linq;

namespace _06_readonly_rules_simulation
{
    internal class Program
    {
        class GameSettings
        {
            public const string GameVersion = "1.0.0";
            public readonly DateTime StartTime;
            public int Score = 0;
            public bool isPaused = false;

            public GameSettings(DateTime startTime)
            {
                StartTime = startTime;
                Console.WriteLine($"Game Version: {GameVersion}\nStartTime: {StartTime}");
            }

            public void IncreaseScore(int points)
            {
                if (!isPaused)
                {
                    Score += points;
                }
                else
                {
                    Console.WriteLine("Can't increase while paused");
                }
            }
            public void PauseGame()
            {
                isPaused = true;
                Console.WriteLine("Game Paused");
            }
            public void ResumeGame()
            {
                isPaused = false;
                Console.WriteLine("Game Resumed");
            }
            public void GetElapsedTime()
            {
                TimeSpan elapsedTime = DateTime.Now - StartTime;
                Console.WriteLine($"Elapsed Time: {elapsedTime.TotalSeconds} seconds");
            }
        }
        static void Main(string[] args)
        {
            //    Make a class GameSettings with:
            //      const string GameVersion
            //      readonly DateTime StartTime
            //    The constructor sets StartTime.
            //    Simulate a game loop where:
            //      Player score increases.
            //      Player can “pause” and “resume” (time tracking still shows elapsed).
            //    At the end, display all info with string literals and interpolations.

            GameSettings gameSettings = new GameSettings(DateTime.Now);

            Console.WriteLine("Press Spacebar to attack!");
            const int maxAttacks = 10;
            if (!gameSettings.isPaused)
            {
                for (int i = 0; i < maxAttacks; i++)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Spacebar)
                    {
                        gameSettings.IncreaseScore(1);
                        Console.WriteLine($"Hit! Attack score: {gameSettings.Score}");
                    }
                    else
                    {
                        Console.WriteLine($"Missed! Attack score: {gameSettings.Score}");
                    }
                }
            }
            Console.WriteLine($"Your score: {gameSettings.Score}/{maxAttacks}");

            //this is me testing mechanics. not ux friendly... but welp. 
            gameSettings.PauseGame();
            gameSettings.IncreaseScore(10);
            gameSettings.ResumeGame();
            gameSettings.GetElapsedTime();
        }
    }
}

