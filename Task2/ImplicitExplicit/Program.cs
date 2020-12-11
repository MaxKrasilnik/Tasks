using System;

namespace ImplicitExplicit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hexagon -> Triangle");
            Hexagon hexagon = new Hexagon(1, 2, 3, 4, 5, 6);
            Triangle triangle = hexagon;
            triangle.Show();
            Console.WriteLine();

            Console.WriteLine("Square -> Triangle");
            Square square = new Square(50, 60, 70, 80);
            triangle = (Triangle)square;
            triangle.Show();
        }
    }
}
