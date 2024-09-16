namespace repetition;

public class SmallestInt
{
    public void Mymethod()
    {
        int smallest = 0;
        int[] numbers = { 3, 14, 59 };
        Console.Write("Enter a number: ");

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < smallest)
            {
                smallest = numbers[i];
            }
        }

        Console.WriteLine($"the smallest number is{smallest}");
    }
}