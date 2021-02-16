using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpTutorial
{
    class Book
    {
        public string title;
        public string author;
        public int pages;
        // Constructor; create a method with the name of the class
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
        // This takes no parameters, so new objects can be created like the first time
        public Book()
        {

        }

    }
}
