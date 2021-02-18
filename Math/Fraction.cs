using System;
using System.Collections.Generic;
using System.Text;

namespace Math
{
    public class Fraction
    {
        // Property is a method disguised as a field/variable
        // Operator overloading: operator +-*/<< which disguises a method
       // many operators %<< >= ...should mimic the standard behavior
        private int n, d;

        public Fraction(int _n = 0, int _d = 1)
        {
            n = _n;
            d = _d;
        }
        public Fraction(Fraction that)
        {
            n = that.n;
            d = that.d;
        }
        public int GetN()
        {
            return n;
        }
        public int GetD()
        {
            return d;
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            return new Fraction(5, 4);
        }


        
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.n * f2.n, f1.d * f2.d);
        }
        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return f1.n * f2.d == f1.d * f2.n;
        }
        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return ! (f1 == f2); // do not reinvent the wheel
            // reuse reuse reuse
        }

        public double ToDouble()
        {
            return n / (double) d;
        }

        public static explicit operator int(Fraction f)
        {
            return f.n / f.d;
        }

        // operator- (2 operands f1-f2, -f1

        // Type cast operator

    }
}
