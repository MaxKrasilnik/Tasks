using System;

namespace IsAndAs
{
    class Book
    {
        public int qtyPages;

        public Book()
        {
            qtyPages = 100;
        }

        public Book(int qty)
        {
            qtyPages = qty;
        }
    }

    class Magazine : Book
    {

    }

    class Program//Troelsen p.269-273
    {
        static void Main(string[] args)
        {
            object[] obj = new object[3];
            obj[0] = new Book(120);
            obj[1] = new Magazine();
            obj[2] = false;

            Console.WriteLine("as");
            for (int i = 0; i < obj.Length; i++)
            {
                Book b = obj[i] as Book;//If condition is true it will return this object. Oterwise it will return null.

                if (b == null)
                    Console.WriteLine("null");
                else
                    Console.WriteLine($"{b.ToString()}={b.qtyPages}");
            }

            Console.WriteLine();
            Console.WriteLine("is");
            foreach (var o in obj)
                if (o is Book b)
                    Console.WriteLine($"{b.ToString()}={b.qtyPages}");
                
        }
    }
}
