using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class KataPotterTests
    {
        KataPotter kataPotter;
        int[] inputArray;

        [TestInitialize]
        public void Initialize()
        {
            kataPotter = new KataPotter();
            inputArray = new int[] { 0, 0, 0, 0, 0 };
        }

        [TestMethod]
        public void SingleBookPurchaseTests()
        {

            inputArray[0] = 1;
            Assert.AreEqual(8M, kataPotter.GetCost(inputArray), "Test 1.1");

            inputArray[0] = 0;
            inputArray[1] = 1;
            Assert.AreEqual(8M, kataPotter.GetCost(inputArray), "Test 1.2");

            inputArray[1] = 0;
            inputArray[2] = 1;
            Assert.AreEqual(8M, kataPotter.GetCost(inputArray), "Test 1.3");

            inputArray[2] = 0;
            inputArray[3] = 1;
            Assert.AreEqual(8M, kataPotter.GetCost(inputArray), "Test 1.4");

            inputArray[3] = 0;
            inputArray[4] = 1;
            Assert.AreEqual(8M, kataPotter.GetCost(inputArray), "Test 1.5");
        }

        [TestMethod]
        public void MultipleBooksSameTitleTests()
        {
            inputArray[0] = 3;

            Assert.AreEqual(24M, kataPotter.GetCost(inputArray), "Test 2.1");

            inputArray[0] = 0;
            inputArray[1] = 2;
            Assert.AreEqual(16M, kataPotter.GetCost(inputArray), "Test 2.2");

            inputArray[1] = 0;
            inputArray[2] = 4;
            Assert.AreEqual(32M, kataPotter.GetCost(inputArray), "Test 2.3");

            inputArray[2] = 0;
            inputArray[3] = 5;
            Assert.AreEqual(40M, kataPotter.GetCost(inputArray), "Test 2.4");

            inputArray[3] = 0;
            inputArray[4] = 0;
            Assert.AreEqual(0M, kataPotter.GetCost(inputArray), "Test 2.5");

        }

        [TestMethod]
        public void MultipleBooksNoDuplicatesTests()
        {
            inputArray = new int[] { 1, 1, 1, 1, 1 };

            Assert.AreEqual(30M, kataPotter.GetCost(inputArray), "Test 3.1");

            inputArray[3] = 0;
            Assert.AreEqual(25.6M, kataPotter.GetCost(inputArray), "Test 3.2");

            inputArray[0] = 0;
            Assert.AreEqual(21.6M, kataPotter.GetCost(inputArray), "Test 3.3");

            inputArray[4] = 0;
            Assert.AreEqual(15.2M, kataPotter.GetCost(inputArray), "Test 3.4");

            inputArray[2] = 0;
            Assert.AreEqual(8M, kataPotter.GetCost(inputArray), "Test 3.5");
        }

        [TestMethod]
        public void MultipleBooksDuplicatesTests()
        {
            inputArray = new int[] { 1, 2, 3, 4, 5};
            Assert.AreEqual(100M, kataPotter.GetCost(inputArray), "Test 4.1");

            inputArray = new int[] { 2, 0, 2, 3, 1 };
            Assert.AreEqual(55.2M, kataPotter.GetCost(inputArray), "Test 4.2");

            inputArray = new int[] { 1, 2, 1, 1, 1 };
            Assert.AreEqual(38M, kataPotter.GetCost(inputArray), "Test 4.3");

            inputArray = new int[] { 2, 2, 2, 2, 1};
            Assert.AreEqual(55.6M, kataPotter.GetCost(inputArray), "Test 4.4");

            inputArray = new int[] { 2, 2, 0, 0, 0};
            Assert.AreEqual(30.4M, kataPotter.GetCost(inputArray), "Test 4.5");
        }

        [TestMethod]
        public void CostEffectiveModelTests()
        {
            inputArray = new int[] { 2, 2, 2, 1, 1 };
            Assert.AreEqual(51.2M, kataPotter.GetCost(inputArray), "Test 5.0");
        }
    }
}
