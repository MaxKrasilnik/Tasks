using System;

namespace Delegates
{
    class Program
    {
        //delegate void Action<T>(T obj);
        //delegate T Predicate<T>();
        //delegate TResult Func<in T, out TResult>(T arg);

        static void MyAction(string str)
        {
            Console.WriteLine("MyAction" + str);
        }

        static void MyAction2(string str)
        {
            Console.WriteLine("MyAction2" + str);
        }

        static void MyAction3(string str)
        {
            Console.WriteLine("MyAction3" + str);
        }

        delegate void MyNewDelegate(int x, int y);

        static void ForMyNewDelegate(int x, int y)
        {
            Console.WriteLine("ForMyNewDelegate. -> x+y="+(x+y));
        }

        static int MyFunc(int x)
        {
            Console.WriteLine("MyFunc");
            Console.WriteLine("x="+ x);
            return x;
        }

        static void Main(string[] args)
        {
            Action<string> action;
            action = MyAction;
            action(" hello!!!");
            Console.WriteLine();

            action += MyAction2;
            action += MyAction3;
            action(" plus two actions");
            Console.WriteLine();

            action -= MyAction2;
            action(" without second action");
            Console.WriteLine();

            Predicate<int> predicate = delegate (int x) { return x > 0; };
            Console.WriteLine("predicate(2); -> "+ predicate(2));
            Console.WriteLine("predicate(-2); -> " + predicate(-2));
            Console.WriteLine();

            Func<int, int> func;
            func = MyFunc;
            int x = func(5);
            Console.WriteLine("Main");
            Console.WriteLine("x=" + x);
            Console.WriteLine();

            MyNewDelegate myNewDelegate = ForMyNewDelegate;
            myNewDelegate(1, 2);
            

        }


    }
}
