using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass()]
    public class ExerciseTests
    {
        AnimalGroupName animalGroupName = new AnimalGroupName();
        [TestMethod()]
        public void AnimalGroupNameTests()
        {
            Assert.AreEqual("Tower", animalGroupName.GetHerd("giraffe"), "Wrong, result should be Tower");
            Assert.AreEqual("unknown", animalGroupName.GetHerd(""), "Wrong, result should be unknown");
            Assert.AreEqual("unknown", animalGroupName.GetHerd("walrus"), "Wrong, result should be unknown");
            Assert.AreEqual("Crash", animalGroupName.GetHerd("Rhino"), "Wrong, result should be Crash");
            Assert.AreEqual("Crash", animalGroupName.GetHerd("rhino"), "Wrong, result should be Crash");
            Assert.AreEqual("unknown", animalGroupName.GetHerd("elephants"), "Wrong, result should be unknown");
        }

        CigarParty cigarParty = new CigarParty();
        [TestMethod()]
        public void CigarPartyTests()
        {
            Assert.AreEqual(false, cigarParty.HaveParty(30, false), "Wrong");
            Assert.AreEqual(true, cigarParty.HaveParty(50, false), "Wrong");
            Assert.AreEqual(true, cigarParty.HaveParty(70, true), "Wrong");
        }

        Lucky13 lucky13 = new Lucky13();
        [TestMethod()]
        public void Lucky13Test()
        {
            Assert.AreEqual(true, lucky13.GetLucky(new int[] { 0, 2, 4 }), "Wrong");
            Assert.AreEqual(false, lucky13.GetLucky(new int[] { 1, 2, 3 }), "Wrong");
            Assert.AreEqual(false, lucky13.GetLucky(new int[] { 1, 2, 4 }), "Wrong");
        }

        MaxEnd3 maxEnd3 = new MaxEnd3();
        [TestMethod()]
        public void MaxEnd3Test()
        {
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, maxEnd3.MakeArray(new int[] { 1, 2, 3 }), "Wrong");
            CollectionAssert.AreEqual(new int[] { 11, 11, 11 }, maxEnd3.MakeArray(new int[] { 11, 5, 9 }), "Wrong");
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, maxEnd3.MakeArray(new int[] { 2, 11, 3 }), "Wrong");
        }

        NonStart nonStart = new NonStart();
        [TestMethod()]
        public void NonStartTest()
        {
            Assert.AreEqual("ellohere", nonStart.GetPartialString("Hello", "There"), "Just...wrong...");
            Assert.AreEqual("avaode", nonStart.GetPartialString("Java", "Code"), "Just...wrong...");
            Assert.AreEqual("hotlava", nonStart.GetPartialString("shotl", "java"), "Just...wrong...");
        }

        SameFirstLast sameFirstLast = new SameFirstLast();
        [TestMethod()]
        public void SameFirstLastTest()
        {
            Assert.AreEqual(false, sameFirstLast.IsItTheSame(new int[] {1, 2, 3}), "Sure, but nah");
            Assert.AreEqual(true, sameFirstLast.IsItTheSame(new int[] { 1, 2, 3, 1 }), "Sure, but nah");
            Assert.AreEqual(true, sameFirstLast.IsItTheSame(new int[] { 1, 2, 1 }), "Sure, but nah");
        }

        StringBits stringBits = new StringBits();
        [TestMethod()]
        public void StringBitsTest()
        {
            Assert.AreEqual("Hlo", stringBits.GetBits("Hello"), "You know you're wrong...");
            Assert.AreEqual("H", stringBits.GetBits("Hi"), "You know you're wrong...");
            Assert.AreEqual("Hello", stringBits.GetBits("Heeololeo"), "You know you're wrong...");
        }

        WordCount wordCount = new WordCount();
        [TestMethod()]
        public void WordCountTests()
        {
            CollectionAssert.AreEqual(new Dictionary<string, int>() { { "ba", 2 }, { "black", 1 }, { "sheep", 1 } }, wordCount.GetCount(new string[] { "ba", "ba", "black", "sheep" }), "Bloop");
            CollectionAssert.AreEqual(new Dictionary<string, int>() { { "a", 2 }, { "b", 2 }, { "c", 1 } }, wordCount.GetCount(new string[] { "a", "b", "a", "c", "b" }), "Boop");
            CollectionAssert.AreEqual(new Dictionary<string, int>(), wordCount.GetCount(new string[] { }), "Ploop");
            CollectionAssert.AreEqual(new Dictionary<string, int>() { { "c", 1 }, { "b", 1 }, { "a", 1 } }, wordCount.GetCount(new string[] { "c", "b", "a" }), "Oop");
        }
    }
}
