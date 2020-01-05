using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{/// <summary>
/// Describes the relationship many to many between students and courses
/// </summary>
    class StudentCourse 
    {
        public Student student;
        public Course course;

        public StudentCourse(Student student, Course course)
        {
            this.student = student;
            this.course = course;
            
        }


    }
}
