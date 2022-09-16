using System;

namespace Module4
{
    /***************************************************************
    * Name         : Module4 Unit Test - Decision w/Unit Test
    * Author       : Anthony Hamlin
    * Created      : 09/16/2022
    * Course       : CIS 169 - C#
    * Version      : 1.0
    * OS           : Windows 10
    * IDE          : Visual Studio 2019 Community
    * Copyright    : This is my own original work based on
    *                      specifications issued by our instructor
    * Description  : This program is $$$$$$$$
    *                      Input : Prompts the user for the day (Monday-Thursday) and meal time (lunch or dinner)
    *                      Output: Prints the meal/food choice based on an existing menu
    * Academic Honesty: I attest that this is my original work.
    * I have not used unauthorized source code, either modified or
    * unmodified. I have not given other fellow student(s) access
    * to my program.        
    ***************************************************************/

    public class Program
    {
        /*  DecideMeal() Method accepts the day (Monday, Tuesday, Wednesday, Thursday) and meal time (lunch, dinner)
         *    Lunch: 
         *      Monday: VeggieBurger and Fries
	     *      Tuesday: Chili and cornbread
	     *      Wednesday: Pad Thai 
	     *      Thursday: Baked Potato
	     *      
         *    Dinner: 
         *      Monday: Lasagna
	     *      Tuesday: Pizza
	     *      Wednesday: Soup and Salad
	     *      Thursday: Spaghetti  
	     *      
         *  Use nested if statements check the day checks and the meal time.
         *  Returns the appropriate meal based on an existing menu */
        public static string DecideMeal(string day, string mealTime)
        {
            day = day.ToLower();
            mealTime = mealTime.ToLower();
            if (mealTime == "lunch")
            {
                if (day == "monday")
                {
                    return "VeggieBurger and Fries";
                }
                else if (day == "tuesday")
                {
                    return "Chili and cornbread";
                }
                else if (day == "wednesday")
                {
                    return "Pad Thai";
                }
                else if (day == "thursday")
                {
                    return "Baked Potato";
                }
                else if (day == "friday")
                {
                    return "Taco Pie";
                }
                else if (day == "saturday")
                {
                    return "Chef Salad";
                }
                else if (day == "sunday")
                {
                    return "Quiche and coffee";
                }

            }
            else if (mealTime == "dinner")
            {
                if (day == "monday")
                {
                    return "Lasagna";
                }
                else if (day == "tuesday")
                {
                    return "Pizza";
                }
                else if (day == "wednesday")
                {
                    return "Soup and Salad";
                }
                else if (day == "thursday")
                {
                    return "Spaghetti";
                }
                else if (day == "friday")
                {
                    return "Tapas and Red Wine";
                }
                else if (day == "saturday")
                {
                    return "Movie Popcorn and Soda";
                }
                else if (day == "sunday")
                {
                    return "Pot Roast and Red Wine";
                }
            }
            return "Ice Cream!";
        }

        static void Main(string[] args)
        {
            // Prompt user for day
            Console.WriteLine("Enter a day of the week (Monday, Tuesday, etc.): ");
            string day = Console.ReadLine();
            // Prompt user for meal
            Console.WriteLine("Enter a meal time (lunch/dinner): ");
            string meal = Console.ReadLine();

            // Call DecideMeal(), sending the necessary variables, storing the return value in a variable mealString
            string mealString = DecideMeal(day, meal);
            // Print the day, time and the meal (the variable mealString)
            Console.WriteLine($"{day} is {mealString} for {meal}");
        }

    }
}
