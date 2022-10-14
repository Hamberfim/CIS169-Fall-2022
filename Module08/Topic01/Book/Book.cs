using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
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
    class Book
    {

        // Create a class, called Book with properties for an author, title, keywords, publication date and ISBN.
        // Submit Book.cs with Academic Honesty Header included.
        // Extra Credit: Use a collection for keywords.The collections you have used are array and List.
        // Which is more appropriate when not all books will have the same number of key words? (up to 3 points)

        // drive in Program.cs

        // fields/properties
        private string _author;
        private string _title;
        private string _keywords;
        private string _pubDate;
        private long _ISBN;

        // no-arg constructor
        public Book()
        {
            Author = "";
            Title = "";
            Keywords = "";
            PubDate = "";
            ISBN = 0;
        }

        // constructor 
        public Book(string author, string title, string keywords, string pubDate, long ISBN)
        {
            Author = author;
            Title = title;
            Keywords = keywords;
            PubDate = pubDate;
            this.ISBN = ISBN;
        }

        // set/get
        public string Author { get => _author; set => _author = value; }
        public string Title { get => _title; set => _title = value; }
        public string Keywords { get => _keywords; set => _keywords = value; }
        public string PubDate { get => _pubDate; set => _pubDate = value; }
        public long ISBN { get => _ISBN; set => _ISBN = value; }

        public override string ToString()
        {
            return (Title + ", " + Author + ", " + PubDate + ", Keywords: " + Keywords + ", ISBN: " + ISBN);
        }
    }
}
