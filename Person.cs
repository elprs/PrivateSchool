using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{/// <summary>
/// Contains the fields, the constructors and the methods of the class Person
/// </summary>
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        { }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //Virtual method
        public virtual void FillPersonProperty()
        {
            FirstName = "Giorgos";
            LastName = "Kotopoulos";
        }

        public List<Person> PersonSyntheticData()
        {
            List<Person> PersonListOfSyntheticData = new List<Person>();

            for (int i = 0; i < 40; i++)
            {
                Person p1 = new Person(SyntheticData.GetSyntheticPersonFirstName(), SyntheticData.GetSyntheticPersonLastName() );
                PersonListOfSyntheticData.Add(p1);

            }


            return PersonListOfSyntheticData;

        }

        public static void PrintPersonSyntheticData ( List<Person> personList)
        {
            foreach (var item in personList)
            {
                Console.WriteLine("First Name : {0}.", item.FirstName );
                Console.WriteLine("Last Name : {0}.", item.LastName );
            }
        }

    }          
}
