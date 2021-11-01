using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Euler;

namespace Euler
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod0()
        {
            var expected = 28;
            long results = Euler12.Run(5);
            Assert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestMethod1()
        {
            var expected = 76576500;
            long results = Euler12.Run(500);
            Assert.AreEqual(expected, results);
        }
    }
}
