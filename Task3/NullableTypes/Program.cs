using System;

namespace NullableTypes
{
    class Program//Nullable-типы: https://metanit.com/sharp/tutorial/2.17.php
    {
        static void Main(string[] args)
        {
            int? x = 5;
            if (x.HasValue)
                Console.WriteLine("x.Value=" + x.Value);
            else
                Console.WriteLine(x.HasValue);
            Console.WriteLine();

            int? figure = null;
            Console.WriteLine("figure.GetValueOrDefault()=" + figure.GetValueOrDefault()); // по умолчанию используется 0
            Console.WriteLine("figure.GetValueOrDefault(10)=" + figure.GetValueOrDefault(10)); // по умолчанию используется 10
            Console.WriteLine("figure.GetValueOrDefault()=" + figure.GetValueOrDefault()); // по умолчанию используется 0
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Nullable-типы");
            int? x1 = null;
            int? x2 = null;
            Console.WriteLine($"x1 = null; x2 = null;");
            if (x1 == x2)
                Console.WriteLine("объекты равны");
            else
                Console.WriteLine("объекты не равны");

            x1 = 0;
            Console.WriteLine($"x1 = 0; x2 = null;");
            if (x1 == x2)
                Console.WriteLine("объекты равны");
            else
                Console.WriteLine("объекты не равны");

            x2 = 0;
            Console.WriteLine($"x1 = 0; x2 = 0;");
            if (x1 == x2)
                Console.WriteLine("объекты равны");
            else
                Console.WriteLine("объекты не равны");

            x2 = 20;
            Console.WriteLine($"x1 = 0; x2 = 20;");
            if (x1 == x2)
                Console.WriteLine("объекты равны");
            else
                Console.WriteLine("объекты не равны");
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Преобразование типов Nullable");
            int? y1 = null;
            if (y1.HasValue)
            {
                int y2 = (int)y1;
                Console.WriteLine("явное преобразование от T? к T");
                Console.WriteLine("int y2 = (int)y1;");
                Console.WriteLine(y2);
                Console.WriteLine();
            }

            int z1 = 4;
            int? z2 = z1;
            Console.WriteLine("неявное преобразование от T к T?");
            Console.WriteLine("int? z2 = z1;");
            Console.WriteLine(z2);
            Console.WriteLine();

            int q1 = 4;
            long? q2 = q1;
            Console.WriteLine("неявные расширяющие преобразования от V к T?");
            Console.WriteLine("long? q2 = q1;");
            Console.WriteLine(q2);
            Console.WriteLine();

            long w1 = 4;
            int? w2 = (int?)w1;
            Console.WriteLine("явные сужающие преобразования от V к T?");
            Console.WriteLine("int? w2 = (int?)w1;");
            Console.WriteLine(q2);
            Console.WriteLine();

            long? e1 = 4;
            int? e2 = (int?)e1;
            Console.WriteLine("Подобным образом работают преобразования от V? к T?");
            Console.WriteLine("int? e2 = (int?)e1;");
            Console.WriteLine(q2);
            Console.WriteLine();

            long? r1 = 4;
            int r2 = (int)r1;
            Console.WriteLine("явные преобразования от V? к T");
            Console.WriteLine("int r2 = (int)r1;");
            Console.WriteLine(q2);
            Console.WriteLine();
        }
    }
}
