using Main;
using MathLib;
using Moq;
using NUnit.Framework;

namespace Test
{
    public class HelpersTests
    {
        [Test]
        public void MagicNumberHelperSubtractTest()
        {
            int a = 3;  // chosen to take subtraction path
            int b = 1;
            int expected = 1234;

            // ARRANGE

            var mockMathLib = new Mock<IUtilMath>(MockBehavior.Strict);
            mockMathLib.Setup(m => m.Subtract(a, b)).Returns(expected); // just to illustrate that we can really return anything here, as long as we test for it

            // ACT

            var instance = new Helpers(mockMathLib.Object);
            int actual = instance.MagicNumberHelper(a, b);

            // ASSERT

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MagicNumberHelperMultiplyTest()
        {
            int a = 4;  // chosen to take multiply path
            int b = 1;
            int expected = 1234;

            // ARRANGE

            var mockMathLib = new Mock<IUtilMath>(MockBehavior.Strict);
            mockMathLib.Setup(m => m.Multiply(a, b)).Returns(expected); // just to illustrate that we can really return anything here, as long as we test for it

            // ACT

            var instance = new Helpers(mockMathLib.Object);
            int actual = instance.MagicNumberHelper(a, b);

            // ASSERT

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MagicNumberHelperDivideTest()
        {
            int a = 5;  // chosen to take divide path
            int b = 1;
            int expected = 1234;

            // ARRANGE

            var mockMathLib = new Mock<IUtilMath>(MockBehavior.Strict);
            mockMathLib.Setup(m => m.Divide(a, b)).Returns(expected); // just to illustrate that we can really return anything here, as long as we test for it

            // ACT

            var instance = new Helpers(mockMathLib.Object);
            int actual = instance.MagicNumberHelper(a, b);

            // ASSERT

            Assert.AreEqual(expected, actual);
        }

    }
}
