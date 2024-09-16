// Declare an integer array named numbers with 5 elements. Assign the values 10, 20, 30, 40, 50 to the array.
// Declare an string array named names with 3 elements.
// Print all values of the numbers array.
// Ask user for three names and store them in the array.
// Ask user for his age and change the 3rd value of the numbers array with the input.
// Print all names
using System;

namespace LearningC
{

    /// The Program class serves as the entry point for the application and contains methods to process and display arrays.
    class Program
    {
        /// Represents an integer used within the Program class.
        /// This variable is initialized to 9 and can be used for various
        /// integer operations or as part of the logic within the class.
        private int i = 9;
        
        /// A variable that provides an instance of the Random class.
        private Random random = new Random();

        /// This is the entry point for the application.
        /// <param name="args">Command-line arguments.</param>
        static void Main(string[] args)
        {
            var p = new Program();
            p.names();
        }

        /// <summary>
        /// Prompts the user to enter three names, replaces the existing names in the array with the input names,
        /// and then outputs both the original integer array and the newly input names.
        /// </summary>
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