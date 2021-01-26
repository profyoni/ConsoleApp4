using System;
using System.Threading;

namespace MathLibrary
{
    public class Calc
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return Plus(a, -b);
        }
    }
}
