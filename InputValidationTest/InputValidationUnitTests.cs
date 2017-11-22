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
        public void Test_IsNameValid_CanHandleNullInput()
        {
            // Arrange 
            string testInput = null;
            bool expected = false;

            // Act  
            bool control = RegexValidation.IsNameValid(testInput);

            // Assert 
            Assert.AreEqual(expected, control);
        }

        [TestMethod]
        public void Test_IsNameValid_CanAcceptWriteSigns()
        {
            // Arrange 
            string testInput = "firstName $!%/";
            bool expected = false;

            // Act  
            bool control = RegexValidation.IsNameValid(testInput);

            // Assert 
            Assert.AreEqual(expected, control);
        }

        [TestMethod]
        public void Test_IsNameValid_CanAcceptNumbers()
        {
            // Arrange 
            string testInput = "firstName 12345";
            bool expected = false;

            // Act  
            bool control = RegexValidation.IsNameValid(testInput);

            // Assert 
            Assert.AreEqual(expected, control);
        }

        [TestMethod]
        public void Test_IsNameValid_CanAcceptOneSyllable()
        {
            // Arrange 
            string testInput = "firstName";
            bool expected = false;

            // Act  
            bool control = RegexValidation.IsNameValid(testInput);

            // Assert 
            Assert.AreEqual(expected, control);
        }

        #endregion

        #region IsPhoneValid method tests

        [TestMethod]
        public void Test_IsPhoneValid_CanHandleNullInput()
        {
            // Arrange
            string testInput = null;
            bool expected = false;

            // Act
            bool control = RegexValidation.IsPhoneValid(testInput);

            // Assert
            Assert.AreEqual(expected, control);
        }

        [TestMethod]
        public void Test_IsPhoneValid_CanAcceptOtherThanNumbers()
        {
            // Arrange
            string testInput = "this isnt a phone number";
            bool expected = false;

            // Act
            bool control = RegexValidation.IsPhoneValid(testInput);

            // Assert
            Assert.AreEqual(expected, control);
        }

        [TestMethod]
        public void Test_IsPhoneValid_CanAcceptPhoneNumberWithoutCountryCode()
        {
            // Arrange
            string testInput = "30 986 6768";
            bool expected = false;

            // Act
            bool control = RegexValidation.IsPhoneValid(testInput);

            // Assert
            Assert.AreEqual(expected, control);
        }

        [TestMethod]
        public void Test_IsPhoneValid_CanAcceptPhoneNumberWithSpaces()
        {
            // Arrange
            string testInput = "+36 30 986 6768";
            bool expected = true;

            // Act
            bool control = RegexValidation.IsPhoneValid(testInput);

            // Assert
            Assert.AreEqual(expected, control);
        }

        [TestMethod]
        public void Test_IsPhoneValid_CanAcceptShorterPhoneNumber()
        {
            // Arrange
            string testInput = "+36 30 986";
            bool expected = false;

            // Act
            bool control = RegexValidation.IsPhoneValid(testInput);

            // Assert
            Assert.AreEqual(expected, control);
        }

        [TestMethod]
        public void Test_IsPhoneValid_CanAcceptLongerPhoneNumber()
        {
            // Arrange
            string testInput = "+36-30-986-67681111";
            bool expected = false;

            // Act
            bool control = RegexValidation.IsPhoneValid(testInput);

            // Assert
            Assert.AreEqual(expected, control);
        }

        [TestMethod]
        public void Test_IsPhoneValid_CanAcceptPhoneNumberWithHyphenSigns()
        {
            // Arrange
            string testInput = "+36-30-986-6768";
            bool expected = true;

            // Act
            bool control = RegexValidation.IsPhoneValid(testInput);

            // Assert
            Assert.AreEqual(expected, control);
        }

        [TestMethod]
        public void Test_IsPhoneValid_CanAcceptPhoneNumberWithSlashSigns()
        {
            // Arrange
            string testInput = "+36/30/986/6768";
            bool expected = true;

            // Act
            bool control = RegexValidation.IsPhoneValid(testInput);

            // Assert
            Assert.AreEqual(expected, control);
        }

        [TestMethod]
        public void Test_IsPhoneValid_CanAcceptPhoneNumberWithBackSlashSigns()
        {
            // Arrange
            string testInput = @"+36\30\986\6768";
            bool expected = false;

            // Act
            bool control = RegexValidation.IsPhoneValid(testInput);

            // Assert
            Assert.AreEqual(expected, control);
        }

        [TestMethod]
        public void Test_IsPhoneValid_CanAcceptPhoneNumberWithPlusSigns()
        {
            // Arrange
            string testInput = @"+36+30+986+6768";
            bool expected = false;

            // Act
            bool control = RegexValidation.IsPhoneValid(testInput);

            // Assert
            Assert.AreEqual(expected, control);
        }

        [TestMethod]
        public void Test_IsPhoneValid_CanAcceptPhoneNumberWithMultiplySigns()
        {
            // Arrange
            string testInput = @"+36*30*986*6768";
            bool expected = false;

            // Act
            bool control = RegexValidation.IsPhoneValid(testInput);

            // Assert
            Assert.AreEqual(expected, control);
        }

        #endregion

        #region IsEmailValid method tests

        [TestMethod]
        public void Test_IsEmailValid_CanHandleNullInput()
        {
            // Arrange
            string testInput = null;
            bool expected = false;

            // Act
            bool control = RegexValidation.IsEmailValid(testInput);

            // Assert
            Assert.AreEqual(expected, control);
        }

        [TestMethod]
        public void Test_IsEmailValid_CanAcceptUnvalidSignsInLocalPart()
        {
            // Arrange
            string testInput = @"gabee[1987]@gmail.com";
            bool expected = false;

            // Act
            bool control = RegexValidation.IsEmailValid(testInput);

            // Assert
            Assert.AreEqual(expected, control);
        }

        [TestMethod]
        public void Test_IsEmailValid_CanAccepValidSigns()
        {
            // Arrange
            string testInput = @"gabee+1987@gmail.com";
            bool expected = true;

            // Act
            bool control = RegexValidation.IsEmailValid(testInput);

            // Assert
            Assert.AreEqual(expected, control);
        }

        [TestMethod]
        public void Test_IsEmailValid_CanAcceptDotSeparatedLocalPart()
        {
            // Arrange
            string testInput = @"gabee.1987@gmail.com";
            bool expected = true;

            // Act
            bool control = RegexValidation.IsEmailValid(testInput);

            // Assert
            Assert.AreEqual(expected, control);
        }

        [TestMethod]
        public void Test_IsEmailValid_CanAcceptAddressWithoutAtSign()
        {
            // Arrange
            string testInput = @"gabee.1987gmail.com";
            bool expected = false;

            // Act
            bool control = RegexValidation.IsEmailValid(testInput);

            // Assert
            Assert.AreEqual(expected, control);
        }

        [TestMethod]
        public void Test_IsEmailValid_CanAcceptUnvalidSignInDomainPart()
        {
            // Arrange
            string testInput = @"gabee1987@gmail'unvalid'.com";
            bool expected = false;

            // Act
            bool control = RegexValidation.IsEmailValid(testInput);

            // Assert
            Assert.AreEqual(expected, control);
        }

        [TestMethod]
        public void Test_IsEmailValid_CanAcceptAddressWithoutDomainPart()
        {
            // Arrange
            string testInput = @"gabee1987@gmail";
            bool expected = false;

            // Act
            bool control = RegexValidation.IsEmailValid(testInput);

            // Assert
            Assert.AreEqual(expected, control);
        }

        [TestMethod]
        public void Test_IsEmailValid_CanAcceptAddressWithUnvalidDomainPart()
        {
            // Arrange
            string testInput = @"gabee1987@gmail.c";
            bool expected = false;

            // Act
            bool control = RegexValidation.IsEmailValid(testInput);

            // Assert
            Assert.AreEqual(expected, control);
        }

        [TestMethod]
        public void Test_IsEmailValid_CanAcceptAddressWithHyphenSeparatedDomainPart()
        {
            // Arrange
            string testInput = @"gabee1987@gmail.cc-com";
            bool expected = true;

            // Act
            bool control = RegexValidation.IsEmailValid(testInput);

            // Assert
            Assert.AreEqual(expected, control);
        }

        #endregion
    }
}
