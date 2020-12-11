using System;

namespace BoxingUnboxing
{
    class Program//https://habr.com/ru/post/239219/
    {
        public enum EnumType { None=10 }

        public enum Week
        {
            Monday,
            Tuesday,
            Wednesday
        }

        static void Main(string[] args)
        {
            object box = (int)42;
            long unbox = (long)(int)box;
            Console.WriteLine("long unbox = (long)(int)box;");
            Console.WriteLine(unbox);

            Console.WriteLine();

            long unbox1 = (long)(EnumType)box;
            Console.WriteLine("long unbox1 = (long)(EnumType)box;");
            Console.WriteLine(unbox1);

            Console.WriteLine();

            long unbox3 = (int)EnumType.None;
            Console.WriteLine("long unbox3 = (int)EnumType.None;");
            Console.WriteLine(unbox3);

            Console.WriteLine();

            Week week;
            week = Week.Wednesday;
            Console.WriteLine("week = Week.Wednesday;");
            Console.WriteLine((int)week); // 3
            Console.WriteLine(week); // Wednesday

            Console.WriteLine();

            Week week1 = new Week();
            Console.WriteLine("Week week1 = new Week();");
            Console.WriteLine((int)week1); // 0
            Console.WriteLine(week1); // Monday
        }
    }
}
