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
       
        public DateTime EndDate { get; set; } = new DateTime();

        public List<Student> courseStudents = new List<Student>();
        public List<Trainer> courseTrainers = new List<Trainer>();
        public List<AssignmentProject> courseAssignmentsProjects = new List<AssignmentProject>();

        public Course()
        {

        }

        public Course(string title, string stream, string type, DateTime startDate, DateTime endDate, List<Student> courseStudents, List<Trainer> courseTrainers, List<AssignmentProject> courseAssignmentsProjects)
        {
            Title = title;
            Stream = stream;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;

        }

        //creates a list of Courses from Synthetic data
        public List<Course> CourseSyntheticData()
        {
            List<Course> CourseListOfSyntheticData = new List<Course>();

            for (int i = 0; i < 9; i++)
            {
                Course c1 = new Course(SyntheticData.GetSyntheticCourseTitle(), SyntheticData.GetSyntheticCourseStream(), SyntheticData.GetSyntheticCourseType(), SyntheticData.GetSyntheticCourseStartDate(), SyntheticData.GetSyntheticCourseEndDate(), Student.StudentSyntheticData(), Trainer.TrainerSyntheticData(), AssignmentProject.AssignmentProjectListOfSyntheticData() ) ;
                CourseListOfSyntheticData.Add(c1);

            }
           
            return CourseListOfSyntheticData;

        }

        //prints the synthetic data of the course list
        public void PrintCourseSyntheticData(List<Course> courseList)
        {

            foreach (var course in courseList)
            {
                Console.WriteLine("Title : {0}.", course.Title);
                Console.WriteLine("Stream : {0}.", course.Stream);
                Console.WriteLine("Type : {0}.", course.Type);
                Console.WriteLine("StartDate : {0}.", Convert.ToString(course.StartDate));
                Console.WriteLine("EndDate : {0}.", Convert.ToString(course.EndDate));
                Console.WriteLine("The list of students is: " );
                Student.PrintStudentSyntheticData(course.courseStudents); 
                Console.WriteLine("The list of trainers is: " );
                Trainer.PrintTrainerSyntheticData(course.courseTrainers); 
                Console.WriteLine("The list of assignments/projects is: " );
                AssignmentProject.PrintAssignementProjectSyntheticData(course.courseAssignmentsProjects);

            }

        }
    }
}
