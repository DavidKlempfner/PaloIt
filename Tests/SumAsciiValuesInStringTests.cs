using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaloItChallenge.Helpers;

namespace Tests
{
    [TestClass]
    public class SumAsciiValuesInStringTests
    {
        [TestMethod]
        public void GivenStringExpectCorrectAsciiValueSum()
        {
            //Arrange
            const string name = "Dave Kay";
            const int expectedAsciiValueSum = 709;

            //Act
            int sumOfAsciiValues = AsciiHelper.SumAsciiValuesInString(name);

            //Assert
            Assert.AreEqual(expectedAsciiValueSum, sumOfAsciiValues);
        }
    }
}
