void PrintAverage(int a, int b, int c)
{
    float average = (a + b + c) / 3.0f;
    Console.WriteLine($"Average of {a}, {b} and {c} is: {average}");
}

// Call function PrintAverage
PrintAverage(2, -4, 8); // Average of 2, -4 and 8 is: 2

// Function which returns a boolean value and takes two parameters.
bool IsAboveAverage(int valueToCheck, int[] numbers)
{
    float average = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        average += numbers[i] / (float)numbers.Length;
    }
	
    return valueToCheck > average;
}

int myFavoriteNumber = 9;

// The return value of the function is used as the condition.
if (IsAboveAverage(myFavoriteNumber, new int[] {2, 8, -1, 19, 3}))
{
    Console.WriteLine($"Yeah, {myFavoriteNumber} is above average!");
}