using System;

class MultiplyByTen
{
    public static void Main()
    {
        int number;

        do
        {
            Console.Write("Enter a number (enter 0 to exit): ");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                
                if (number != 0)
                {
                    Console.WriteLine(10 * number);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                number = -1; // Continue the loop on invalid input
            }
        } while (number != 0);
    }
}