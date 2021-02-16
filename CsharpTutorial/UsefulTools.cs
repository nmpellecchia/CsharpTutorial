using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpTutorial
{
    //You can't create instances because is a static class
    static class UsefulTools
    {
        public static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
