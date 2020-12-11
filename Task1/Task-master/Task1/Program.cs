using System;

namespace CompositeTypes
{
    struct PencilCase
    {
        public int lenght;
        public int width;
        public Pencil pencil;
    }

    class Pencil
    {
        public int lenght;
        public string color;
    }



    class Program//https://metanit.com/sharp/tutorial/2.16.php
    {
        static void Main(string[] args)
        {
            PencilCase pencilCase = new PencilCase();
            pencilCase.width = 15;
            pencilCase.lenght = 30;
            pencilCase.pencil = new Pencil();
            pencilCase.pencil.lenght = 25;
            pencilCase.pencil.color = "green";


            PencilCase pencilCase1 = pencilCase;
            pencilCase1.width = 5;
            pencilCase1.lenght = 10;
            pencilCase1.pencil.lenght = 15;
            pencilCase1.pencil.color = "blue";

            Console.WriteLine("First pencil case:");
            Console.WriteLine("width=" + pencilCase.width);
            Console.WriteLine("lenght=" + pencilCase.lenght);
            Console.WriteLine("pencil.lenght=" + pencilCase.pencil.lenght);
            Console.WriteLine("pencil.color=" + pencilCase.pencil.color);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Second pencil case:");
            Console.WriteLine("width=" + pencilCase1.width);
            Console.WriteLine("lenght=" + pencilCase1.lenght);
            Console.WriteLine("pencil.lenght=" + pencilCase1.pencil.lenght);
            Console.WriteLine("pencil.color=" + pencilCase1.pencil.color);

            Console.WriteLine();

            Console.WriteLine("Width and lenght pensil`s case are different, because they are meaningful(значимые) data types(int). Pensil`s lenght and color the same because class Pencil is a reference(ссылочный) data type");
        }

    }


}
