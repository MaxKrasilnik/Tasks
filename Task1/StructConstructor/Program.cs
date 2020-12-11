using System;
using System.Collections.Generic;

namespace StructConstructor
{
    struct SomeStruct
    {
        public int _i;
        public double _d;
        public string _s;



        public SomeStruct(int i)
            : this() // call the "default constructor"
        {
            _i = i;
            _s = "s";
            // The _d field is implicitly initialized!
        }

    }


    class Program//https://habr.com/ru/post/152118/
    {            //https://c-sharp.pro/?p=491
        static void Main(string[] args)
        {
            SomeStruct someStruct = new SomeStruct();
            Console.WriteLine(someStruct._d);
            Console.WriteLine(someStruct._i);

            SomeStruct someStruct1 = default(SomeStruct);
            Console.WriteLine(someStruct1._d);
            Console.WriteLine(someStruct1._i);

            SomeStruct[] somes = new SomeStruct[5];
            somes.Initialize();

        }
    }
}
