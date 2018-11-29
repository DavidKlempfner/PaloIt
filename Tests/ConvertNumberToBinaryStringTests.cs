using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaloItChallenge.Helpers;

namespace Tests
{
    [TestClass]
    public class ConvertNumberToBinaryStringTests
    {
        [TestMethod]
        public void GivenNumExpectCorrectBinaryString()
        {
            //Arrange
            const int num = 8;
            const string expectedBinaryString = "1000";

            //Act
            string binaryString = AsciiHelper.ConvertNumToBinaryString(num);

            //Assert
            Assert.AreEqual(expectedBinaryString, binaryString);
        }
    }
}
