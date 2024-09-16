using System;

class GuessingGame
{
    public GuessingGame()
    {
        Random rnd = new Random();
        int numberToGuess = rnd.Next(0, 100);
        
        Console.WriteLine("Welcome to my guessing game");
        
        int userGuess = -1;
        
        while (userGuess != numberToGuess)
        {
            Console.Write("Enter your guess: ");
            try
            {
                userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Your guess is lower than the number. Try again.");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Your guess is higher than the number. Try again.");
                }
                else
                {
                    Console.WriteLine("You got the number!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }

    public static void Main()
    {
        new GuessingGame();
    }
}