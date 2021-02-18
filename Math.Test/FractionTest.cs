using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Math.Test
{
    [TestClass]
    class FractionTest
    {

        [TestMethod]
        public void Fraction1()
        {
            var f = new Fraction(6);
            f.GetN().Should().Be(6);
            f.GetD().Should().Be(1);
        }


        [TestMethod]
        public void Fraction2()
        {
            var f = new Fraction();
            f.GetN().Should().Be(0);
            f.GetD().Should().Be(1);
        }

        [TestMethod]
        public void Fraction3()
        {
            var f1_2 = new Fraction(1, 2);
            var f3_4 = new Fraction(3, 4);

            var sum = f1_2 + f3_4;

            sum.ToDouble().Should().Be(1.25);
        }

        [TestMethod]
        public void operatorTimes()
        {
            var f1_2 = new Fraction(1, 2);
            var f3_4 = new Fraction(3, 4);

            var sum = f1_2 * f3_4;

            sum.ToDouble().Should().Be(.375);
        }

        [TestMethod]
        public void operatorEqualsTo()
        {
            var f1_2 = new Fraction(1, 2);
            var f3_4 = new Fraction(3, 4);

            var actual = f1_2 == f3_4;

            actual.Should().Be(false);
        }

        [TestMethod]
        public void operatorEqualsTo2()
        {
            var f1_2 = new Fraction(1, 2);
            var f2_4 = new Fraction(2, 4);

            var actual = f1_2 == f2_4;

            actual.Should().Be(true);
        }

        [TestMethod]
        public void operatorSetEquals()
        {
            var f1_2 = new Fraction(1, 2);
            var f2_3 = new Fraction(2, 3);

            f1_2 = new Fraction(f2_3); 

            f1_2.GetN().Should().Be(2);
            f1_2.GetD().Should().Be(3);

            f1_2.n = 88;

            f2_3.GetN().Should().Be(2);
            f2_3.GetD().Should().Be(3);
        }

        [TestMethod]
        public void operatorIntCast()
        {
            var f5_4 = new Fraction(5, 4);

            int x = (int) 8.4;
            double d = x;
            int actual = (int) f5_4;

            actual.Should().Be(1);

          //  double d1 = 45M;
          //  decimal d2 = 4.5;
        }

        // [TestMethod]
        // public void operatorIntCast()
        // {
        //     var f5_4 = new Fraction(5, 4);
        //
        //     var actual = (double)f5_4;
        //
        //     actual.Should().Be(1.25);
        // }

    }
}
