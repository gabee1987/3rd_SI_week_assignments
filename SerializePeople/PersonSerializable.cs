using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializePeople
{
    [Serializable]
    public class PersonSerializable
    {
        #region Fields

        public enum Genders { Male, Female };
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Genders Gender { get; set; }
        public int Age { get; set; }

        #endregion

        #region Constructors

        public PersonSerializable() { }

        public PersonSerializable(string name, DateTime birthDate, Genders gender)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.Gender = gender;
            this.Age = SetAge();
        }

        #endregion

        #region Basic Methods

        public int SetAge()
        {
            // Save today's date.
            var today = DateTime.Today;
            // Calculate the age.
            var age = today.Year - BirthDate.Year;
            // Go back to the year the person was born in case of a leap year
            if (BirthDate > today.AddYears(-age)) age--;
            return age;
        }

        public override String ToString()
        {
            return  "Name: " + Name + "\n" +
                    "BirthDate: " + BirthDate.ToString("MM/dd/yyyy") + "\n" +
                    "Age: " + Age + "\n" +
                    "Gender: " + Gender;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            PersonSerializable person = obj as PersonSerializable;
            if ((System.Object)person == null)
            {
                return false;
            }
            return (Name == person.Name) && (BirthDate == person.BirthDate) && (Age == person.Age) && (Gender == person.Gender);
        }

        #endregion

        #region Serialization Methods

        public void Serialize(PersonSerializable peopleToSerialize, string output)
        {
            // Create file to save the data
            Stream writeStream = new FileStream(output, FileMode.Create, FileAccess.Write, FileShare.None);
            // Create and use a BinaryFormatter object to perform the serialization
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(writeStream, peopleToSerialize);
            // Close the file
            writeStream.Close();

        }

        public static PersonSerializable Deserialize(string input)
        {
            try
            {
                // Open file to read the data from
                Stream openStream = new FileStream(input, FileMode.Open, FileAccess.Read, FileShare.Read);
                // Create a BinaryFormatter object to perform the deserialization
                IFormatter formatter = new BinaryFormatter();
                // Use the BinaryFormatter object to deserialize the data from the file
                PersonSerializable deserializedPerson = (PersonSerializable)formatter.Deserialize(openStream);
                // Close the file and return with the brand-new Person object
                openStream.Close();
                return deserializedPerson;

            } 
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.StackTrace);
            }

            return null;
        }

        #endregion
    }
}
