using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaloItChallenge.Helpers;

namespace Tests
{
    [TestClass]
    public class ConsecutiveZerosTests
    {
        [TestMethod]
        public void GivenBinaryStringWithRandomDistributionExpectCorrectMaxNumOfConsecutiveZeros()
        {
            //Arrange
            const string binaryStringWithRandomDistribution = "11000010101110001";
            const int expectedMaxNumOfConsecutiveZeros = 4;

            //Act
            int maxNumOfConsecutiveZeros = AsciiHelper.GetMaxNumOfConsecutiveZeros(binaryStringWithRandomDistribution);

            //Assert
            Assert.AreEqual(expectedMaxNumOfConsecutiveZeros, maxNumOfConsecutiveZeros);
        }

        [TestMethod]
        public void GivenBinaryStringWith0sAtEndExpectCorrectMaxNumOfConsecutiveZeros()
        {
            //Arrange
            const string binaryStringWithRandomDistribution = "111000000";
            const int expectedMaxNumOfConsecutiveZeros = 6;            

            //Act
            int maxNumOfConsecutiveZeros = AsciiHelper.GetMaxNumOfConsecutiveZeros(binaryStringWithRandomDistribution);

            //Assert
            Assert.AreEqual(expectedMaxNumOfConsecutiveZeros, maxNumOfConsecutiveZeros);
        }

        [TestMethod]
        public void GivenBinaryStringWith0sAtEndFollowedBy1ExpectCorrectMaxNumOfConsecutiveZeros()
        {
            //Arrange
            const string binaryStringWithRandomDistribution = "111000001";
            const int expectedMaxNumOfConsecutiveZeros = 5;

            //Act
            int maxNumOfConsecutiveZeros = AsciiHelper.GetMaxNumOfConsecutiveZeros(binaryStringWithRandomDistribution);

            //Assert
            Assert.AreEqual(expectedMaxNumOfConsecutiveZeros, maxNumOfConsecutiveZeros);
        }

        [TestMethod]
        public void GivenBinaryStringWith10AtEndExpectCorrectMaxNumOfConsecutiveZeros()
        {
            //Arrange
            const string binaryStringWithRandomDistribution = "11100000010";
            const int expectedMaxNumOfConsecutiveZeros = 6;

            //Act
            int maxNumOfConsecutiveZeros = AsciiHelper.GetMaxNumOfConsecutiveZeros(binaryStringWithRandomDistribution);

            //Assert
            Assert.AreEqual(expectedMaxNumOfConsecutiveZeros, maxNumOfConsecutiveZeros);
        }

        [TestMethod]
        public void GivenBinaryStringWithAll1sFollowedBy0ExpectCorrectMaxNumOfConsecutiveZeros()
        {
            //Arrange
            const string binaryStringWithRandomDistribution = "111111110";
            const int expectedMaxNumOfConsecutiveZeros = 1;

            //Act
            int maxNumOfConsecutiveZeros = AsciiHelper.GetMaxNumOfConsecutiveZeros(binaryStringWithRandomDistribution);

            //Assert
            Assert.AreEqual(expectedMaxNumOfConsecutiveZeros, maxNumOfConsecutiveZeros);
        }

        [TestMethod]
        public void GivenBinaryStringWith01AtEndExpectCorrectMaxNumOfConsecutiveZeros()
        {
            //Arrange
            const string binaryStringWithRandomDistribution = "1111111101";
            const int expectedMaxNumOfConsecutiveZeros = 1;

            //Act
            int maxNumOfConsecutiveZeros = AsciiHelper.GetMaxNumOfConsecutiveZeros(binaryStringWithRandomDistribution);

            //Assert
            Assert.AreEqual(expectedMaxNumOfConsecutiveZeros, maxNumOfConsecutiveZeros);
        }

