using System;
/***************************************************************
* Name         : MethodBasicsHamlin
* Author       : Anthony Hamlin
* Created      : 09/09/2022
* Course       : CIS 169 - C#
* Version      : 1.0
* OS           : Windows 10
* IDE          : Visual Studio 2019 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This program create two methods - NewPrice() which is
*                used to determin a price discout and DisplayNumericData() 
*                called from within the main to diplay the data
*                      Input : static - price and percent discount
*                      Output: display of the price discount
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
namespace MethodBasicsHamlin
{
    class Program
    {
        // NewPrice() method: accepts two numbers, the first is a price, the second is the percent discount, returns the new the price
        private static decimal NewPrice(decimal price, decimal discount)
        {
            // since we are delaing with currency and percents I'm using the decimal data type
            return price - (price * discount);
        }

        // DisplayNumericData() method: accepts a numeric data type and prints it to the console
        private static void DisplayNumericData(decimal discountedPrice)
        {
            // prints the numeric value with accuracy of 2 decimal places or as currency
            Console.WriteLine($"{discountedPrice:C}");
        }

        static void Main(string[] args)
    {
            // Set variables price, discount.  No try/catch as the data input is controlled
            decimal price = 19.99m;
            decimal discount = 0.10m;

            // In Main() method, write a method call to store the result of NewPrice()
            // in an appropriately named variable of the appropriate data type.
            decimal discountedPrice = NewPrice(price, discount);  // instructor specified but in example given it's not used
            // DisplayNumericData(discountedPrice);  <-- could be used but I'm folowing the instructions

            // Write a method called DisplayNumericData that accepts a numeric data type and prints it
            // Example given by instructor: DisplayNumericData(NewPrice(price, discount));
            DisplayNumericData(NewPrice(price, discount));

        }
    }
}
