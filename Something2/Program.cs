using System;

class Program
{
    static void Main()
    {
        string wordToGuess = "csharp";
        wordToGuess = wordToGuess.ToLower();
        
        int attemptCounter = 0;
        string userGuess;
        bool isCorrect = false;

        Console.WriteLine("Welcome to the Word Guessing Game!");
        Console.WriteLine("Try to guess the word.");

        do
        {
            attemptCounter++;
            Console.Write("Enter your guess: ");
            userGuess = Console.ReadLine().ToLower();

            if (userGuess == wordToGuess)
            {
                isCorrect = true;
                Console.WriteLine($"Congratulations! You've guessed the word correctly in {attemptCounter} attempts.");
            }
            else
            {
                Console.WriteLine("Incorrect guess. Try again.");
            }
        } while (!isCorrect);
    }
}