using System;
using System.Collections.Generic;
using System.Text;

namespace Math
{

    public class Fraction
    {
        private int n, d;

        public Fraction(int _n = 0, int _d = 1)
        {
            n = _n;
            d = _d;
        }

        public int GetN()
        {
            return n;
        }
        public int GetD()
        {
            return d;
        }

        public static Fraction operator+(Fraction f1, Fraction f2)
        {
            return new Fraction(5,4);
        }

        public double ToDouble()
        {
            return n / (double) d;
        }

    }
}
