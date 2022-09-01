using System;
/***************************************************************
* Name         : HelloWorldHamlin
* Author       : Anthony Hamlin
* Created      : 08/23/2022
* Course       : CIS 169 - C#
* Version      : 1.0
* OS           : Windows 10
* IDE          : Visual Studio 2019 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This program is the quintessential Hello World
*                      Input :  None
*                      Output: String Hello World!
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
namespace HelloWorldHamlin
{
    class Program
    {
        static void Main(string[] args)
        {
            // string variable 
            string professor = "Dr. M. E. Ruse";

            // ouput with a little flair 
            Console.WriteLine($"Hello World! Hello {professor}!");
            Console.WriteLine(); // space in output

            // Debug
            string name = "Anthony Hamlin"; // enter your name here           
            string favoriteColor = "cerulean"; // change to your favorite
            string favoriteFood = "raspberries"; // change if you wish
            Console.WriteLine("Name: " + name);
            Console.Write("Favorite thing to eat: " + favoriteFood);
            Console.WriteLine(" but it's not even " + favoriteColor + ".");
            int quantity = 5;
            decimal price = 3.99M;
            decimal totalCost = quantity * price;
            Console.WriteLine("It will cost " + totalCost);

        }
    }
}
