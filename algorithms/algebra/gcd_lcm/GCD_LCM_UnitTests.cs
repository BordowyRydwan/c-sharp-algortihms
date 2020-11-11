using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GCDTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckRecurrentGCD_ResultCorrectness()
        {
            Tuple<int, int>[] testCases = {
                new Tuple<int, int>(Algorithms.GCDRecursive(12, 9), 3),
                new Tuple<int, int>(Algorithms.GCDRecursive(21, 37), 1),
                new Tuple<int, int>(Algorithms.GCDRecursive(450, 36), 18),
                new Tuple<int, int>(Algorithms.GCDRecursive(12320, 33), 11),
                new Tuple<int, int>(Algorithms.GCDRecursive(23, 7), 1),
            };

            foreach(Tuple<int, int> testCase in testCases)
            {
                Assert.AreEqual(testCase.Item2, testCase.Item1, 0, "expected: " + testCase.Item2 + ", result: " + testCase.Item1);
            }
        }

        [TestMethod]
        public void CheckIterativeGCD_ResultCorrectness()
        {
            Tuple<int, int>[] testCases = {
                new Tuple<int, int>(Algorithms.GCDIterative(12, 9), 3),
                new Tuple<int, int>(Algorithms.GCDIterative(21, 37), 1),
                new Tuple<int, int>(Algorithms.GCDIterative(450, 36), 18),
                new Tuple<int, int>(Algorithms.GCDIterative(12320, 33), 11),
                new Tuple<int, int>(Algorithms.GCDIterative(23, 7), 1),
            };

            foreach (Tuple<int, int> testCase in testCases)
            {
                Assert.AreEqual(testCase.Item2, testCase.Item1, 0, "expected: " + testCase.Item2 + ", result: " + testCase.Item1);
            }
        }

        [TestMethod]
        public void CheckRecurrentGCD_TwoZerosSituation()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Algorithms.GCDRecursive(0, 0));
        }

        [TestMethod]
        public void CheckIterativeGCD_TwoZerosSituation()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Algorithms.GCDIterative(0, 0));
        }

        [TestMethod]
        public void CheckRecurrentGCD_NegativeArguments()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Algorithms.GCDRecursive(-2, -4));
        }

        [TestMethod]
        public void CheckIterativeGCD_NegativeArguments()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Algorithms.GCDIterative(-2, -4));
        }

        [TestMethod]
        public void CheckIterativeGCD_ArgumentPositionIndependence()
        {
            Assert.AreEqual(Algorithms.GCDRecursive(12, 9), Algorithms.GCDRecursive(9, 12), 0, "Result should not depend on args position");
        }
    }
}
