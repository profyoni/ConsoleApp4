using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Math.Test
{
    [TestClass]
    class BitOps
    {
        [TestMethod]
        public void Ops()
        {
            // | OR
            // & AND
            // ^ Exclusive OR
            // ~ Complement 
            // << Left Bit Shift
            // >> Right Bit Shift
            const uint APPLE = 0b_0000_0000_0000_0001;
            const uint PEAR = 0b_0000_0000_0000_0100;
            const uint ORANGE = 0b_0000_0010_0000_0000;
            ushort x1 = 0b_0000_0000_0000_0101;
            uint x2 = 0b_0000_0110;
            uint x3 = x1 + x2;
            x3.Should().Be(11);
            uint x4 = x1 - x2;
            x4.Should().Be(UInt32.MaxValue);

            (x1 & x2).Should().Be(0b_0000_0100);
            (x1 | x2).Should().Be(0b_0000_0111);
            (x1 ^ x2).Should().Be(0b_0000_0011);
            ((ushort)~x1).Should().Be(0b_1111_1111_1111_1010);
            // ==
            x1 = 0b_0000_0001; 
            x1 = (ushort)(x1 << 5); // 0b_000_0000_0101_0000_0;
            x1.Should().Be(32); // compilers x=x*16, will convert mult to left bit shift 4

            uint fruitBits = 0;
            fruitBits |= APPLE;
            fruitBits |= ORANGE;

            ((fruitBits & ORANGE) == ORANGE).Should().Be(true);
            ((fruitBits & PEAR) == PEAR).Should().Be(false);

            (-3 >> 1).Should().Be(-2);// 1111_1101 => 1111_1110 
        }
    }
}
