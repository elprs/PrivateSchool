using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    /// <summary>
    /// Many to Many data association.
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
