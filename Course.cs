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
        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public
        List<Student> courseStudents = new List<Student>();
        public List<Trainer> courseTrainers = new List<Trainer>();
        public List<AssignmentProject> courseAssignmentsProjects = new List<AssignmentProject>();

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

        public void FillCourseProperty()
        {
            
            Title = "CB8";
            Stream = "C#" ;
            Type = "Part time";
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
            Console.WriteLine("The course details are filled automatically");
        }


    }
}
