using System;

namespace DaysOfTheWeekHamlin
{
    /***************************************************************
    * Name         : DaysOfTheWeekHamlin
    * Author       : Anthony Hamlin
    * Created      : 09/16/2022
    * Course       : CIS 169 - C#
    * Version      : 1.0
    * OS           : Windows 10
    * IDE          : Visual Studio 2019 Community
    * Copyright    : This is my own original work based on
    *                      specifications issued by our instructor
    * Description  : This program is $$$$$$$$
    *                      Input :  User input of integer - Expecting range 1 to 7
    *                      Output:  Display string of the day of the week
    * Academic Honesty: I attest that this is my original work.
    * I have not used unauthorized source code, either modified or
    * unmodified. I have not given other fellow student(s) access
    * to my program.        
    ***************************************************************/

    class Program
    {
        static void Main(string[] args)
        {
            // Write a Console App that when you enter a number the Console output will display the corresponding string of the day of the week.
            // Declare a variable to store the day of the week
            String dayOfWeek;
            String dayNumString;
            int dayNum;

            // Include user input prompt
            Console.WriteLine("Enter a integer value for the day of the week (1-7): ");
            dayNumString = Console.ReadLine();
            // Include input validation for user input - Expecting an integer range 1 to 7
            // check that input is invalid and exit
            if (int.TryParse(dayNumString, out dayNum))
            {
                if (dayNum >= 1 && dayNum <= 7)
                {
                    // Use a switch statement to assign the variable
                    switch (dayNum)
                    {
                        case 1:
                            dayOfWeek = "1 = Monday";
                            break;
                        case 2:
                            dayOfWeek = "2 = Tuesday";
                            break;
                        case 3:
                            dayOfWeek = "3 = Wednesday";
                            break;
                        case 4:
                            dayOfWeek = "4 = Thrusday";
                            break;
                        case 5:
                            dayOfWeek = "5 = Friday";
                            break;
                        case 6:
                            dayOfWeek = "6 = Saturday";
                            break;
                        case 7:
                            dayOfWeek = "7 = Sunday";
                            break;
                        default:  // this segemnt of the case isn't reachable as far as I can tell
                            dayOfWeek = "-1 = Invalid Day";
                            break;
                    }
                    // Include only ONE Console.WriteLine() after the switch to print the day of the week variable
                    // For example, 1 = Monday, 2 = Tuesday, ..., 7 = Sunday.
                    Console.WriteLine($"{dayOfWeek}");
                }
                else
                {
                    Console.WriteLine("Day input value is invalid. Must be an interger between 1-7. Exiting Program!");
                }
            }
            else
            {
                Console.WriteLine("Day input value is invalid. Must be an interger between 1-7. Exiting Program!");
            }

        }
    }
}
