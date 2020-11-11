using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactorialTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckIterativeFactorial_ResultCorrectness()
        {
            Tuple<long, long>[] testCases = {
                new Tuple<long, long>(Algorithms.FactorialIterative(6), 720),
                new Tuple<long, long>(Algorithms.FactorialIterative(3), 6),
                new Tuple<long, long>(Algorithms.FactorialIterative(5), 120),
                new Tuple<long, long>(Algorithms.FactorialIterative(7), 5040),
                new Tuple<long, long>(Algorithms.FactorialIterative(4), 24),
            };

            foreach (Tuple<long, long> testCase in testCases)
            {
                Assert.AreEqual(testCase.Item2, testCase.Item1, 0, "expected: " + testCase.Item2 + ", result: " + testCase.Item1);
            }
        }

        [TestMethod]
        public void CheckRecursiveFactorial_ResultCorrectness()
        {
            Tuple<long, long>[] testCases = {
                new Tuple<long, long>(Algorithms.FactorialRecursive(6), 720),
                new Tuple<long, long>(Algorithms.FactorialRecursive(3), 6),
                new Tuple<long, long>(Algorithms.FactorialRecursive(5), 120),
                new Tuple<long, long>(Algorithms.FactorialRecursive(7), 5040),
                new Tuple<long, long>(Algorithms.FactorialRecursive(4), 24),
            };

            foreach (Tuple<long, long> testCase in testCases)
            {
                Assert.AreEqual(testCase.Item2, testCase.Item1, 0, "expected: " + testCase.Item2 + ", result: " + testCase.Item1);
            }
        }

        [TestMethod]
        public void CheckRecurrentGCD_BelowZero()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Algorithms.Factorial(-1));
        }

    }
}
