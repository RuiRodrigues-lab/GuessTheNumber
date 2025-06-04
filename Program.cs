using System;

// Guess the Number Game
class Program
{
    const int MinNumber = 1;
    const int MaxNumber = 100;

    static void Main(string[] args)
    {
        do
        {
            PlayGame();
        } while (AskToPlayAgain());
    }

    static void PlayGame()
    {
        Random random = new Random();
        int numberToGuess = random.Next(MinNumber, MaxNumber + 1);
        int attempts = 0;
        int userGuess = 0;

        Console.WriteLine($"Welcome to Guess the Number!\nI'm thinking of a number between {MinNumber} and {MaxNumber}.");

        while (true)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out userGuess) || userGuess < MinNumber || userGuess > MaxNumber)
            {
                Console.WriteLine($"Please enter a valid number between {MinNumber} and {MaxNumber}.");
                continue;
            }
            attempts++;
            if (userGuess < numberToGuess)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (userGuess > numberToGuess)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.\n");
                break;
            }
        }
    }

    static bool AskToPlayAgain()
    {
        Console.Write("Would you like to play again? (y/n): ");
        string response = Console.ReadLine();
        return response.Trim().ToLower() == "y";
    }
}
