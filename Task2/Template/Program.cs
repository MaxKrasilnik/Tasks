using System;

namespace Template
{
    class MyClass { }
    struct MyStruct { }
    delegate void MyDelegate();

    class Template<T> where T : new()//https://forum.itvdn.com/t/chto-oznachaet-where-t-new/2432
    {
        public void Show()
        {
            Console.WriteLine("Hello");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Template<MyClass> template = new Template<MyClass>();
            template.Show();

            Template<MyStruct> template1 = new Template<MyStruct>();
            template1.Show();
        }
    }
}
