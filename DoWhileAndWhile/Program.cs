using System;

class GuessingGameWhile
{
    public GuessingGameWhile()
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
                    Console.WriteLine("Your guess is too low. Try again.");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Your guess is too high. Try again.");
                }
                else
                {
                    Console.WriteLine("You guessed the correct number!");
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
        new GuessingGameWhile();
    }
}

using System;

class GuessingGameDoWhile
{
    public GuessingGameDoWhile()
    {
        Random rnd = new Random();
        int numberToGuess = rnd.Next(0, 100);
        
        Console.WriteLine("Welcome to my guessing game");
        
        int userGuess;
        
        do
        {
            Console.Write("Enter your guess: ");
            try
            {
                userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Your guess is too low. Try again.");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Your guess is too high. Try again.");
                }
                else
                {
                    Console.WriteLine("You guessed the correct number!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
                userGuess = -1; // Force loop to continue
            }
        } 
        while (userGuess != numberToGuess);
    }

    public static void Main()
    {
        new GuessingGameDoWhile();
    }
}