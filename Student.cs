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
        private DateTime DateOfBirth { get; set; }
        private int TuitionFees { get; set; }
    }
}
