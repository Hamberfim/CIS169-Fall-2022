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
            // Object one:
            // C# in Depth: Use the default no - arg default constructor. Set the values using properties.
            // details: Jon Skeet, C# in Depth, C#, programming, Mar 23, 2019, 9781617294532
            Book skeet = new Book();
            skeet.Author = "Jon Skeet";
            skeet.Title = "C# in Depth";
            skeet.Keywords = "C#, programming";
            skeet.PubDate = "Mar 23, 2019";
            skeet.ISBN = 9781617294532;

            // Object two:
            // murach's ASP.NET Core MVC: Use the non - default constructor and set values for attribute, except include an incorrect author.
            // Use the set to change the author property to the correct author.
            // details: murach's ASP.NET Core MVC, Mary Delamater and Joel Murach, January 2020, keywords: C#, ASP.NET, MVC, ISBN 978-1-943872-49-7
            Book murach = new Book("Billy Williams", "Murach's ASP.NET Core MVC", "C#, ASP.NET, MVC", "January 2020", 9781943872497);
            murach.Author = "Mary Delamater and Joel Murach";
            // Display the information for both books.
            Console.WriteLine(skeet);
            Console.WriteLine(murach);

            Console.WriteLine();  // space in output
        }
    }
}
