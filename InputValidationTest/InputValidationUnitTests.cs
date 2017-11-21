using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InputValidation;

namespace InputValidationTest
{
    [TestClass]
    public class InputValidationUnitTests
    {

        #region IsNameValid method tests

        [TestMethod]
        public void Test_IsNameValid_CanAcceptOtherThanLetters()
        {
            // Arrange 
            string testText = "firstName $!%/";
            bool expected = false;

            // Act  
            bool control = RegexValidation.IsNameValid(testText);

            // Assert 
            Assert.AreEqual(expected, control);
        }

        [TestMethod]
        public void Test_IsNameValid_CanAcceptOneSyllable()
        {
            // Arrange 
            string testText = "firstName";
            bool expected = false;

            // Act  
            bool control = RegexValidation.IsNameValid(testText);

            // Assert 
            Assert.AreEqual(expected, control);
        }

        [TestMethod]
        public void Test_IsNameValid_CanHandleNullInput()
        {
            // Arrange 
            string testText = null;
            bool expected = false;

            // Act  
            bool control = RegexValidation.IsNameValid(testText);

            // Assert 
            Assert.AreEqual(expected, control);
        }

        #endregion
    }
}
