using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SerializePeople;
using static SerializePeople.PersonSerializable;
using System.IO;

namespace SerializePeopleTest
{
    [TestClass]
    public class SerializePeopleUnitTests
    {
        #region Constructor and ToString tests

        [TestMethod]
        public void Test_Constructor_Is_Sets_Correct_Properties()
        {
            // Arrange 
            PersonSerializable controlPerson = new PersonSerializable();
            controlPerson.Name = "MrTestPerson";
            controlPerson.BirthDate = new DateTime(1987, 03, 31);
            controlPerson.Gender = Genders.Male;
            controlPerson.PhoneNumber = "061222333";
            controlPerson.EmailAddress = "testemail@test.com";
            controlPerson.SetAge();

            // Act  
            PersonSerializable testPerson = new PersonSerializable("MrTestPerson", new DateTime(1987, 03, 31), Genders.Male, "061222333", "testemail@test.com");

            // Assert 
            Assert.AreEqual(testPerson, controlPerson);
        }

        [TestMethod]
        public void Test_ToString_Returns_Correct_String()
        {
            // Arrange
            PersonSerializable testPerson = new PersonSerializable("MrTestPerson", new DateTime(1987, 03, 31), Genders.Male, "061222333", "testemail@test.com");
            string controlString = "Name: " + "MrTestPerson" + "\n" +
                                    "BirthDate: " + "03/31/1987" + "\n" +
                                    "Age: " + "30" + "\n" +
                                    "Gender: " + "Male" +
                                    "Phone number: " + "061222333" + "\n" +
                                    "Email address: " + "testemail@test.com" + "\n";

            // Act
            string testString = testPerson.ToString();

            // Assert
            Assert.AreEqual(testString, controlString);
        }

        #endregion

        #region Serialization tests

        [TestMethod]
        public void Test_Serialize_Create_The_File()
        {
            // Arrange
            if (File.Exists("serializedPerson.bin"))
            {
                File.Delete("serializedPerson.bin");
            }
            PersonSerializable personToSerialize = new PersonSerializable("Mr Serializ Ed", new DateTime(1977, 05, 25), Genders.Male, "+3670999666", "serial@izable.com");

            // Act
            PersonSerializable.SerializePerson(personToSerialize, "serializedPerson.bin");
            bool controlBool = File.Exists("serializedPerson.bin");

            // Assert
            Assert.IsTrue(controlBool);
        }

        [TestMethod]
        public void Test_Deserialize_Gives_Correct_Object()
        {
            // Arrange
            PersonSerializable controlPersonToDeserialize = new PersonSerializable("Mr Serializ Ed", new DateTime(1977, 05, 25), Genders.Male, "+3670999666", "serial@izable.com");
            if (File.Exists("serializedPerson.bin"))
            {
                File.Delete("serializedPerson.bin");
            }
            PersonSerializable.SerializePerson(controlPersonToDeserialize, "serializedPerson.bin");

            // Act
            PersonSerializable testPersonToDeserialize = DeserializePerson("serializedPerson.bin");
            bool testBool = controlPersonToDeserialize.Equals(testPersonToDeserialize);

            // Assert
            Assert.IsTrue(testBool);
        }
        #endregion
    }
}
