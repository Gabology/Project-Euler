using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem15;

namespace UnitTest
{
    [TestClass]
    public class GridPathTests
    {
        //Expected outputs
        // 2x2 = 6
        // 4x4 = 70
        // 10x10 = 184756
        // 15x15 = 155117520
        // 20x20 = 137846528820

        [TestMethod]
        public void Test2x2()
        {
            var target = new Problem15.Program();
            long expectedResults = 6;
            long actualResults = target.GetPaths(2);
            Assert.AreEqual<long>(expectedResults, actualResults);
        }

        [TestMethod]
        public void Test4x4()
        {
            var target = new Problem15.Program();
            long expectedResults = 70;
            long actualResults = target.GetPaths(4);
            Assert.AreEqual<long>(expectedResults, actualResults);
        }

        [TestMethod]
        public void Test10x10()
        {
            var target = new Problem15.Program();
            long expectedResults = 184756;
            long actualResults = target.GetPaths(10);
            Assert.AreEqual<long>(expectedResults, actualResults);
        }

        [TestMethod]
        public void Test15x15()
        {
            var target = new Problem15.Program();
            long expectedResults = 155117520;
            long actualResults = target.GetPaths(15);
            Assert.AreEqual<long>(expectedResults, actualResults);
        }

        [TestMethod]
        public void Test20x20()
        {
            var target = new Problem15.Program();
            long expectedResults = 137846528820;
            long actualResults = target.GetPaths(20);
            Assert.AreEqual<long>(expectedResults, actualResults);
        }
    }
}
