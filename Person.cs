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
            List<Person> PersonSyntheticData = new List<Person>();

            Person p1 = new Person("Antonis", "Aggelakis");
            Person p2 = new Person("Basilis", "Kostakis");
            Person p3 = new Person("Petros", "Rallis");
            Person p4 = new Person("Panagiotis", "Mpenakis");
            Person p5 = new Person("Dora", "Mitrou");
            Person p6 = new Person("Vasiliki", "Petrovich");
            Person p7 = new Person("Xalim", "Chan");
            Person p8 = new Person("Vera", "Aggelakou");
            Person p9 = new Person("Petra", "Fenou");
            Person p10 = new Person("Antonis", "Thodoridou");
            Person p11 = new Person("Lena", "Kouli");
            Person p12 = new Person("Maria", "Papadopoylou");
            Person p13 = new Person("Kostas", "Kostakis");
            Person p14 = new Person("Mairi", "Papadopoulou");
            Person p15 = new Person("Eleni", "Ntinou");
            Person p16 = new Person("Alexandros", "Aggelakis");
            Person p17 = new Person("Nina", "Simon");
            Person p18 = new Person("Katerina", "Zaxariadi");
            Person p19 = new Person("Antreas", "Antreou");
            Person p20 = new Person("Dimitris", "Dimitriou");

            PersonSyntheticData.Add(p1);
            PersonSyntheticData.Add(p2 );
            PersonSyntheticData.Add(p3 );
            PersonSyntheticData.Add(p4 );
            PersonSyntheticData.Add(p5 );
            PersonSyntheticData.Add(p6 );
            PersonSyntheticData.Add(p7 );
            PersonSyntheticData.Add(p8 );
            PersonSyntheticData.Add(p9 );
            PersonSyntheticData.Add(p10);
            PersonSyntheticData.Add(p11);
            PersonSyntheticData.Add(p12);
            PersonSyntheticData.Add(p13);
            PersonSyntheticData.Add(p14);
            PersonSyntheticData.Add(p15);
            PersonSyntheticData.Add(p16);
            PersonSyntheticData.Add(p17);
            PersonSyntheticData.Add(p18);
            PersonSyntheticData.Add(p19);
            PersonSyntheticData.Add(p20);

            return PersonSyntheticData;

        }

        public void PrintPersonSyntheticData ( List<Person> personList)
        {
            foreach (var item in personList)
            {
                Console.WriteLine("First Name : {0}.", item.FirstName );
                Console.WriteLine("Last Name : {0}.", item.LastName );
            }
        }

    }          
}
