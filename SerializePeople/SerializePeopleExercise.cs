using System;
using System.Collections.Generic;
using System.IO;
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
            PersonSerializable person1 = new PersonSerializable("Gabee", new DateTime(1987, 03, 31), Genders.Male, "+369866768", "gabee1987@gmail.com");
            PersonSerializable person2 = new PersonSerializable("Edward", new DateTime(1974, 11, 15), Genders.Male, "061555666", "edwardScissorHand@burtonCo.com");
            PersonSerializable person3 = new PersonSerializable("Nancy", new DateTime(1990, 01, 02), Genders.Female, "+36709665544", "nancyTheWeedQueen@gethigh.com");
            PersonSerializable person4 = new PersonSerializable();
            PersonSerializable person5 = new PersonSerializable();
            person4.Name = "Marilyn";
            person4.BirthDate = new DateTime(1989, 03, 24);
            person4.Gender = Genders.Female;
            person4.PhoneNumber = "+361222333";
            person4.EmailAddress = "marilynNotManson@peace.com";
            person4.SetAge();
            //person4.Age = person4.Age;

            Console.WriteLine(person1 + "\n");
            Console.WriteLine(person2 + "\n");
            Console.WriteLine(person3 + "\n");
            Console.WriteLine(person4 + "\n");
            Console.WriteLine();
            Console.WriteLine();


            // Serialization
            if (File.Exists("serializedPerson.bin"))
            {
                File.Delete("serializedPerson.bin");
            }
            PersonSerializable personToSerialize = new PersonSerializable("Mr Serializ Ed", new DateTime(1977, 05, 25), Genders.Male, "0690666888", "serialNotKiller@izable.net");
            //Console.WriteLine("before serialize\n" + personToSerialize);
            PersonSerializable.SerializePerson(personToSerialize, "serializedPerson.bin");
            Console.WriteLine("Person is serialized. \n");

            // Deserialization
            PersonSerializable personToDeserialize = DeserializePerson("serializedPerson.bin");
            Console.WriteLine("Person is deserialized. \n");
            Console.WriteLine(personToDeserialize);


            Console.ReadLine();
        }
    }
}
