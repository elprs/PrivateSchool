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
        public int id { get; set; }

        public Person()
        { }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

    }
}
