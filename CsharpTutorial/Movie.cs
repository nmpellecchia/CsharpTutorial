using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpTutorial
{
    class Movie
    {
        // public means the data can be accessed by anyone
        // private means the data can only be accessed by code inside this class
        private string title;
        private string director;
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating; // the method not the attribute
        }
        // Getter and Setter
        public string Rating
        {
            get { return rating; }
            // I can assign specific rules to the setter
            set { 
                // value represent what was passed
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
