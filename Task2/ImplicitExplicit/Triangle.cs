using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImplicitExplicit
{
    class Triangle
    {
        public int a;
        public int b;
        public int c;

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void Show()
        {
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.WriteLine("c=" + c);
        }

        public static explicit operator Triangle(Square square)
        {
            return new Triangle(square.a, square.b, square.c);
        }

        public static implicit operator Triangle(Hexagon hexagon)
        {
            return new Triangle(hexagon.a, hexagon.b, hexagon.c);
        }


    }
}