        [TestMethod]
        public void GivenBinaryStringWith10AtStartExpectCorrectMaxNumOfConsecutiveZeros()
        {
            //Arrange
            const string binaryStringWithRandomDistribution = "10111111111";
            const int expectedMaxNumOfConsecutiveZeros = 1;

            //Act
            int maxNumOfConsecutiveZeros = AsciiHelper.GetMaxNumOfConsecutiveZeros(binaryStringWithRandomDistribution);

            //Assert
            Assert.AreEqual(expectedMaxNumOfConsecutiveZeros, maxNumOfConsecutiveZeros);
        }

        [TestMethod]
        public void GivenBinaryStringWithAll1sExpectCorrectMaxNumOfConsecutiveZeros()
        {
            //Arrange
            const string binaryStringWithRandomDistribution = "1111111111";
            const int expectedMaxNumOfConsecutiveZeros = 0;

            //Act
            int maxNumOfConsecutiveZeros = AsciiHelper.GetMaxNumOfConsecutiveZeros(binaryStringWithRandomDistribution);

            //Assert
            Assert.AreEqual(expectedMaxNumOfConsecutiveZeros, maxNumOfConsecutiveZeros);
        }

        [TestMethod]
        public void GivenBinaryStringWith10AtStartFollowedBy1sExpectCorrectMaxNumOfConsecutiveZeros()
        {
            //Arrange
            const string binaryStringWithRandomDistribution = "10111111111";
            const int expectedMaxNumOfConsecutiveZeros = 1;

            //Act
            int maxNumOfConsecutiveZeros = AsciiHelper.GetMaxNumOfConsecutiveZeros(binaryStringWithRandomDistribution);

            //Assert
            Assert.AreEqual(expectedMaxNumOfConsecutiveZeros, maxNumOfConsecutiveZeros);
        }

        [TestMethod]
        public void GivenBinaryStringWithJust1ExpectCorrectMaxNumOfConsecutiveZeros()
        {
            //Arrange
            const string binaryStringWithRandomDistribution = "1";
            const int expectedMaxNumOfConsecutiveZeros = 0;

            //Act
            int maxNumOfConsecutiveZeros = AsciiHelper.GetMaxNumOfConsecutiveZeros(binaryStringWithRandomDistribution);

            //Assert
            Assert.AreEqual(expectedMaxNumOfConsecutiveZeros, maxNumOfConsecutiveZeros);
        }

        [TestMethod]
        public void GivenBinaryStringWithJust0ExpectCorrectMaxNumOfConsecutiveZeros()
        {
            //Arrange
            const string binaryStringWithRandomDistribution = "0";
            const int expectedMaxNumOfConsecutiveZeros = 1;

            //Act
            int maxNumOfConsecutiveZeros = AsciiHelper.GetMaxNumOfConsecutiveZeros(binaryStringWithRandomDistribution);

            //Assert
            Assert.AreEqual(expectedMaxNumOfConsecutiveZeros, maxNumOfConsecutiveZeros);
        }

        [TestMethod]
        public void GivenBinaryStringWithTwo0sInMiddleExpectCorrectMaxNumOfConsecutiveZeros()
        {
            //Arrange
            const string binaryStringWithRandomDistribution = "1100111111";
            const int expectedMaxNumOfConsecutiveZeros = 2;

            //Act
            int maxNumOfConsecutiveZeros = AsciiHelper.GetMaxNumOfConsecutiveZeros(binaryStringWithRandomDistribution);

            //Assert
            Assert.AreEqual(expectedMaxNumOfConsecutiveZeros, maxNumOfConsecutiveZeros);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GivenEmptyBinaryStringExpectException()
        {
            //Arrange
            const string binaryStringWithRandomDistribution = "";

            //Act
            int maxNumOfConsecutiveZeros = AsciiHelper.GetMaxNumOfConsecutiveZeros(binaryStringWithRandomDistribution);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GivenInvalidiBinaryStringExpectCorrectException()
        {
            //Arrange
            const string binaryStringWithRandomDistribution = "asfger";

            //Act
            int maxNumOfConsecutiveZeros = AsciiHelper.GetMaxNumOfConsecutiveZeros(binaryStringWithRandomDistribution);
        }
    }
}
