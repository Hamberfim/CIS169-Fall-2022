using System;
/*Name your project Methods and Unit Tests MethodTests.

Write a method to get user input GetUserInput()
Prompts the user for their score
Returns a string
Write a method ConvertToInt() 
Accepts a string
Convert to an integer 
    Sets return value to valid score value (positive) 
    Sets the return value to -1 for a non-score value (eg, -1)
Returns an int 
Write a method ValidateInput()
Accepts an int
Validates int is a valid score (zero or greater)
Returns boolean value
In the Main() method
Contains a while loop with that asks the user if they want to enter more scores
    Calls GetUserInput()
    Calls ConvertToInt()
        Include decision structure: if cannot convert to int, continue to get next input from user
    Calls ValidateInput()
        Include decision structure: if not valid, continue to next input from user
    Keeps a running total of scores and number of scores
Average the scores
Be sure to use a break or continue! 
UNIT TESTING. Time to write your own unit tests. Watch the video to get you started!
    // ARRANGE
    // ACT
    // ASSERT
Include 4 Unit Tests to test ConvertToInt()
    Test a good value (string can be converted to int)
    Test an int non-score value (negative) 
    Test a string value (string cannot be converted to int, it's a string "st%$")
    Test a decimal value (string cannot be converted to int, it's decimal/double)
Include 3 Unit Tests to test ValidateInput()
    Test a good value (int is greater than zero)
    Test edge case (int is zero)
    Test bad value (int is less than zero)

Submit your Methods/Program.cs file with the Academic Honesty Header included and MethodsTests/UnitTest1.cs*/
namespace Methods
{
    /***************************************************************
    * Name         : Methods - For Module 5/Topic 5
    * Author       : Anthony Hamlin
    * Created      : 09/23/2022
    * Course       : CIS 169 - C#
    * Version      : 1.0
    * OS           : Windows 10
    * IDE          : Visual Studio 2019 Community
    * Copyright    : This is my own original work based on
    *                      specifications issued by our instructor
    * Description  : This program is used to unit test of methods that convert to an integer and validate input.
    *                      Input :  Unit test method calls
    *                      Output:  Unit test assertions
    * Academic Honesty: I attest that this is my original work.
    * I have not used unauthorized source code, either modified or
    * unmodified. I have not given other fellow student(s) access
    * to my program.        
    ***************************************************************/
    public class Program
    {
        // Name your project Methods and Unit Tests MethodTests.
        //Write a method to get user input GetUserInput()
        public static string GetUserInput()
        {
            string scoreStr = "";
            //Prompts the user for their score
            Console.WriteLine("Enter the score: ");
            scoreStr = Console.ReadLine();
            //Returns a string
            return scoreStr;
        }

        //Write a method ConvertToInt() - Accepts a string
        public static int ConvertToInt(string scoreStr)
        {
            int scoreInt = 0;
            //Convert to an integer
            if (int.TryParse(scoreStr, out scoreInt))
            {
                // Sets return value to valid score value (positive) 
                if (scoreInt > 0)
                {
                    return scoreInt;
                }
                else
                {
                    return -1;
                }

            }
            else
            {
                // Sets the return value to -1 for a non-score value (eg, -1)
                //Returns an int 
                return -1;
            }
        }

        //Write a method ValidateInput() - Accepts an int
        public static bool ValidateInput(int value)
        {
            // Validates int is a valid score (zero or greater)
            if (value > 0)
            {
                //Returns boolean value
                return true;
            }
            else
            {
                //Returns boolean value
                return false;
            }

        }

        static void Main(string[] args)
        {
            bool willContinue = true;
            string userRespone = "";
            decimal total = 0;
            decimal average = 0;
            bool isValid = false;
            int scoreCount = 0;
            //In the Main() method
            //Contains a while loop with that...
            while (willContinue)
            {
                // asks the user if they want to enter more scores
                Console.WriteLine("Would you like to enter a score? (Y)es/(N)o ");
                userRespone = Console.ReadLine();
                userRespone.ToLower();
                if (userRespone.StartsWith('y'))
                {
                    string scoreStr = "";
                    int scoreInt = 0;
                    // Calls GetUserInput()
                    scoreStr = GetUserInput();
                    // Calls ConvertToInt()
                    scoreInt = ConvertToInt(scoreStr);
                    // Calls ValidateInput()
                    isValid = ValidateInput(scoreInt);
                    // Include decision structure: if cannot convert to int, continue to get next input from user
                    if (isValid)
                    {
                        // Keeps a running total of scores and number of scores 
                        total += scoreInt;
                        scoreCount++;
                    }
                    else
                    {
                        // if not valid, continue to next input from user
                        continue;
                    }

                }
                else
                {
                    willContinue = false;
                    //Be sure to use a break or continue!  
                    continue;
                }

            }

            //Average the scores
            average = (decimal)total / scoreCount;
            Console.WriteLine($"The score average is {average:f2}");

            // Submit your Methods/Program.cs file with the Academic Honesty Header included and MethodsTests/UnitTest1.cs
        }
    }
}
