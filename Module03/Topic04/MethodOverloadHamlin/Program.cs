using System;
/***************************************************************
* Name         : MethodOverloadHamlin
* Author       : Anthony Hamlin
* Created      : 09/09/2022
* Course       : CIS 169 - C#
* Version      : 1.0
* OS           : Windows 10
* IDE          : Visual Studio 2019 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This program is a console app to compute average of three numbers for four different numeric data types
*                      Input :  static - float, decimal, int and double
*                      Output: Prints the results for each method used (with enough information for the user to understand the output)
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
namespace MethodOverloadHamlin
{
    class Program
    {
        // Method signatures for numeric data types float, decimal, int and double - Name your method Average()
        // float signature
        private static float Average(float num1, float num2, float num3, int AVG_DEVISOR)
        {
            // selected float as the return type since that is the numeric type being averaged
            return (num1 + num2 + num3) / AVG_DEVISOR;
        }

        // decimal signature
        private static decimal Average(decimal num1, decimal num2, decimal num3, int AVG_DEVISOR)
        {
            // selected decimal as the return type since that is the numeric type being averaged
            return (num1 + num2 + num3) / AVG_DEVISOR;
        }

        // int signature
        private static double Average(int num1, int num2, int num3, int AVG_DEVISOR)
        {
            // selected double as the return type since division will force a decimal position. Cast to retain decimal point
            return (double)(num1 + num2 + num3) / AVG_DEVISOR;
        }
        private static double Average(double num1, double num2, double num3, int AVG_DEVISOR)
        {
            // selected double as the return type since that is the numeric type being averaged
            return (num1 + num2 + num3) / AVG_DEVISOR;
        }


        static void Main(string[] args)
        {
            // Avoid Magic Numbers!
            const int AVG_DEVISOR = 3;  // not sure if this is what you mean
            // Declare 3 variable of each type following naming conventions(DO NOT ASK FOR USER INPUT)
            float floatNum1 = 10.10f;
            float floatNum2 = 12.12f;
            float floatNum3 = 45.45f;

            decimal decimalNum1 = 10.10M;
            decimal decimalNum2 = 12.12M;
            decimal decimalNum3 = 45.45M;

            // result will deviate from other three
            int intNum1 = 10;
            int intNum2 = 12;
            int intNum3 = 45;

            double doubleNum1 = 10.10;
            double doubleNum2 = 12.12;
            double doubleNum3 = 45.45;

            // Declare 4 variables to store the result of each average following naming conventions
            // Make a method call to each Average() for the 4 data types, storing the result in the corresponding variable
            // Print the results for each(with enough information for the user to understand the output)
            float floatTypeAvg = Average(floatNum1, floatNum2, floatNum3, AVG_DEVISOR);
            Console.WriteLine($"The average of the three floating point numbers is {floatTypeAvg:f3} ");

            decimal decimalTypeAvg = Average(decimalNum1, decimalNum2, decimalNum3, AVG_DEVISOR);
            Console.WriteLine($"The average of the three decimal numbers is {decimalTypeAvg:f3} ");

            double intTypeAvg = Average(intNum1, intNum2, intNum3, AVG_DEVISOR);
            Console.WriteLine($"The average of the three int numbers is {intTypeAvg:f3} ");

            double doubleTypeAvg = Average(doubleNum1, doubleNum2, doubleNum3, AVG_DEVISOR);
            Console.WriteLine($"The average of the three double numbers is {doubleTypeAvg:f3} ");

        }
    }
}
