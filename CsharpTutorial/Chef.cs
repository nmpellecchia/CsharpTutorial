using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpTutorial
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The chef makes chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The chef makes salad");
        }
        // virtual allows the method to be overrided in an inherited class
        public virtual void MakeSpecial() 
        {
            Console.WriteLine("The chef makes churros");
        }
    }
}
