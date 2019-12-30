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

        public DateTime StartDate { get; set; } = new DateTime();
        //2008, 5, 1, 8, 30, 52
        public DateTime EndDate { get; set; } = new DateTime();
       
        public List<Student> courseStudents = new List<Student>();
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

        public List<Course> CourseSyntheticData()
        {
            List<Course> CourseSyntheticData = new List<Course>();

           Course c1 = new Course();
           Course c2 = new Course();
           Course c3 = new Course();
           Course c4 = new Course();
           Course c5 = new Course();
           Course c6 = new Course();
           Course c7 = new Course();
           Course c8 = new Course();
           Course c9 = new Course();
           

           CourseSyntheticData.Add(c1);
           CourseSyntheticData.Add(c2);
           CourseSyntheticData.Add(c3);
           CourseSyntheticData.Add(c4);
           CourseSyntheticData.Add(c5);
           CourseSyntheticData.Add(c6);
           CourseSyntheticData.Add(c7);
           CourseSyntheticData.Add(c8);
           CourseSyntheticData.Add(c9);


            return CourseSyntheticData;

        }

        public void PrintCourseSyntheticData(List<Course> courseList)
        {

            foreach (var item in courseList)
            {
                Console.WriteLine("Title : {0}.", item.Title);
                Console.WriteLine("Stream : {0}.", item.Stream);
                Console.WriteLine("Type : {0}.", item.Type);
                Console.WriteLine("StartDate : {0}.", item.StartDate);
                Console.WriteLine("EndDate : {0}.", item.EndDate);


            }
        }
    }
}
