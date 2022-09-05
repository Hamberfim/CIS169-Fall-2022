using System;
/***************************************************************
* Name         : BillTipTaxYourHamlin
* Author       : Anthony Hamlin
* Created      : 09/05/2022
* Course       : CIS 169 - C#
* Version      : 1.1 - revisions according to instructor
* OS           : Windows 10
* IDE          : Visual Studio 2019 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This program calculates a total bill for two meals at a restaurant, then divides the check between the individuals
*                      Input :  static/included
*                      Output: 1.) Subtotal with a dollar sign, 
*                              2.) Tax with a dollar sign,
*                              3.) Tip with a dollar sign, 
*                              4.) Total bill with a dollar sign, 
*                              5.) Total per person with a dollar sign
*                              6.) Format the numbers to print only 2 decimal places for all output.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
namespace BillTipTaxYourHamlin
{
    class Program
    {
        /* Declares variables for tax rate, tip percentage, 
         * two different meals, two different desserts, 
         * tax, tip, subtotal, total and total per person. */
        static void Main(string[] args)
        {
            // Declare and initialize constants - Decide which variables should be constants
            const int GUEST_COUNT = 2;  // two meals assumes two guests
            const decimal TIP_PERCENT = 0.20M;
            const decimal SALES_TAX = 0.07M;

            // For any input that is non-numeric, make sure the value is zero - what would be non-numeric?
            // Declare variables subtotal, tax, tip, total and total per person
            decimal subtotal = 0;
            decimal tax = 0;
            decimal tip = 0;
            decimal totalBill = 0;
            decimal perPersonTotal = 0;
            decimal meal1 = 0;
            decimal meal2 = 0;
            decimal dessert1 = 0;
            decimal dessert2 = 0;

            // Prompt the user to input the price of Meal 1, using exception handling for possible string input
            Console.WriteLine("Please enter the cost of Meal 1: ");
            try
            {
                meal1 = Convert.ToDecimal(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in meal one price");
                Console.WriteLine(e.Message);
            }

            // Prompt the user to input the price of Meal 2, using exception handling for possible string input
            Console.WriteLine("Please enter the cost of Meal 2: ");
            try
            {
                meal2 = Convert.ToDecimal(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in meal two price");
                Console.WriteLine(e.Message);
            }

            // Prompt the user to input price of Dessert 1, using exception handling for possible string input
            Console.WriteLine("Please enter the cost of Dessert 1: ");
            try
            {
                dessert1 = Convert.ToDecimal(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in dessert one price");
                Console.WriteLine(e.Message);
            }

            // Prompt the user to input price of Dessert 2, using exception handling for possible string input
            Console.WriteLine("Please enter the cost of Dessert 2: ");
            try
            {
                dessert2 = Convert.ToDecimal(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in dessert tow price");
                Console.WriteLine(e.Message);
            }

            // Complete the meal calculation with values, possibly with zero(s) for the bad input
            // Calculate the subtotal of the meals and the desserts, storing it into the subtotal variable
            subtotal = meal1 + meal2 + dessert1 + dessert2;

            // Calculate the tax, using a tax rate of 7 %, from the subtotal, storing it in the tax variable
            tax = subtotal * SALES_TAX;

            // Calculate the tip, using a tip rate of 20 %, from the subtotal, storing it in the tip variable
            tip = subtotal * TIP_PERCENT;

            // Calculate the total bill
            totalBill = subtotal + tax + tip;

            // Calculate what each individual should pay, storing it in total per person(NOTE: do not use a Magic Number!)
            perPersonTotal = totalBill / GUEST_COUNT;

            // Print the subtotal with a dollar sign($)
            Console.WriteLine($"Subtotal: {subtotal:C}");

            // Print the tax with a dollar sign($)
            Console.WriteLine($"Tax: {tax:C}");

            // matching instructors display
            Console.WriteLine($"Tip {TIP_PERCENT:P}: {tip:C}");
            Console.WriteLine($"Tax {SALES_TAX:P}: {tax:C}");
            Console.WriteLine($"Subtotal: {subtotal:C}");
            Console.WriteLine($"Total: {totalBill:C}");

            // Print the total per person with a dollar sign($)
            Console.WriteLine($"Per Person: {perPersonTotal:C}");

        }
    }
}
