using System;
/***************************************************************
* Name         : Book
* Author       : Anthony Hamlin
* Created      : 10/13/2022
* Course       : CIS 169 - C#
* Version      : 1.0
* OS           : Windows 10
* IDE          : Visual Studio 2019 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This program creates a book class
*                      Input :  Fields in the class - author, title, keywords, publication date and ISBN.
*                      Output: a book instance
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            // driver for Book class
            Book ruralHistory = new("Sarah Farmer", "Rural Inventions after 1945", "French History, History, Essay", "March 18, 2020", "978-0190079079");
            Console.WriteLine(ruralHistory);
        }
    }
}
