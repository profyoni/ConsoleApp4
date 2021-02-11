using System;
using System.Globalization;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions.Common;
using Humanizer;

// Fluent Assertions
namespace Math.Test
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void Plus()
        {
            int sum = MathLibrary.Calc.Plus(2, 3);
            sum.Should().BeLessOrEqualTo(5).And.BeGreaterOrEqualTo(5);
        }

        [TestMethod]
        public void Minus()
        {
            int sum = MathLibrary.Calc.Minus(2, 3);
            Assert.AreEqual(-1, sum);
        }

        [TestMethod]
        public void MathInEnglish()
        {
            MathLibrary.Calc.MathInEnglish(2, 5, MathLibrary.Operation.Plus).Should().Be("two plus five equals seven");
        }



        [TestMethod]
        public void Hebrew()
        {
            1.ToWords(CultureInfo.GetCultureInfo("he-IL"))
                .Should().Be("אחת");
        }


        [TestMethod]
        public void LearningTest()
        {
            // if , else, while, do while, for
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                    goto myLabel;
                sum += i;
            }

            myLabel:
            sum.Should().Be(1);

            int[] list = {2, 5, 7, 12, 19};
            foreach (int i in list)
            {
                // not legal i = 0;
            }

            char c = 'A';
            switch (c)
            {
                case 'A':
                    c++;
                    break;
                case 'B':
                    c++;
                    return;
                case 'C':
                    break;
            }



        }

        class Bar // nested class - does not behave like a Java inner class
        {
            // behaves like a Java static inner clas
        }

        public void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
            x.Should().Be(2);
            y.Should().Be(1);
        }



        [TestMethod]
        public void LearningTest2()
        {
            int a = 1, b = 2;
            Swap(ref a, ref b);
            a.Should().Be(2);
            b.Should().Be(1);
        }

        void OutStub(int q, out int y, out string x)
        {
            y = q * 2;
            x = y + "";
        }
        double Foo(int mantissa, int exponent)
        {
            return System.Math.Pow(mantissa, exponent);
        }

        private readonly double TOLERANCE = 0.000001;


        [TestMethod]
        public void FooTestByName()
        {
            Foo(exponent: 3, mantissa: 2).Should().BeApproximately(8.0, TOLERANCE);
        }

        [TestMethod]
        public void OutStubTest()
        {
            int a=1, b;
            string c = "";
            OutStub(a,out b,out c);
            b.Should().Be(2);
            c.Should().Be("2");
        }

        [TestMethod]
        public void LearningTest3()
        {
            string s = "890p";
            int x;//= Convert.ToInt32(s);
            var success = Int32.TryParse(s, out x);
            if (success)
                x.Should().Be(890);
        }

        // class Foo
        // {
        //     // compile time values only need apply, may suffer in large interdependent projects
        //     private const String x = "f";
        //     private const DateTime dt = new DateTime(2020,2,3,18,48,0);
        //     const int secretNumber = 42; // use as a local variable or instance variable
        //     readonly double x1 = 3.14; //  ~ final // use as instance variable
        //   // Prefer readonly over const
        //     Foo(double d)
        //     {
        //         // Illegal secretNumber = 9;
        //         x1 = d; // may be set in ctor
        //     }
        //
        //     void Bar()
        //     {
        //       // Illegal  x1 = 9;
        //     }
        //
        //     void MyMethod()
        //     {
        //         int sum = secretNumber * 55 - 8;
        //         // etc
        //     }
        // }
    }
}
