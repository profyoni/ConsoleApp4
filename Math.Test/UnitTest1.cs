using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Math.Test
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void Add()
        {
            int sum = MathLibrary.Calc.Plus(2, 3);
            Assert.AreEqual(5, sum);
        }

        [TestMethod]
        public void Minus()
        {
            int sum = MathLibrary.Calc.Minus(2, 3);
            Assert.AreEqual(-1, sum);
        }
    }
}
