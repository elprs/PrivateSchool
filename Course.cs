using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    /// <summary>
    /// Contains the properties, the constructors and the methods of the class Course
    /// </summary>
    class Course
    {
        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }

        public DateTime StartDate { get; set; } = new DateTime();

        public DateTime EndDate { get; set; } = new DateTime();

        public List<Student> Students = new List<Student>();
        public List<Trainer> Trainers = new List<Trainer>();
        public List<Assignment> Assignments = new List<Assignment>();
        

        public Course() { }


        public Course(string title, string stream, string type, DateTime startDate, DateTime endDate)
        {
            Title = title;
            Stream = stream;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
        }

        


        //public static List<Course> AddCourseManually()
        //{
        //    List<Course> CourseListOfManualData = new List<Course>();
        //    PrivateSchool privateSchool = new PrivateSchool();
        //    bool addMore = true;
        //    bool isInputValid;
        //    string input = "y";

        //    do
        //    {
        //        Course c1 = new Course();


        //        Console.WriteLine("Course's title: ");
        //        c1.Title = Console.ReadLine();
        //        Console.WriteLine("Course's stream (Java or CSharp):");
        //        c1.Stream = Console.ReadLine();
        //        Console.WriteLine("Course's type (Full time or Part time):");
        //        c1.Stream = Console.ReadLine();

        //        do
        //        {
        //            try
        //            {
        //                Console.WriteLine("Course's start date in the following format:\nyear/month/day e.g. 2020/01/01):");
        //                c1.StartDate = Convert.ToDateTime(Console.ReadLine());
        //                isInputValid = true;

        //            }
        //            catch (Exception)
        //            {
        //                Console.WriteLine("Your input was invalid, consult the following example.");
        //                Console.WriteLine();
        //                isInputValid = false;
        //            }
        //        } while (isInputValid == false);


        //        do
        //        {
        //            try
        //            {
        //                Console.WriteLine("Course's End date in the following format:\nyear/month/day e.g. 2020/01/01):");
        //                c1.EndDate = Convert.ToDateTime(Console.ReadLine());
        //                isInputValid = true;

        //            }
        //            catch (Exception)
        //            {
        //                Console.WriteLine("Your input was invalid, consult the following example.");
        //                Console.WriteLine();
        //                isInputValid = false;
        //            }
        //        } while (isInputValid == false);





        //        //  List<Student> courseStudents, List<Trainer> courseTrainers, List<AssignmentProject> courseAssignmentsProjects
        //        //??????????????????Should course have this connection with the other 3 classes??YES!ISSHOULD and i DOES nOw!






        //        CourseListOfManualData.Add(c1);

        //        //Let the user add more courses

        //        try
        //        {

        //            Console.ForegroundColor = ConsoleColor.Cyan;
        //            Console.WriteLine("If you would you like to add another course, please type the key 'y' folloew by 'enter'.");
        //            Console.ForegroundColor = ConsoleColor.White;
        //            input = Console.ReadLine();

        //            if (input.ToLower() == "y")
        //            {
        //                addMore = true;
        //            }
        //            else
        //            {
        //                addMore = false;
        //                privateSchool.ExecuteMenuSelection(PrivateSchool.GetMenuSelection());

        //            }

        //        }
        //        catch (Exception)
        //        {
        //            Console.WriteLine("Your input was invalid.");
        //            Console.WriteLine();
        //        }

        //    }
        //    while (addMore);

        //    return CourseListOfManualData;

        //}




    }
}
