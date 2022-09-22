using System;

namespace SumOfSalesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Console App that uses a for loop to sum up 4 sales at the local coffee shop. 
            // Declare and initialize a sum variable
            decimal sum = 0;
            string saleAmountStr = "";
            decimal saleAmount = 0;
            // for (number of sales )
            for (int i = 0; i < 4; i++)
            {
                // Prompt user for input
                Console.WriteLine("Enter the sales amount: ");
                // Get input 
                saleAmountStr = Console.ReadLine();
                if (decimal.TryParse(saleAmountStr, out saleAmount))
                {
                    // Add to sum 
                    sum += saleAmount;
                }
                else
                {
                    Console.WriteLine("Input Error: Sales amunt must be a number. Exiting Program!");
                    break;
                }

            }

            // Output sum with 2 decimal points precision
            Console.WriteLine($"Total sum of sales: {sum:c2}");


            //string color = "purple";
            //char letter;
            //for (int index = 0; index < color.Length; index++)
            //{ // note Length is a property of string
            //    letter = color[index];
            //    Console.WriteLine(letter.ToString()); //ToString is a method call 
            //}


        }
    }
}
