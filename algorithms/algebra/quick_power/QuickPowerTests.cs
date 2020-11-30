using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckNaivePower_Correctness()
        {
            Tuple<int, int>[] testCases = {
                new Tuple<int, int>(Algorithms.PowerNaive(4, 2), 16),
                new Tuple<int, int>(Algorithms.PowerNaive(1, 0), 1),
                new Tuple<int, int>(Algorithms.PowerNaive(30, 2), 900),
                new Tuple<int, int>(Algorithms.PowerNaive(3, 4), 81),
                new Tuple<int, int>(Algorithms.PowerNaive(10, 6), 1000000),
            };

            foreach (Tuple<int, int> testCase in testCases)
            {
                Assert.AreEqual(testCase.Item2, testCase.Item1, 0, "expected: " + testCase.Item2 + ", result: " + testCase.Item1);
            }
        }

        [TestMethod]
        public void CheckRecursivePower_Correctness()
        {
            Tuple<int, int>[] testCases = {
                new Tuple<int, int>(Algorithms.PowerRecursive(4, 2), 16),
                new Tuple<int, int>(Algorithms.PowerRecursive(1, 0), 1),
                new Tuple<int, int>(Algorithms.PowerRecursive(30, 2), 900),
                new Tuple<int, int>(Algorithms.PowerRecursive(3, 4), 81),
                new Tuple<int, int>(Algorithms.PowerRecursive(10, 6), 1000000),
            };

            foreach (Tuple<int, int> testCase in testCases)
            {
                Assert.AreEqual(testCase.Item2, testCase.Item1, 0, "expected: " + testCase.Item2 + ", result: " + testCase.Item1);
            }
        }

        [TestMethod]
        public void CheckIterativePower_Correctness()
        {
            Tuple<int, int>[] testCases = {
                new Tuple<int, int>(Algorithms.PowerIterative(4, 2), 16),
                new Tuple<int, int>(Algorithms.PowerIterative(1, 0), 1),
                new Tuple<int, int>(Algorithms.PowerIterative(30, 2), 900),
                new Tuple<int, int>(Algorithms.PowerIterative(3, 4), 81),
                new Tuple<int, int>(Algorithms.PowerIterative(10, 6), 1000000),
            };

            foreach (Tuple<int, int> testCase in testCases)
            {
                Assert.AreEqual(testCase.Item2, testCase.Item1, 0, "expected: " + testCase.Item2 + ", result: " + testCase.Item1);
            }
        }
    }
}
