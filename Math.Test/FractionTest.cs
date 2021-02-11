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
    }
}
