using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    interface IA
    {
        static int propertyStatic;//статические свойства
        static int AutoPropertyStatic { get; set; }//статические автосвойства
        static void MethodStatic() //статические методы, обязательно с реализацией
        {
            Console.WriteLine("MethodStatic");
        }

        static IA()
        {
            propertyStatic = 0;
            AutoPropertyStatic = 10;
        }//статический конструктор

        string AutoProperty { get; set; }//свойства
        void Method();//сигнатура метода
        void MethodWithRealize() //метод, с реализацией
        {
            Console.WriteLine("((IA)b).MethodWithRealize();\nMethodWithRealize");
        }

        string this[string index] { get; set; }//индексаторы
        string this[int index] { get { return "Indexator"; } set { AutoProperty = value; } }//индексаторы c реализацией

        event EventHandler MyEvent1;//события
        event EventHandler MyEvent2 { add { } remove { } }//события c реализацией

        const int MYCONST = 25;//костанты

        //static A operator ++(A a) { return new A(); }//Ошибка

        //string name;//поля нельзя

    }
}
