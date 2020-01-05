using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{/// <summary>
/// One course to many assignments
/// </summary>
    class AssignmentsPerCourse
    {
        public Course course;
        public Assignment assignment;

        public AssignmentsPerCourse(Assignment assignment, Course course)
        {
            this.assignment = assignment;
            this.course = course;
            assignment.Courses.Add(course);
            course.Assignments.Add(assignment);
        }
    }
}
