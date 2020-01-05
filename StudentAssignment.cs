using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    /// <summary>
    /// Every course has assignments, every student has courses, thus every student has assignments
    /// </summary>
    class StudentAssignment
    {
        public Assignment assignment;
        public Student student;

        public StudentAssignment(Student student, Assignment assignment )
        {
            this.assignment = assignment;
            this.student = student;
            student.Assignments.Add(assignment);
            assignment.Students.Add(student);
        }
    }
}
