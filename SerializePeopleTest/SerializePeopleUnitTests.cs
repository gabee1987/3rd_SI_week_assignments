using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SerializePeople;
using static SerializePeople.PersonSerializable;

namespace SerializePeopleTest
{
    [TestClass]
    public class SerializePeopleUnitTests
    {
        [TestMethod]
        public void Test_Constructor_Is_Sets_Correct_Properties()
        {
            // Arrange 
            PersonSerializable controlPerson = new PersonSerializable();
            controlPerson.Name = "MrTestPerson";
            controlPerson.BirthDate = new DateTime(1987, 03, 31);
            controlPerson.Gender = Genders.Male;
            controlPerson.Age = 30;

            // Act  
            PersonSerializable testPerson = new PersonSerializable("MrTestPerson", new DateTime(1987, 03, 31), Genders.Male);

            // Assert 
            Assert.AreEqual(testPerson, controlPerson);
        }

        [TestMethod]
        public void Test_ToString_Returns_Correct_String()
        {
            // Arrange
            PersonSerializable testPerson = new PersonSerializable("MrTestPerson", new DateTime(1987, 03, 31), Genders.Male);
            string controlString = "Name: " + "MrTestPerson" + "\n" +
                                    "BirthDate: " + "03/31/1987" + "\n" +
                                    "Age: " + "30" + "\n" +
                                    "Gender: " + "Male";

            // Act
            string testString = testPerson.ToString();

            // Assert
            Assert.AreEqual(testString, controlString);
        }
    }
}
