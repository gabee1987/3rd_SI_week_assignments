using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InputValidation;

namespace InputValidationTest
{
    [TestClass]
    public class InputValidationUnitTests
    {

        #region IsNameValid method tests

        // Standard cases
        [TestMethod]
        public void Test_IsNameValid_Can_Accept_Normal_FirstName_FamilyName_Combination_Separated_By_Space()
        {
            // Arrange 
            string testInput = "FirstName FamilyName";
            bool expected = true;

            // Act  
            bool control = RegexValidation.IsNameValid(testInput);

            // Assert 
            Assert.AreEqual(expected, control);
        }

        // Boundary cases
        [TestMethod]
        public void Test_IsNameValid_Can_Accept_One_Syllable()
        {
            // Arrange 
            string testInput = "FirstName";
            bool expected = false;

            // Act  
            bool control = RegexValidation.IsNameValid(testInput);

            // Assert 
            Assert.AreEqual(expected, control);
        }

        // Boundary cases
        [TestMethod]
        public void Test_IsNameValid_Can_Accept_Normal_FirstName_FamilyName_Combination_Separated_By_Symbol()
        {
            // Arrange 
            string testInput = "FirstName.FamilyName";
            bool expected = false;

            // Act  
            bool control = RegexValidation.IsNameValid(testInput);

            // Assert 
            Assert.AreEqual(expected, control);
        }

        // Incorrect cases
        [TestMethod]
        public void Test_IsNameValid_Can_Handle_NullInput()
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
        public void Test_IsNameValid_Can_Accept_Symbols()
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
        public void Test_IsNameValid_Can_Accept_Numbers()
        {
            // Arrange 
            string testInput = "firstName 12345";
            bool expected = false;

            // Act  
            bool control = RegexValidation.IsNameValid(testInput);

            // Assert 
            Assert.AreEqual(expected, control);
        }


        #endregion

        #region IsPhoneValid method tests

        // Standard cases
        [TestMethod]
        public void Test_IsPhoneValid_Can_Accept_Phone_Number_With_Spaces()
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
        public void Test_IsPhoneValid_Can_Accept_PhoneNumber_With_Hyphen_Signs()
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
        public void Test_IsPhoneValid_Can_Accept_PhoneNumber_With_Slash_Signs()
        {
            // Arrange
            string testInput = "+36/30/986/6768";
            bool expected = true;

            // Act
            bool control = RegexValidation.IsPhoneValid(testInput);

            // Assert
            Assert.AreEqual(expected, control);
        }

        // Boundary cases
        [TestMethod]
        public void Test_IsPhoneValid_Can_Accept_Phone_Number_Without_CountryCode()
        {
            // Arrange
            string testInput = "30 986 6768";
            bool expected = false;

            // Act
            bool control = RegexValidation.IsPhoneValid(testInput);

            // Assert
            Assert.AreEqual(expected, control);
        }

        // Incorrect cases
        [TestMethod]
        public void Test_IsPhoneValid_Can_Handle_NullInput()
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
        public void Test_IsPhoneValid_Can_Accept_Other_Than_Numbers()
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
        public void Test_IsPhoneValid_Can_Accept_Shorter_PhoneNumber()
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
        public void Test_IsPhoneValid_Can_Accept_Longer_PhoneNumber()
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
        public void Test_IsPhoneValid_Can_Accept_PhoneNumber_With_BackSlash_Signs()
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
        public void Test_IsPhoneValid_Can_Accept_PhoneNumber_With_Plus_Signs()
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
        public void Test_IsPhoneValid_Can_Accept_PhoneNumber_With_Multiply_Signs()
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

        // Standard cases
        [TestMethod]
        public void Test_IsEmailValid_Can_Accept_Valid_Signs()
        {
            // Arrange
            string testInput = @"gabee!#$%&'*+-/=?^_`{|}~1987@gmail.com";
            bool expected = true;

            // Act
            bool control = RegexValidation.IsEmailValid(testInput);

            // Assert
            Assert.AreEqual(expected, control);
        }

        [TestMethod]
        public void Test_IsEmailValid_Can_Accept_Dot_Separated_LocalPart()
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
        public void Test_IsEmailValid_Can_Accept_Address_With_Hyphen_Separated_DomainPart()
        {
            // Arrange
            string testInput = @"gabee1987@gmail.cc-com";
            bool expected = true;

            // Act
            bool control = RegexValidation.IsEmailValid(testInput);

            // Assert
            Assert.AreEqual(expected, control);
        }

        // Incorrect cases
        [TestMethod]
        public void Test_IsEmailValid_Can_Handle_NullInput()
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
        public void Test_IsEmailValid_Can_Accept_Unvalid_Signs_In_LocalPart()
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
        public void Test_IsEmailValid_Can_Accept_Address_Without_AtSign()
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
        public void Test_IsEmailValid_Can_Accept_Unvalid_Sign_In_DomainPart()
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
        public void Test_IsEmailValid_Can_Accept_Address_Without_DomainPart()
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
        public void Test_IsEmailValid_Can_Accept_Address_With_Unvalid_DomainPart()
        {
            // Arrange
            string testInput = @"gabee1987@gmail.c";
            bool expected = false;

            // Act
            bool control = RegexValidation.IsEmailValid(testInput);

            // Assert
            Assert.AreEqual(expected, control);
        }

        #endregion
    }
}
