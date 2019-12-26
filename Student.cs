using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    class Student : Person
    {/// <summary>
    /// Contains the fields, the constructors and the methods of the child class Student
    /// </summary>
        public DateTime DateOfBirth { get; set; }
        public int TuitionFees { get; set; }

        public Student()
        {

        }

        public Student(DateTime dateOfBirth, int fees)
        {
            DateOfBirth = dateOfBirth;
            TuitionFees = fees;
        }

        public override void FillPersonProperty()
        {
            FirstName = "Giorgos";
            LastName = "Kotopoulos";
            DateOfBirth = DateTime.Now;
            TuitionFees = 1000;
        }
    }
}
