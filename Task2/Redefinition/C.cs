using System;
using System.Collections.Generic;
using System.Text;

namespace Redefinition
{
    class C: B
    {
        public int property;

        public override void Show()
        {
            Console.WriteLine("Show C");

            //base.Show();
        }

        public new void Display()
        {
            Console.WriteLine("Display C");
            //base.Display();
        }

        public override void Screen()
        {
            Console.WriteLine("Screen C");
        }

        
    }
}
