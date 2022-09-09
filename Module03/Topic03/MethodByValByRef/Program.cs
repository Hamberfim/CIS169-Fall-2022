using System;
/***************************************************************
* Name         : MethodByValByRef
* Author       : Anthony Hamlin
* Created      : 09/09/2022
* Course       : CIS 169 - C#
* Version      : 1.0
* OS           : Windows 10
* IDE          : Visual Studio 2019 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This program  prints and then updates and print four people's ages
*                      Input : four static ages  - see comment in code
*                      Output: four ages & four ages updated - see comment in code
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
namespace MethodByValByRef
{
    class Program
    {
        // First Method by Value: Use Pascal Case to write a descriptive name for a method to PRINT four ages
        // Method accepts 4 ages as parameters, you determine the data type and if pass by value or by reference
        private static void PrintAges(int age1, int age2, int age3, int age4)
        {
            // Add a comment in the method body to explain the return type you selected
            // Determine the return type for the method: VOID - no return datatype needed.

            // Write a print statement to print the 4 ages (with enough information for the user to understand the output)
            Console.WriteLine($"The age of our four individuals is {age1}, {age2}, {age3}, and {age4}.");

            // Add a comment in the method stating if method is pass by reference or pass by value and why
            // THIS METHOD IS PASSED BY VALUE
        }

        // Write ONE method only to UPDATE the four people's ages.
        // Second Method by Reference: Use Pascal Case to write a descriptive name for a method to UPDATE ages
        // Method accepts 4 ages as parameters, you determine the data type and if pass by value or by reference
        private static Tuple<int, int, int, int> UpdateAges(ref int age1, ref int age2, ref int age3, ref int age4)
        {
            // Add a comment in the method body to explain the return type you selected
            // Tuple with int is my return type so that I can return multiple int values
            // Use the increment operator in the method
            age1++;
            age2++;
            age3++;
            age4++;

            return Tuple.Create(age1, age2, age3, age4);
        }


        static void Main(string[] args)
        {
            // Declare 4 variable representing the ages of 4 people, selecting appropriate data types, names and following naming conventions
            int age1 = 19;
            int age2 = 24;
            int age3 = 33;
            int age4 = 55;
            // Make a method call to print the ages
            PrintAges(age1, age2, age3, age4);  // by value
            // Make a method call to update the ages
            UpdateAges(ref age1, ref age2, ref age3, ref age4);  // by reference
            // Make a method call to print the ages
            PrintAges(age1, age2, age3, age4);
            
        }
    }
}
