using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class B : A
    {
        public override void Show()
        {
            Console.WriteLine("Show in class B");
        }

        public override void Method()
        {
            Console.WriteLine("Method in class B");
        }

        string[] arr = new string[1];

        public override event EventHandler MyEvent1;

        public override string AutoProperty { get; set; }

        public override string this[string index]
        {
            get => arr[0];
            set => arr[0] = value;
        }

        public string this[int s]
        {
            get => arr[s];
            set => arr[s] = value;
        }
    }
}
