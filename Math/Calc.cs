using System;
using System.Threading;
using Humanizer;

namespace MathLibrary
{
    public enum Operation
    {
        Plus, Minus
    }

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

        public static string MathInEnglish(int a, int b, Operation op)
        {
            String opEnglish = ToEnglish(op);
           
            return $"{a.ToWords()} {opEnglish} {b.ToWords()} equals {Plus(a, b).ToWords()}";
        }

        private static string ToEnglish(Operation op)
        {
            return new string []{ "plus", "minus" , "Op error" }[(int)op];
        }

        //            decimal d = 56.76M;
        //String s = @"C:\\filedir2\\file.txt"; //verbatim string..does not allow escape
        //  String s = $"You have in the bank {d:C}";
    }
}
