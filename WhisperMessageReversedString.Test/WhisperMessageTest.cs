using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhisperMessageReversedString;
using WhisperMessageReversedStringCLib;

namespace WhisperMessageReversedString.Test
{
    [TestClass]
    public class WhisperMessageTest
    {
        private IWhisperMessageReversedString _whisperReversed = new ReversedString();

        [TestMethod]
        public void WhisperMessageReversedStringTest()
        {
            //Arrange
            string value = "Hallon på dig";
            string expected = "Nollah åp gid";

            //Act
            string actual = _whisperReversed.WhisperReversedString(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void WhisperMessageReversedStringArgumentAxception()
        {
            //Arrange
            string value = "";
            
            //Act
            string actual = _whisperReversed.WhisperReversedString(value);

            //Assert
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void WhisperMessagReversedStringArgumentNullException()
        {
            //Arrange
            string value = null;

            //Act
            string actual = _whisperReversed.WhisperReversedString(value);

            //Assert
        }
    }
}
