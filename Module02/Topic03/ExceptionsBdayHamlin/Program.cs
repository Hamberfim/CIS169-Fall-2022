using System;
/***************************************************************
* Name         : ExceptionsBdayHamlin
* Author       : Anthony Hamlin
* Created      : 09/04/2022
* Course       : CIS 169 - C#
* Version      : 1.0
* OS           : Windows 10
* IDE          : Visual Studio 2019 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This program lets birthday party guest know how many cupcakes they each can have.
*                      Input : User prompt for number of people, of cupcakes ordered (cupcakes per person via program calculation)
*                      Output: An UnBirthday message and how many cupcakes each person can have.
*                      Extra Credit: A message about extra/remainder cupcake(s) via calculation = "There will be 1 extra for me!"
*                                  (i.e., output message would show 1 cupcake based on 13 cupcakes and 6 people)
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
namespace ExceptionsBdayHamlin
{
    class Program
    {

        static void Main(string[] args)
        {
            // Declares and initializes variables to zero
            //      Number of people, Number of cupcakes, Cupcakes per person
            int numberOfPeople = 0;
            int numberOfCupcakes = 0;
            double cupcakesPerPerson = 0;

            // needed for calculations
            int extraCupcakes = 0;

            // Prompts the user and gathers the following input
            //      Number of people invited to your birthday(or unbirthday party!)
            Console.WriteLine("Enter the number of people invited to your birthday party (or unbirthday party): ");
            // seems like we should be checking for a number greater than zero
            try
            {
                numberOfPeople = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine();  // provide space in output
                Console.WriteLine("Error reading input for number of people invited.");
                Console.WriteLine(e.Message);
                Console.WriteLine();  // provide space in output
            }

            //      Number of cupcakes ordered
            // seems like we should be checking for a number greater than zero
            Console.WriteLine("Enter the number of cupcakes ordered: ");
            try
            {
                numberOfCupcakes = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine();  // provide space in output
                Console.WriteLine("Error reading input for number of cupcakes ordered.");
                Console.WriteLine(e.Message);
                Console.WriteLine();  // provide space in output
            }


            // Calculates the number of cupcakes per guest
            // I would think that we would even want this block to even run only if the try's above execute ( nested try/catch ?? )
            try
            {
                cupcakesPerPerson = numberOfCupcakes / numberOfPeople;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine();  // provide space in output
                Console.WriteLine("Error Zero Division.");
                Console.WriteLine(e.Message);
                Console.WriteLine();  // provide space in output
            }

            // this display would need to be conditional and provide an alternative if the condition was false -based on all try/catch above
            //      Display the following output(example output shown based on 13 cupcakes and 6 people)
            //      Happy(UN)Birthday to me!
            Console.WriteLine("Happy (UN)Birthday to me!");
            //      You may have up to 2 cupcakes :) - cast to int - Nobody at the pary wants a half a cupcake
            Console.WriteLine($"You may each have up to {Convert.ToInt32(cupcakesPerPerson)} cupcake(s) :)");

            //// Extra credit 1 Point: Calculate the remainder of cupcakes(example output below shown based on 13 cupcakes and 6 people)
            extraCupcakes = numberOfCupcakes - (int)(numberOfPeople * cupcakesPerPerson);

            //// Example-  There will be 1 extra for me!
            Console.WriteLine($"There will be {extraCupcakes} extra cupcake(s) for me!");

        }
    }
}
