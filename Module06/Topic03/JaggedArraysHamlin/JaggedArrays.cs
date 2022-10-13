using System;
using System.Linq;

namespace JaggedArraysHamlin
{
    /***************************************************************
    * Name         : JaggedArraysHamlin
    * Author       : Anthony Hamlin
    * Created      : 09/30/2022
    * Course       : CIS 169 - C#
    * Version      : 1.0
    * OS           : Windows 10
    * IDE          : Visual Studio 2019 Community
    * Copyright    : This is my own original work based on
    *                      specifications issued by our instructor
    * Description  : This program is to find the closest available city with a hotel so that you can maximize your time-off with minimal travel time,
    *                and to find the fartherest available city for a longer stay.
    *                      Input :  Miles/distance array
    *                      Output:  min/max value of the array
    * Academic Honesty: I attest that this is my original work.
    * I have not used unauthorized source code, either modified or
    * unmodified. I have not given other fellow student(s) access
    * to my program.        
    ***************************************************************/
    class JaggedArrays
    {
        // Write a method Min() that finds and returns the minimum value of integer array (do not use Array class methods)
        // Argument list is an array of type integer, pass by value

        public static int Min(int[] distance)
        {
            int minimumDistance = distance[0];
            for (int i = 0; i < distance.Length; i++)
            {
                if (distance[i] < minimumDistance)
                {
                    minimumDistance = distance[i];
                }
            }
            // int minimumDistance = distance.Min();  array method

            return minimumDistance;
        }

        // Write a method Max() that finds and returns the maximum value of integer array (do not use Array class methods)
        // Argument list is an array of type integer, pass by value

        public static int Max(int[] distance)
        {
            int maximumDistance = distance[0];
            for (int i = 0; i < distance.Length; i++)
            {
                if (distance[i] > maximumDistance)
                {
                    maximumDistance = distance[i];
                }
            }
            // int maximumDistance = distance.Max();  array method
            return maximumDistance;
        }

        static void Main(string[] args)
        {
            // Main() To make sense of the table, assign Edinburgh to 0, Birmingham to 1, etc. 
            string[] cityList = { "Edinburgh", "Birmingham", "Cardiff", "Dover", "Leeds", "Liverpool", "London", "Manchester", "NewCastle", "York" };

            /* Declare a jagged array from the mileage table, called mileageTable
                    Why type is your array? INT
                    What is the size of your jagged array? 10 ROWS
                    The first jagged array at index 0 will have the entry 0. It represents distance from Edinburgh to Edingburgh. It's not listed in table
                    The second jagged array at index 1 will have entry of 290, It represents distance from Edinburgh to Birmingham.
                    Create the array for each, with index 2 representing Cardiff, index 3 Dover, etc...
                    Notice each jagged array increases in size by one.*/
            int[][] mileageTable = {
                new int[] { 0 },
                new int[] { 290 },
                new int[] { 373, 102 },
                new int[] { 496, 185, 228 },
                new int[] { 193, 110, 208, 257 },
                new int[] { 214, 90, 165, 270, 73 },
                new int[] { 412, 118, 150, 81, 191, 198 },
                new int[] { 222, 86, 173, 285, 41, 34, 201 },
                new int[] { 112, 207, 301, 360, 94, 155, 288, 141 },
                new int[] { 186, 129, 231, 264, 25, 97, 194, 66, 82 }
            };

            // Print the table using a nested for loop.
            int index = 0;
            foreach (int[] miles in mileageTable)
            {
                for (int j = 0; j < miles.Length; j++)
                {
                    Console.Write(miles[j].ToString().PadLeft(4) + " ");
                }
                Console.WriteLine(" " + cityList[index]);
                ++index;
            }

            Console.WriteLine();  // space in output
            // Now you can use the table to determine closest mileage to Manchester
            // You will not need to send the entire jagged array in the calls to Min() and Max(), you will need to select the array representing Manchester = [7]

            // Call Min() and print the closest mileage (no need to print the city, the table is printed for reference)
            // The closest is 34 miles

            // Call Max() and print the farthest mileage (no need to print the city, the table is printed for reference)
            // The farthest is 285 miles

            // Extra Credit: Print the name of the city from Min() and Max()
            // The closest is 34 to Liverpool
            // The farthest is 285 to Dover

            int shortestDistance = Min(mileageTable[7]);
            Console.WriteLine($"The closest is {shortestDistance} miles to {cityList[5]}");

            int farthestDistance = Max(mileageTable[7]);
            Console.WriteLine($"The farthest is {farthestDistance} miles to {cityList[3]}");


            Console.WriteLine();
        }
    }
}
