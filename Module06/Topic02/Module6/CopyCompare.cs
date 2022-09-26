using System;

namespace Module6
{
    public class CopyCompare
    {
        /* Write two methods to handle arrays. Name your solution and namespace Module6, name your class CopyCompare. 
         * Don't forget to make it public for Unit Testing. Your file can be CopyCompare.cs or Program.cs. 
            One useful property that arrays have is Length. For an array named strArray, you can find its length with strArray.Length. Use this property in your methods. */

        //Write a method CopyArray()
        // Accepts an array of integer, pass by value
        public static int[] CopyArray(int[] inputArr)
        {
            int[] targetArr = new int[inputArr.Length];
            // Uses for loop to copy one array into a second array
            for (int i = 0; i < inputArr.Length; i++)
            {
                targetArr[i] = inputArr[i];
            }

            // Returns an array, a copy of the array passed in
            return targetArr;
        }

        // Write a method returns true or false called CompareArrays()
        // Accepts two arrays of type string, pass by value
        public static bool CompareArrays(string[] arr1, string[] arr2)
        {
            //    Checks for length equivalence (Use .Length property!), 
            if (arr1.Length != arr2.Length)
            {
                return false;
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                if (!arr1[i].Equals(arr2[i]))
                {
                    return false;
                }
            }
            return true;

        }

        public static bool CompareArrays(int[] arr1, int[] arr2)
        {
            //    Checks for length equivalence (Use .Length property!), 
            if (arr1.Length != arr2.Length)
            {
                return false;
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                if (!arr1[i].Equals(arr2[i]))
                {
                    return false;
                }
            }
            return true;

        }


        static void Main(string[] args)
        {
            // Main() will call both methods
            // Declare two integer arrays inventory and inventoryCheck  <-- INTEGER
            // Initialize inventory to size 5 with random integers of your choice.
            int[] inventory = { 7, 3, 2, 9, 5 };
            // Set inventoryCheck to size 5 with different random integers of your choice
            int[] inventoryCheck = { 2, 8, 7, 3, 1 };

            // Call compareArrays() to check if the arrays are equal and print the result (HINT: you might need an if statement)
            bool compareResult = CompareArrays(inventory, inventoryCheck);  // <-- instruction say that the method with will take in two STRING arrays
            Console.WriteLine($"Are the inventory and inventoryCheck arrays equal? {compareResult}");
            Console.WriteLine();

            // Declare a third integer array, called copyOfInventoryCheck and copy the contents of inventoryCheck using copyArray()
            int[] copyOfInventoryCheck = CopyArray(inventoryCheck);
            // Print all three arrays using foreach loop(s), be sure the use knows which array is being printed
            if (inventory.Length == inventoryCheck.Length && inventory.Length == copyOfInventoryCheck.Length)
            {
                foreach (var item in inventory)
                {
                    Console.WriteLine($"inventory: {item}");
                }
                foreach (var item in inventoryCheck)
                {
                    Console.WriteLine($"inventoryCheck: {item}");
                }
                foreach (var item in copyOfInventoryCheck)
                {
                    Console.WriteLine($"copyOfInventoryCheck: {item}");
                }
            }
            else
            {
                Console.WriteLine("Array Length are not equal.");
            }

            Console.WriteLine();
            bool compareResult2 = CompareArrays(inventoryCheck, copyOfInventoryCheck);  // <-- instruction say that the method with will take in two STRING arrays
            Console.WriteLine($"Are the inventoryCheck and copyOfInventoryCheck arrays equal? {compareResult2}");
            Console.WriteLine();

            //Unit Test
            //    Test with attached Unit Tests 

            Console.WriteLine();
        }
    }
}
