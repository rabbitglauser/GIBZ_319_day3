

using System.Security.AccessControl;

Random random = new Random();
int randomNumber = random.Next(1, 10); 
Console.WriteLine("welcome to my guessing game,guess a number between 1 and 100 ");
int UserInput = Convert.ToInt32(Console.ReadLine());
int attemptCounter = 0;

while (UserInput != randomNumber)
{
    attemptCounter++;
    if (UserInput > randomNumber)
    {
        Console.WriteLine("the number is too low");
    }

    else if (UserInput < randomNumber)
    {
        Console.WriteLine("the number is too high");
    }
    
    else
    {
        Console.WriteLine("congratulation you gopt the number between 1 and 100");
    }
}