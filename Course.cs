using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    class Course
    {/// <summary>
/// Contains the fields, the constructors and the methods of the class Course
/// </summary>
        private string Title { get; set; }
        private string Stream { get; set; }
        private string Type { get; set; }
        private DateTime StartDate { get; set; }
        private DateTime EndDate { get; set; }

        private List<Student> courseStudents = new List<Student>();
        private List<Trainer> courseTrainers = new List<Trainer>();
        private List<AssignmentProject> courseAssignmentsProjects = new List<AssignmentProject>();

        public Course()
        {

        }

        public Course(string title, string stream, string type, DateTime startDate, DateTime endDate)
        {
            Title = title;
            Stream = stream;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;

        }
    }
}
