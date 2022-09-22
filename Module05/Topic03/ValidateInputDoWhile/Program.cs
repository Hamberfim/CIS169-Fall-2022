using System;

namespace ValidateInputDoWhile
{
    /***************************************************************
    * Name         : ValidateInputDoWhile
    * Author       : Anthony Hamlin
    * Created      : 09/22/2022
    * Course       : CIS 169 - C#
    * Version      : 1.0
    * OS           : Windows 10
    * IDE          : Visual Studio 2019 Community
    * Copyright    : This is my own original work based on
    *                      specifications issued by our instructor
    * Description  : This program that uses a do-while loop to validate input for a business logic rule
    *                      Input :  user input vaidating if it's between 7 - 32
    *                      Output:  message with the users valid input
    * Academic Honesty: I attest that this is my original work.
    * I have not used unauthorized source code, either modified or
    * unmodified. I have not given other fellow student(s) access
    * to my program.        
    ***************************************************************/
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a variable for storing user input
            int userInput = 0;
            // Declare a variable for storing if input is invalid 
            bool isValidInput = false;
            do
            {
                // Prompt the user for a number between 7 and 32
                Console.WriteLine("Enter an integer between 7-32: ");
                // Get the input 
                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());
                    if (userInput > 6 && userInput < 33)
                    {
                        isValidInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, user input is outside the requested range. Try Again\n");
                    }

                }
                catch (FormatException err)
                {
                    Console.WriteLine($"\nError reading input from user. {err.Message}\nUser input must be an integer between 7-32. Try again.\n");

                }

                // Test if input is invalid and (update loop condition variable or prompt user that input is incorrect)


            } while (!isValidInput);

            // Output message with valid input
            Console.WriteLine($"\nUser input of {userInput} is valid.");
        }
    }
}
