using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpTutorial
{
    // Put " : " and the class you want to inherit
    // now ItalianChef can do the same things than a regular Chef + more
    class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The chef makes pasta");
        }
        // Use the override keyword to override virtual methods

        public override void MakeSpecial()
        {
            Console.WriteLine("The chef makes lasagna");
        }
    }
}
