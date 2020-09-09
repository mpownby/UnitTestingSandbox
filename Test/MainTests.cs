using Main;
using MathLib;
using Moq;
using NUnit.Framework;

namespace Test
{
    public class MainTests
    {
        [Test]
        public void GetMagicNumberTest()
        {
            // arbitrary
            int a = 5;
            int b = 1;  // intentionally chosen so that the while loop in the method under test iterates a minimal amount of time (to make test simpler)
            int expected = 1234;

            // ARRANGE

            var mockHelpers = new Mock<IHelpers>(MockBehavior.Strict);
            mockHelpers.Setup(m => m.MagicNumberHelper(a, -a)).Returns(expected);   // we know from studying the method under test that the two parameters should be 'a' and '-a' at this point

            var mockMathLib = new Mock<IUtilMath>(MockBehavior.Strict);
            mockMathLib.Setup(m => m.Multiply(a, b)).Returns(a);    // we could actually multiply the result, or it's also fine to return whatever we want here if it makes our test easier

            // ACT

            var instance = new Program(mockHelpers.Object, mockMathLib.Object);
            int actual = instance.GetMagicNumber(a, b);

            // ASSERT

            Assert.AreEqual(expected, actual);            
        }
    }
}