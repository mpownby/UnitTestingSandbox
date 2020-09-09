using MathLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class MathLibTests
    {
        [Test]
        public void TestAdd()
        {
            var instance = new UtilMath();
            Assert.AreEqual(10, instance.Add(2, 8));
        }

        [Test]
        public void TestSubtract()
        {
            var instance = new UtilMath();
            Assert.AreEqual(10, instance.Subtract(22, 12));
        }

        [Test]
        public void TestMultiply()
        {
            var instance = new UtilMath();
            Assert.AreEqual(100, instance.Multiply(4, 25));
        }

        [Test]
        public void TestDivide()
        {
            var instance = new UtilMath();
            Assert.AreEqual(4, instance.Divide(100, 25));
        }

    }
}
