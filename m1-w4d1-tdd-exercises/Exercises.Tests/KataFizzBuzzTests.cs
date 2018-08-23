using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises;

namespace Exercises.Tests
{
    [TestClass()]
    public class KataFizzBuzzTests
    {
        KataFizzBuzz fizzBuzz;

        
        [TestInitialize]
        public void Initialize()
        {
            fizzBuzz = new KataFizzBuzz();
        }

        // PART 1
        //[TestMethod]
        //public void NoFizzBuzzResultTests()
        //{
        //    Assert.AreEqual("1", fizzBuzz.FizzBuzz(1), "WRONGWRONGWRONGWRONG");
        //    Assert.AreEqual("37", fizzBuzz.FizzBuzz(37), "Wrong");
        //    Assert.AreEqual("44", fizzBuzz.FizzBuzz(44), "Wrong");
        //}

        //[TestMethod]
        //public void FizzResultTests()
        //{
        //    Assert.AreEqual("Fizz", fizzBuzz.FizzBuzz(3), "no");
        //    Assert.AreEqual("Fizz", fizzBuzz.FizzBuzz(12), "no");
        //    Assert.AreEqual("Fizz", fizzBuzz.FizzBuzz(33), "no");
        //}

        //[TestMethod]
        //public void BuzzResultTests()
        //{
        //    Assert.AreEqual("Buzz", fizzBuzz.FizzBuzz(5), "no");
        //    Assert.AreEqual("Buzz", fizzBuzz.FizzBuzz(35), "no");
        //    Assert.AreEqual("Buzz", fizzBuzz.FizzBuzz(50), "no");
        //}

        //[TestMethod]
        //public void FizzBuzzResultTests()
        //{
        //    Assert.AreEqual("FizzBuzz", fizzBuzz.FizzBuzz(15), "");
        //    Assert.AreEqual("FizzBuzz", fizzBuzz.FizzBuzz(30), "");
        //    Assert.AreEqual("FizzBuzz", fizzBuzz.FizzBuzz(90), "");
        //}

        //[TestMethod]
        //public void IncorrectCases()
        //{
        //    Assert.AreEqual("Invalid", fizzBuzz.FizzBuzz(101), "");
        //    Assert.AreEqual("Invalid", fizzBuzz.FizzBuzz(0), "");
        //    Assert.AreEqual("Invalid", fizzBuzz.FizzBuzz(-12), "");
        //}

        // PART 2
        [TestMethod]
        public void NoFizzBuzzResultTests()
        {
            Assert.AreEqual("1", fizzBuzz.FizzBuzz(1), "WRONGWRONGWRONGWRONG");
            Assert.AreEqual("77", fizzBuzz.FizzBuzz(77), "Wrong");
            Assert.AreEqual("44", fizzBuzz.FizzBuzz(44), "Wrong");
        }

        [TestMethod]
        public void FizzResultTests()
        {
            Assert.AreEqual("Fizz", fizzBuzz.FizzBuzz(3), "no");
            Assert.AreEqual("Fizz", fizzBuzz.FizzBuzz(12), "no");
            Assert.AreEqual("Fizz", fizzBuzz.FizzBuzz(33), "no");
            Assert.AreEqual("Fizz", fizzBuzz.FizzBuzz(31), "no");
            Assert.AreEqual("Fizz", fizzBuzz.FizzBuzz(38), "no");
            Assert.AreEqual("Fizz", fizzBuzz.FizzBuzz(23), "23 isn't working");
        }

        [TestMethod]
        public void BuzzResultTests()
        {
            Assert.AreEqual("Buzz", fizzBuzz.FizzBuzz(5), "test 1");
            Assert.AreEqual("Buzz", fizzBuzz.FizzBuzz(85), "test 2");
            Assert.AreEqual("Buzz", fizzBuzz.FizzBuzz(50), "test 3");
            Assert.AreEqual("Buzz", fizzBuzz.FizzBuzz(52), "test 4");
            Assert.AreEqual("Buzz", fizzBuzz.FizzBuzz(58), "test 5");
        }

        [TestMethod]
        public void FizzBuzzResultTests()
        {
            Assert.AreEqual("FizzBuzz", fizzBuzz.FizzBuzz(15), "");
            Assert.AreEqual("FizzBuzz", fizzBuzz.FizzBuzz(30), "");
            Assert.AreEqual("FizzBuzz", fizzBuzz.FizzBuzz(90), "");
        }

        [TestMethod]
        public void IncorrectCases()
        {
            Assert.AreEqual("Invalid", fizzBuzz.FizzBuzz(101), "");
            Assert.AreEqual("Invalid", fizzBuzz.FizzBuzz(0), "");
            Assert.AreEqual("Invalid", fizzBuzz.FizzBuzz(-12), "");
        }
    }
}
