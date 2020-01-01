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

        public List<Student> CourseStudents = new List<Student>();
        public List<Trainer> CourseTrainers = new List<Trainer>();
        public List<AssignmentProject> CourseAssignmentsProjects = new List<AssignmentProject>();

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
            CourseStudents = courseStudents;
            CourseTrainers = courseTrainers;
            CourseAssignmentsProjects = courseAssignmentsProjects;


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

        public static List<Course> AddCourseManually()
        {
            List<Course> CourseListOfManualData = new List<Course>();
            bool addMore = true;
            string input = "y";

            do
            {
                Course c1 = new Course();
                //..................create ctor to input data test

                CourseListOfManualData.Add(c1);

                //Let the user add more courses

                try
                {

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("If you would you like to add another course, please type the key 'y' folloew by 'enter'.");
                    Console.ForegroundColor = ConsoleColor.White;
                    input = Console.ReadLine();

                    if (input.ToLower() == "y")
                    {
                        addMore = true;
                    }
                    else
                    {
                        addMore = false;
                        PrivateSchool.ExecuteMenuSelection(PrivateSchool.GetMenuSelection());

                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Your input was invalid.");
                    Console.WriteLine();
                }

            }
            while (addMore);



            return CourseListOfManualData;

        }


    }
}
