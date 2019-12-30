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

            for (int i = 0; i < 9; i++)
            {
                Course c1 = new Course(SyntheticData.GetSyntheticCourseTitle(), );
                c1.Title = ;
                CourseSyntheticData.Add(c1);

            }
           
         
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
