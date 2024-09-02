// Declare an integer array named numbers with 5 elements. Assign the values 10, 20, 30, 40, 50 to the array.
// Declare an string array named names with 3 elements.
// Print all values of the numbers array.
// Ask user for three names and store them in the array.
// Ask user for his age and change the 3rd value of the numbers array with the input.
// Print all names
using System;

namespace LearningC
{
    class Program
    {
        private int i = 9;
        private Random random = new Random();

        static void Main(string[] args)
        {
            var p = new Program();
            p.names();
        }

        public void names()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            string[] names = { "samuel", "david", "peter" };

            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine("Please enter three names:");

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Name {i + 1}: ");
                names[i] = Console.ReadLine();
            }
            {
                Console.WriteLine(string.Join(", ", numbers));
                Console.ReadLine();
                
            
            }
            
            Console.WriteLine(string.Join(", ", names));
        }
    }
}