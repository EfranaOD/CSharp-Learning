namespace GameUtilitiesLibrary
{
    public class NumberGuessGame
    {
        // Field: stores the random number to guess
        private int targetNumber;

        // Field: random number generator
        private Random random;

        // Constructor: sets up the random generator and starts the game
        public NumberGuessGame()
        {
            random = new Random();
        }

        // Method 1: Generate a random number
        public void GenerateNumber(int min, int max)
        {
            targetNumber = random.Next(min, max + 1);
        }

        // Method 2: Get target number 
        public int GetTargetNumber()
        {
            return targetNumber;
        }

        // Method 3: Check if a guess is correct
        public bool CheckGuess(int userGuess)
        {
            return userGuess == targetNumber;
        }

        // Method 4: Give a hint (too high / too low)
        public string GetHint(int userGuess)
        {
            return (userGuess > targetNumber) ? "Too high" : "Too low";
        }

        // Method 5: Reset the game (start fresh)
        public void ResetGame(int min, int max)
        {
            GenerateNumber(min, max);
        }
    }
}
