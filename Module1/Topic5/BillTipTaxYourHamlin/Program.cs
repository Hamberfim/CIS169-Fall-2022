using System;
/***************************************************************
* Name         : BillTipTaxYourHamlin
* Author       : Anthony Hamlin
* Created      : 08/24/2022
* Course       : CIS 169 - C#
* Version      : 1.0
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
            const double TIP_PERCENT = 0.20;
            const double SALES_TAX = 0.07;

            // Declare and initialize variables for two meals
            double bananaCacaoPowerBowl = 12.95;
            double chickpeaBurritoBowl = 11.95;

            // Declare and initialize variables for two desserts
            double alohaSmoothie = 9.99;
            double mangoColadaSmoothie = 10.99;

            // Declare variables subtotal, tax, tip, total and total per person
            double subtotal;
            double tax;
            double tip;
            double totalBill;
            double perPersonTotal;

            // Calculate the subtotal of the meals and the desserts, storing it into the subtotal variable
            subtotal = bananaCacaoPowerBowl + chickpeaBurritoBowl + alohaSmoothie + mangoColadaSmoothie;

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

            // Print the tip with a dollar sign($)
            Console.WriteLine($"Tip: {tip:C}");

            // Print the total bill with a dollar sign($)
            Console.WriteLine($"Total: {totalBill:C}");

            // Print the total per person with a dollar sign($)
            Console.WriteLine($"Per Person: {perPersonTotal:C}");

        }
    }
}
