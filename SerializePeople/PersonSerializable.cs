using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializePeople
{
    [Serializable]
    public class PersonSerializable : ISerializable, IDeserializationCallback
    {
        #region Fields and Properties

        public enum Genders { Male, Female };
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Genders Gender { get; set; }
        public string PhoneNumber {get; set;}
        public string EmailAddress { get; set; }
        [NonSerialized]private int age;
        //public int Age
        //{
        //    get
        //    {
        //        // Save today's date.
        //        var today = DateTime.Today;
        //        // Calculate the age.
        //        age = today.Year - BirthDate.Year;
        //        // Go back to the year the person was born in case of a leap year
        //        if (BirthDate > today.AddYears(-age)) age--;
        //        return age;
        //    }
        //    set
        //    {
        //        age = value;
        //    }
        //}

        #endregion

        #region Constructors

        public PersonSerializable() { }

        public PersonSerializable(string name, DateTime birthDate, Genders gender, string phoneNumber, string emailAddress)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.Gender = gender;
            this.PhoneNumber = phoneNumber;
            this.EmailAddress = emailAddress;
            SetAge();
            //this.Age = Age;
        }

        #endregion

        #region Basic Methods


        public void SetAge()
        {
            //Save today's date.
            var today = DateTime.Today;
            // Calculate the age.
            age = today.Year - BirthDate.Year;
            // Go back to the year the person was born in case of a leap year
            if (BirthDate > today.AddYears(-age))
            {
                age--;
            }
        }

        public int GetAge()
        {
            return age;
        }

        public override String ToString()
        {
            return  "Name: " + Name + "\n" +
                    "BirthDate: " + BirthDate.ToString("MM/dd/yyyy") + "\n" +
                    "Age: " + age + "\n" +
                    "Gender: " + Gender + "\n" +
                    "Phone number: " + PhoneNumber + "\n" +
                    "Email address: " + EmailAddress + "\n";
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
            return (Name == person.Name) &&
                (BirthDate == person.BirthDate) &&
                (age == person.age) &&
                (Gender == person.Gender) &&
                (PhoneNumber == person.PhoneNumber) &&
                (EmailAddress == person.EmailAddress);
        }

        public bool Equals(PersonSerializable person)
        {
            if ((object)person == null)
                return false;

            return (Name == person.Name) &&
                (BirthDate == person.BirthDate) &&
                (age == person.age) &&
                (Gender == person.Gender) &&
                (PhoneNumber == person.PhoneNumber) &&
                (EmailAddress == person.EmailAddress);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^
                BirthDate.GetHashCode() ^
                age.GetHashCode() ^
                Gender.GetHashCode() ^
                PhoneNumber.GetHashCode() ^
                EmailAddress.GetHashCode();
        }

        #endregion

        #region Serialization Methods

        void IDeserializationCallback.OnDeserialization(Object sender)
        {
            //// After being deserialized, initialize the age field 

            // Save today's date.
            var today = DateTime.Today;
            // Calculate the age.
            age = today.Year - BirthDate.Year;
            // Go back to the year the person was born in case of a leap year
            if (BirthDate > today.AddYears(-age))
            {
                age--;
            }
        }

        // This method is to serialize data. The method is called 
        // on serialization.
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Use the AddValue method to specify serialized values.
            info.AddValue("Name", Name, typeof(string));
            info.AddValue("BirthDate", BirthDate, typeof(DateTime));
            info.AddValue("Gender", Gender, typeof(Genders));
            info.AddValue("PhoneNumber", PhoneNumber, typeof(string));
            info.AddValue("EmailAddress", EmailAddress, typeof(string));
        }

        // The special constructor is used to deserialize values.
        public PersonSerializable(SerializationInfo info, StreamingContext context)
        {
            // Reset the property value using the GetValue method.
            Name = (string)info.GetValue("Name", typeof(string));
            BirthDate = (DateTime)info.GetValue("BirthDate", typeof(DateTime));
            Gender = (Genders)info.GetValue("Gender", typeof(Genders));
            PhoneNumber = (string)info.GetValue("PhoneNumber", typeof(string));
            EmailAddress = (string)info.GetValue("EmailAddress", typeof(string));
        }

        public static void SerializePerson(PersonSerializable personToSerialize, string output)
        {
            // Create file to save the data
            Stream writeStream = new FileStream(output, FileMode.Create, FileAccess.Write, FileShare.None);
            // Create and use a BinaryFormatter object to perform the serialization
            IFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(writeStream, personToSerialize);
            }
            catch (SerializationException se)
            {
                Console.WriteLine("Failed to serialize. Reason: " + se.Message);
                throw;
            }
            finally
            {
                // Close the file
                writeStream.Close();
            }
        }

        public static PersonSerializable DeserializePerson(string input)
        {
            try
            {
                // Open file to read the data from
                Stream openStream = new FileStream(input, FileMode.Open, FileAccess.Read, FileShare.Read);
                // Create a BinaryFormatter object to perform the deserialization
                IFormatter formatter = new BinaryFormatter();
                // Use the BinaryFormatter object to deserialize the data from the file
                PersonSerializable deserializedPerson = (PersonSerializable)formatter.Deserialize(openStream);
                return deserializedPerson;
            }
            catch (SerializationException se)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + se.Message);
                throw;
            }
            catch (FileNotFoundException fe)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + fe.Message);
            }
            return null;
        }


        #endregion
    }
}
