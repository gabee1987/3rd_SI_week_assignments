using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SerializePeople.PersonSerializable;

namespace SerializePeople
{
    class SerializePeopleExercise
    {
        static void Main(string[] args)
        {
            PersonSerializable person1 = new PersonSerializable("Gabee", new DateTime(1987, 03, 31), Genders.Male);
            PersonSerializable person2 = new PersonSerializable("Edward", new DateTime(1974, 11, 15), Genders.Male);
            PersonSerializable person3 = new PersonSerializable("Nancy", new DateTime(1990, 01, 02), Genders.Female);
            PersonSerializable person4 = new PersonSerializable();
            PersonSerializable person5 = new PersonSerializable();
            person4.Name = "Carol";
            person4.BirthDate = new DateTime(1989, 03, 24);
            person4.Gender = Genders.Female;
            person4.Age = person4.SetAge();

            Console.WriteLine(person1);
            Console.WriteLine(person2);
            Console.WriteLine(person3);
            Console.WriteLine(person4);

            Console.ReadLine();
        }
    }
}
