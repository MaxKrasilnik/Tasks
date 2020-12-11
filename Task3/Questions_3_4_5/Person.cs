using System;
using System.Collections.Generic;
using System.Text;

namespace Questions_3_4_5
{
    public partial class Person
    {
        partial void DoSomethingElse();

        public string Name { get; set; }

        public void DoSomething()
        {
            Console.WriteLine("Start");
            DoSomethingElse();
            Console.WriteLine("Finish");
        }

        public void Show()
        {
            Console.WriteLine($"Hello! I'm {Name}. "+MyJob());

            string MyJob()
            {
                return "I'm programmer.";
            }
        }

    }



    public partial class Person
    {
        partial void DoSomethingElse()
        {
            Console.WriteLine("I am reading a book");
        }
    }
}
