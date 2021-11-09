using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Euler;
using System.Collections.Generic;
using System.Numerics;

namespace Euler
{
    [TestClass]
    public class Euler14Tests
    {

        [TestMethod]
        public void TestMethod0()
        {
            var expected = 10;
            BigInteger results = Euler14.CalculateCallatz(13);
            Assert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestMethod1()
        {
            var expected = 837799;
            BigInteger results = Euler14.Run(1000000);
            Assert.AreEqual(expected, results);
        }
    }
}
