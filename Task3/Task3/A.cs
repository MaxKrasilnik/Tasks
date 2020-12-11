using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    abstract class A : IA
    {
        public abstract string this[string index] { get; set; }

        public abstract string AutoProperty { get; set; }

        public abstract event EventHandler MyEvent1;

        public abstract void Method();
        public abstract void Show();
    }
}
