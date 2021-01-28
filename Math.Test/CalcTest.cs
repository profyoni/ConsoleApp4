using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions.Common;

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
            MathLibrary.Calc.MathInEnglish(2, 5, MathLibrary.Operation.Plus).Should().Be("two plus five equals seven"); }
    }
}
