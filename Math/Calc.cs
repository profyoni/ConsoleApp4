using System;
using System.Threading;
using Humanizer;

namespace MathLibrary
{
    // Java enum is a _class_ where all enumerated values are like static constant instance of that class
    public enum Operation // is an int under the hood (int masquarding as something else..more readable and type safe)
    {
        Plus, Minus
    }

    // Effective C#
    enum Gender
    {
        Unknown = 0,
        Male = 10 ,
        Female = 20,
        Androgynous = 15,
    }

    class Person
    {
        private Gender g;
    }

    public class Calc
    {
        private Operation op;
        public static int Plus(int a, int b)
        {
            Operation op = (Operation) 1;
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
