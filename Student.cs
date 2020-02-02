using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
   public  class Student : Person
    {
        /// <summary>
        /// Contains the fields, properties, the constructors and the methods of the child class Student
        /// </summary>

        public DateTime? DateOfBirth { get; set; }
        public int? TuitionFees { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();

      

        public Student(string firstName, string lastName, DateTime? dateOfBirth, int? fees)
        {
           
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            TuitionFees = fees;
        }
    }
}
