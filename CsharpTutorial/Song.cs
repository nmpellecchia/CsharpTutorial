using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpTutorial
{
    class Song
    {
        public string title;
        public string author;
        public int duration;
        // static attributes are attributes about the class itself
        // the static type is necessary
        public static int songCount = 0;

        public Song(string aTitle, string aAuthor, int aDuration)
        {
            title = aTitle;
            author = aAuthor;
            duration = aDuration;
            // given that this methods gets called everytime a new instance is created
            // I can update the static attribute
            songCount++;
        }
        // This is to make possible returning the songCount calling an instance and not the class itself
        public int GetSongCount()
        {
            return songCount;
        }
    }
}
