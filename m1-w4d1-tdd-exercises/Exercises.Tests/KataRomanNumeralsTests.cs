using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class KataRomanNumeralsTests
    {
        KataRomanNumerals kata = new KataRomanNumerals();

        [TestMethod]
        public void TestConvert1toI()
        {
            Assert.AreEqual("I", kata.ConvertToRomanNumeral(1));
        }

        [TestMethod]
        public void TestConvert3ToIII()
        {
            Assert.AreEqual("III", kata.ConvertToRomanNumeral(3));
        }

        [TestMethod]
        public void TestConvert4ToIV()
        {
            Assert.AreEqual("IV", kata.ConvertToRomanNumeral(4));
        }

        [TestMethod]
        public void TestConvert5ToV()
        {
            Assert.AreEqual("V", kata.ConvertToRomanNumeral(5));
        }

        [TestMethod]
        public void TestConvert7ToVII()
        {
            Assert.AreEqual("VII", kata.ConvertToRomanNumeral(7));
        }

        [TestMethod]
        public void TestConvert9ToIX()
        {
            Assert.AreEqual("IX", kata.ConvertToRomanNumeral(9));
        }

        [TestMethod]
        public void TestConvert13ToXIII()
        {
            Assert.AreEqual("XIII", kata.ConvertToRomanNumeral(13));
        }

        [TestMethod]
        public void TestConvert14ToXIV()
        {
            Assert.AreEqual("XIV", kata.ConvertToRomanNumeral(14));
        }

        [TestMethod]
        public void TestConvert15ToXV()
        {
            Assert.AreEqual("XV", kata.ConvertToRomanNumeral(15));
        }

        [TestMethod]
        public void TestConvert18ToXVIII()
        {
            Assert.AreEqual("XVIII", kata.ConvertToRomanNumeral(18));
        }

        [TestMethod]
        public void TestConvert20ToXX()
        {
            Assert.AreEqual("XX", kata.ConvertToRomanNumeral(20));
        }

        [TestMethod]
        public void TestConvert37ToXXXVII()
        {
            Assert.AreEqual("XXXVII", kata.ConvertToRomanNumeral(37));
        }

        [TestMethod]
        public void TestConvert52ToLII()
        {
            Assert.AreEqual("LII", kata.ConvertToRomanNumeral(52));
        }

        [TestMethod]
        public void TestConvert72ToLXXII()
        {
            Assert.AreEqual("LXXII", kata.ConvertToRomanNumeral(72));
        }

        [TestMethod]
        public void TestConvert90ToXL()
        {
            Assert.AreEqual("XC", kata.ConvertToRomanNumeral(90));
        }

        [TestMethod]
        public void TestConvert127ToCXXVII()
        {
            Assert.AreEqual("CXXVII", kata.ConvertToRomanNumeral(127));
        }

        [TestMethod]
        public void TestConvert152ToCLII()
        {
            Assert.AreEqual("CLII", kata.ConvertToRomanNumeral(152));
        }

        [TestMethod]
        public void TestConvert193ToCXCII()
        {
            Assert.AreEqual("CXCII", kata.ConvertToRomanNumeral(193));
        }

    }
}
