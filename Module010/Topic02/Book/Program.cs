using System;
/***************************************************************
* Name         : Book - interface
* Author       : Anthony Hamlin
* Created      : 10/24/2022
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
            // driver for Book class using interface
            // Create a book object, book1,
            Book book1 = new Book("Temple Grandin", "Visual Thinking", "Thinking in Pictures", "October 11, 2022", 0593418360);

            // Clone book1 into a second object book2,
            Book book2 = new Book();
            book2 = (Book)book1.Clone();

            // Display both the objects.
            Console.WriteLine($"Book1: {book1.ToString()}");
            Console.WriteLine($"Book2: {book2.ToString()}");
        }
    }
}
