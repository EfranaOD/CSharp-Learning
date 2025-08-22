using System;

namespace _04_player_energy_tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start with a player energy level of 10.
            //The player drinks a potion → energy increases by 1 (++).
            //The player takes damage → energy decreases by 1 (--).
            //The player finds a cursed item → energy flips sign (-).
            //The player checks a trap → if trap is active (true), flip the boolean with !.

            int playerEnergy = 10;

            Console.Write($"Welcome, player!\nBefore we start the game, enter your name: ");
            string playerName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(playerName))
            {
                Console.WriteLine("Invalid input for name");
                return;
            }

            Console.WriteLine($"\n{playerName}, your current energy: {playerEnergy}");

            Console.WriteLine($"\nAh-ha! You have received 'Energy Potion'.\nCongratulations, {playerName}.\nYour energy has increased: {++playerEnergy}");

            Console.WriteLine($"\n{playerName}, your current energy: {playerEnergy}");

            Console.WriteLine($"\nOuch! You have hit a wall accidentally, {playerName}.\nYour energy has decreased: {--playerEnergy}");

            Console.WriteLine($"\n{playerName}, your current energy: {playerEnergy}");

            Console.WriteLine($"\nHo!? You have stumbled upon a Rare Potion, {playerName}.\nYour energy will be increased later: {playerEnergy++}");

            Console.WriteLine($"\n{playerName}, your current energy: {playerEnergy}");

            playerEnergy = -playerEnergy;
            Console.WriteLine($"\nGASP! Did you just DRINK THAT!?\n{playerName.ToUpper()}! That was a CURSED potion!\nAnyway.. Your energy now got cursed- I mean got negated: {playerEnergy}");

            Console.WriteLine($"\n{playerName}, your current energy: {playerEnergy}");

            bool trapActive = false;

            Console.WriteLine("\nDo you want this 'LEGENDARY POTION' for FREE?");
            string trapAnswer = Console.ReadLine()?.ToLower();

            if(trapAnswer == "yes")
            {
                trapActive = !trapActive;
                Console.WriteLine($"\nYou got THE LEGENDARY POTION- PFTT! Gotcha. The trap has been Activated.");
            }
            else if(trapAnswer == "no")
            {
                Console.WriteLine($"\nYou got a normal 'Meh' drink! The trap has been Deactivated.");
            }
            else
            {
                Console.WriteLine("You said what? Invalid. You lost the Legendary Potion.");
            }

            Console.WriteLine($"\n{playerName}, Finally, your energy by the end of the game: {playerEnergy}");

            if (playerEnergy < 0)
            {
                Console.WriteLine($"\nDon't get disheartened, player {playerName}.. Here is a bonus reward for keeping the spirit of the game: {playerEnergy += 20}");
            }

            Console.WriteLine("\nSee you again!");

        }
    }
}
