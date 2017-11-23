using System;
using System.Collections.Generic;
using System.Linq;
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

        #region Methods

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

        #endregion
    }
}
