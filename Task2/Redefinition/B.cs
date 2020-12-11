using System;
using System.Collections.Generic;
using System.Text;

namespace Redefinition
{
    class B : A
    {
        public override void Show()
        {
            Console.WriteLine("Show B");
        }

        public override sealed void Display()
        {
            Console.WriteLine("Display B");
        }

        public new void ScreenNew()
        {
            Console.WriteLine("ScreenNew B");
        }
    }
}
