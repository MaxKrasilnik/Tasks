using System;
using System.Collections.Generic;
using System.Text;

namespace Redefinition
{
    class A
    {
        public virtual void Show()
        {
            Console.WriteLine("Show A");
        }

        public virtual void Display()
        {
            Console.WriteLine("Display A");
        }

        public virtual void Screen()
        {
            Console.WriteLine("Screen A");
        }

        public void ScreenNew()
        {
            Console.WriteLine("ScreenNew A");
        }
    }
}
