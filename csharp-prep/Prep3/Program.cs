using System;

namespace Prep3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a random number generator
            Random randomGenerator = new Random();

            // Play the game
            do
            {
                // Generate a random magic number between 1 and 100
                int magicNumber = randomGenerator.Next(1, 101);

                // Initialize variables
                int guess;
                int attempts = 0;

                // Ask the user to guess the magic number
                Console.WriteLine("I've picked a number between 1 and 100. Can you guess it?");
                
                // Loop until the user guesses the magic number
                while (true)
                {
                    // Increment the number of attempts
                    attempts++;

                    // Ask for user input
                    Console.Write("Enter your guess: ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    // Check if the guess is correct
                    if (guess == magicNumber)
                    {
                        Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                        break;
                    }
                    else if (guess < magicNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                }

                // Ask the user if they want to play again
                Console.Write("Do you want to play again? (yes/no): ");
            } while (Console.ReadLine().ToLower() == "yes");
        }
    }
}