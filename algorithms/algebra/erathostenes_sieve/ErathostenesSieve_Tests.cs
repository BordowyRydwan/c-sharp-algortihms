using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ErathostenesSieveTests
{
    [TestClass]
    public class UnitTest1
    {
        public bool CompareLists(List<int> list1, List<int> list2)
        {
            if(list1.Count != list2.Count)
            {
                return false;
            }

            for(int i = 0; i < list1.Count; ++i)
            {
                if(list1[i] != list2[i])
                {
                    return false;
                }
            }

            return true;
        }

        [TestMethod]
        public void FindPrimesLowerThanN_Correctness()
        {
            Tuple<List<int>, List<int>>[] testCases = {
                new Tuple<List<int>, List<int>>(Algorithms.FindPrimesLowerThanN(7), new List<int>(){2, 3, 5}),
                new Tuple<List<int>, List<int>>(Algorithms.FindPrimesLowerThanN(10), new List<int>(){2, 3, 5, 7}),
                new Tuple<List<int>, List<int>>(Algorithms.FindPrimesLowerThanN(11), new List<int>(){2, 3, 5, 7}),
                new Tuple<List<int>, List<int>>(Algorithms.FindPrimesLowerThanN(16), new List<int>(){2, 3, 5, 7, 11, 13}),
                new Tuple<List<int>, List<int>>(Algorithms.FindPrimesLowerThanN(18), new List<int>(){2, 3, 5, 7, 11, 13, 17}),
            };

            foreach (Tuple<List<int>, List<int>> testCase in testCases)
            {
                Assert.AreEqual(true, CompareLists(testCase.Item1, testCase.Item2));
            }
        }

        [TestMethod]
        public void CheckIsPrime_Correctness()
        {
            Tuple<bool, bool>[] testCases = {
                new Tuple<bool, bool>(Algorithms.IsPrime(7), true),
                new Tuple<bool, bool>(Algorithms.IsPrime(21), false),
                new Tuple<bool, bool>(Algorithms.IsPrime(12320), false),
                new Tuple<bool, bool>(Algorithms.IsPrime(47), true),
                new Tuple<bool, bool>(Algorithms.IsPrime(9), false),
            };

            foreach (Tuple<bool, bool> testCase in testCases)
            {
                Assert.AreEqual(testCase.Item2, testCase.Item1);
            }
        }
    }
}
