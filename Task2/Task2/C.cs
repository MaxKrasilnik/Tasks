using System;
using System.Collections.Generic;
using System.Text;

namespace ReadonlyStruct
{
    public readonly struct C
    {
        public C(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public double _a { get; }
        public double _b { get; }

        public override string ToString() => $"({_a}, {_b})";
    }
}
