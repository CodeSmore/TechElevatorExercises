using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;
using System.Collections.Generic;

namespace Exercises.Tests
{
    /* OPTIONAL */
    [TestClass]
    public class KataPrimeFactorsTests
    {
        KataPrimeFactors KPF;
        List<int> testList;
        List<int> otherList;

        [TestInitialize]
        public void TestInitialization()
        {
            KPF = new KataPrimeFactors();
        }

        [TestMethod]
        public void TestOne()
        {
            // Test 1
            testList = new List<int>() { 2 };
            otherList = KPF.Factorize(2);

            for (int i = 0; i < testList.Count; ++i)
            {
                Assert.AreEqual(testList[i], otherList[i], "Test 1." + i);
            }

        }

        [TestMethod]
        public void TestTwo()
        {
            // Test 2
            testList = new List<int> { 3 };
            otherList = KPF.Factorize(3);

            for (int i = 0; i < testList.Count; ++i)
            {
                Assert.AreEqual(testList[i], otherList[i], "Test 2." + i);
            }
        }

        [TestMethod]
        public void TestThree()
        {
            // Test 3
            testList = new List<int> { 2, 2 };
            otherList = KPF.Factorize(4);

            for (int i = 0; i < testList.Count; ++i)
            {
                Assert.AreEqual(testList[i], otherList[i], "Test 3." + i);
            }
        }

        [TestMethod]
        public void TestFour()
        {
            // Test 4
            testList = new List<int> { 2, 5 };
            otherList = KPF.Factorize(10);

            for (int i = 0; i < testList.Count; ++i)
            {
                Assert.AreEqual(testList[i], otherList[i], "Test 4." + i);
            }
        }

        [TestMethod]
        public void TestFive()
        {
            // Test 5
            testList = new List<int> { 7 };
            otherList = KPF.Factorize(7);

            for (int i = 0; i < testList.Count; ++i)
            {
                Assert.AreEqual(testList[i], otherList[i], "Test 5." + i);
            }
        }

        [TestMethod]
        public void TestSix()
        {
            // Test 6
            testList = new List<int> { 2, 2, 2 };
            otherList = KPF.Factorize(8);

            for (int i = 0; i < testList.Count; ++i)
            {
                Assert.AreEqual(testList[i], otherList[i], "Test 6." + i);
            }
        }

        [TestMethod]
        public void TestSeven()
        {
            // test 7
            testList = new List<int> { 3, 3 };
            otherList = KPF.Factorize(9);

            for (int i = 0; i < testList.Count; ++i)
            {
                Assert.AreEqual(testList[i], otherList[i], "test 7." + i);
            }
        }
    }
}
