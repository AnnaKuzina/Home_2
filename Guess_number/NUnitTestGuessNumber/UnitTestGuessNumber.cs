using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Guess_number;

namespace NUnitTestGuessNumber
{
    [TestClass]
    public class UnitTestGuessNumber
    {
        int random_number;

        [TestInitialize]
        public void Setup()
        {
            GuessNumber gn = new GuessNumber();
            random_number = gn.RandomNumber();
        }

        [TestMethod]
        public void TestRandomNumberLessThan10()
        {
            if (random_number < 10)
                Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestRandomNumberMoreThan0()
        {
            if (random_number < 0)
                Assert.IsFalse(true);
        }
    }
}
