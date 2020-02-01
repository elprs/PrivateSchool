using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{/// <summary>
 /// Contains the fields, properties, the constructors and the methods of the child class Trainer
 /// </summary>
 /// 


    class Trainer : Person
    { 
        public List<Course> Courses { get; set; } = new List<Course>();
        public string SchoolSubject;

        public Trainer(){}
        public Trainer(string firstName, string lastName, string subject) 
        { 
            FirstName = firstName;
            LastName = lastName;
            SchoolSubject = subject;
        }
    }
}
