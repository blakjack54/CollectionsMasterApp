using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            // Create an integer Array of size 50
            int[] numbers = new int[50];

            // Populate the number array with 50 random numbers between 0 and 51 (inclusive)
            Populater(numbers, 0, 51); // Improved Populater with range

            // Print the first number of the array
            Console.WriteLine("First Number: {0}", numbers[0]);

            // Print the last number of the array (accessing the last element)
            Console.WriteLine("Last Number: {0}", numbers[numbers.Length - 1]);

            Console.WriteLine("All Numbers Original");
            // Print out your numbers from the array
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            // Reverse the contents of the array (Method 1: Using Array.Reverse())
            Array.Reverse(numbers);

            Console.WriteLine("All Numbers Reversed (Method 1):");
            NumberPrinter(numbers);
            Console.WriteLine("---------REVERSE CUSTOM------------");

            // Reverse the contents of the array (Method 2: Custom method)
            ReverseArray(numbers); // Call the custom method (assuming it exists)

            Console.WriteLine("All Numbers Reversed (Method 2):");
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            // Set numbers that are a multiple of 3 to zero
            ThreeKiller(numbers);

            Console.WriteLine("Multiple of three = 0: ");
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            // Sort the array in order
            Array.Sort(numbers);

            Console.WriteLine("Sorted numbers:");
            NumberPrinter(numbers);
            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            // Create an integer List
            List<int> numberList = new List<int>();

            // Print the capacity of the list to the console
            Console.WriteLine("Initial List Capacity: {0}", numberList.Capacity);

            // Populate the List with 50 random numbers between 0 and 51 (inclusive)
            Populater(numberList, 0, 51); // Improved Populater with range

            // Print the new capacity (capacity might change dynamically)
            Console.WriteLine("New List Capacity: {0}", numberList.Capacity);
            Console.WriteLine("---------------------");

            // Search for a number in the list (with error handling)
            Console.WriteLine("What number will you search for in the number list?");
            int searchNumber = GetValidIntInput(); // Function to handle invalid input (assuming it exists)

            NumberChecker(numberList, searchNumber);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            NumberPrinter(numberList);
            Console.WriteLine("-------------------");

            // Remove all odd numbers from the list
            OddKiller(numberList);

            Console.WriteLine("Evens Only!!");
            NumberPrinter(numberList);
            Console.WriteLine("------------------");

            // Sort the list
            numberList.Sort();

            Console.WriteLine("Sorted Evens!!");
            NumberPrinter(numberList);
            Console.WriteLine("------------------");

            // Convert the list to an array
            int[] numberArray = numberList.ToArray();

            // Clear the list
            numberList.Clear();

            #endregion
        }

        // Helper methods for various functionalities (assuming they exist)
        private static void Populater(int[] numbers, int min, int max)
        {
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(min, max); // Generate random number within range
            }
        }

        private static void Populater(List<int> numberList, int min, int max)
        {
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(random.Next(min, max)); // Add random number within range
            }
        }

