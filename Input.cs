using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{/// <summary>
/// Contains all the static methods of the menu of project Private School
/// </summary>
    static class Input
    {
        public static void AddCoursesToDb()
        {
            Database db = new Database();
            db.Courses.AddRange(GetUserCourses());
            Console.WriteLine("Your course(s) are now added to the database.");
        }

        //return methods
        public static List<Course> GetUserCourses()
        {
            Course course = new Course();
            List<Course> userCourses = new List<Course>();
            bool repeat = false;

            Console.WriteLine("Add a course");
            do
            {
                Console.WriteLine("Add a title"); course.Title = Console.ReadLine();
                Console.WriteLine("Add a stream"); course.Stream = Console.ReadLine();
                Console.WriteLine("Add type"); course.Type = Console.ReadLine();

                Console.WriteLine("AddCoursesToDb starting date");
                course.StartDate = RepeatUntilDateInputValid(Console.ReadLine());
                Console.WriteLine("AddCoursesToDb end date");
                course.EndDate = RepeatUntilDateInputValid(Console.ReadLine());

                userCourses.Add(course);
                repeat = RepeatProcess();

            } while (repeat);

            return userCourses;
        }
        public static bool RepeatProcess()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Would you like to repeat the action?");
            Console.WriteLine("Please type yes or eny key to go to the main menu.");
            Console.ForegroundColor = ConsoleColor.White;

            string answer = Console.ReadLine();

            if (answer.ToLower() == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static DateTime RepeatUntilDateInputValid(string userInput)
        {
            DateTime userDate;
            bool isInputValid;
            do
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Insert a date in the following format:");
                    Console.WriteLine("Day/Month/Year e.g. 01/02/2020");
                    Console.ForegroundColor = ConsoleColor.White;
                    userDate = Convert.ToDateTime(userInput);
                    isInputValid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Your input was invalid, consult the following example.");
                    Console.WriteLine();
                    isInputValid = false;
                }
            } while (isInputValid == false);

            return userDate;
        }
        ////creates a course with synthetic data or allows the user to insert his
        //public static Course GetCourse()
        //{
        //    Course c1 = new Course();

        //    Console.WriteLine("Please insert the title of the course");
        //    c1.Title = Console.ReadLine();

        //    return c1;
        //}

        ////creates a trainer with synthetic data or allows the user to insert it.
        //public static Trainer GetTrainer()
        //{
        //    Trainer t1 = new Trainer();

        //    Console.WriteLine("Please insert the first name of the trainer");
        //    t1.FirstName = Console.ReadLine();



        //    return t1;
        //}
    }
}
