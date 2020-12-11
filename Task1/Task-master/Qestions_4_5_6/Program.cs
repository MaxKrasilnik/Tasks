using System;
using System.Collections;

namespace Qestions_4_5_6_7
{
    struct Square
    {
        public int perimeter;
        public int square;
        public int[] sides;

        public void Method(int a)
        {

        }

        public void Method(in int a)
        {

        }


        public void Show(string str = "Hello", string str2= " world")
        {
            Console.WriteLine(str+str2);
        }

        public void Perimeter(int a, int b, int c, int d)
        {
            perimeter = a + b + c + d;
            Console.WriteLine(perimeter);
        }


        public void Perimeter(in int p)
        {
            //p = 2; //Error
            perimeter = p;
        }


    }

    //?: operator https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
    //break/continue https://metanit.com/sharp/tutorial/2.6.php
    //Optional and named arguments https://professorweb.ru/my/csharp/charp_theory/level5/5_10.php
    //modificator in https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/in-parameter-modifier

    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            Console.WriteLine("Optional arguments");
            square.Show();

            Console.WriteLine();

            Console.WriteLine("Named arguments");
            square.Perimeter(d: 10, b: 8, a: 6, c: 4);

            Console.WriteLine();

            Console.WriteLine("Ternary operator");
            Console.WriteLine(square is Square ? "True" : "False");

            Console.WriteLine();

            Console.WriteLine("Operator continue");
            square.sides = new int[] { 1, 2, 3, 4 };
            for (int i =0; i < square.sides.Length; i++)
            {
                if (square.sides[i] == 3)
                    continue;
                Console.WriteLine(square.sides[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Operator break");
            for (int i = 0; i < square.sides.Length; i++)
            {
                if (square.sides[i] == 3)
                    break;
                Console.WriteLine(square.sides[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Operator in");
            int p = 9;
            square.Perimeter(p);
            Console.WriteLine("Perimeter="+ square.perimeter);

            
        }
    }
}
