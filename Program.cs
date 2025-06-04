using System;

// Guess the Number Game
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 101); // 1 to 100
        int userGuess = 0;
        int attempts = 0;

        Console.WriteLine("Welcome to Guess the Number!");
        Console.WriteLine("I'm thinking of a number between 1 and 100.");

        while (userGuess != numberToGuess)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out userGuess))
            {
                Console.WriteLine("Please enter a valid number.");
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
                Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
            }
        }
    }
}
