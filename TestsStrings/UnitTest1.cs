using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;
using System.Reflection.Emit;
using SemanticComparison;
using RESTful_Service.Models;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Tests
{
    [TestClass]
    public class UnitTestOne
    {
        [TestMethod]
        public void ConcateTestMethodOne()
        {
            string stringOne = "Anton ";
            string stringTwo = "Semenchenko";
            string expected = "Anton Semenchenko";
            Strings strings = new Strings();
            strings._stringOne = stringOne;
            strings._stringTwo = stringTwo;

            string actual = strings.StringsConcat();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConcateTestMethodTwo()
        {
            string stringOne = "I love ";
            string stringTwo = "C#";
            string expected = "I love C#";
            Strings strings = new Strings();
            strings._stringOne = stringOne;
            strings._stringTwo = stringTwo;

            string actual = strings.StringsConcat();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReplaysTestMethodOne()
        {
            string stringOne = "C#";
            int replays = 3;
            string expected = "C#C#C#";
            Strings strings = new Strings();
            strings._stringOne = stringOne;
            strings._replaysCount = replays;

            string actual = strings.StringsReplay();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReplaysTestMethodTwo()
        {
            string stringOne = null;
            Strings strings = new Strings();
            strings._stringOne = stringOne;

            Assert.ThrowsException<ArgumentException>(() => strings.StringsReplay());
        }

        [TestMethod]
        public void ReplaysTestMethodThree()
        {
            int replays = -1;
            Strings strings = new Strings();
            strings._replaysCount = replays;

            Assert.ThrowsException<ArgumentException>(() => strings.StringsReplay());
        }
    }
}
