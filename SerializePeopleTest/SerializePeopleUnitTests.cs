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
            controlPerson.Name = "testName";
            controlPerson.BirthDate = new DateTime(1987, 03, 31);
            controlPerson.Gender = Genders.Male;
            controlPerson.Age = 30;

            // Act  
            PersonSerializable testPerson = new PersonSerializable("testName", new DateTime(1987, 03, 31), Genders.Male);

            // Assert 
            Assert.AreEqual(testPerson, controlPerson);
        }
    }
}
