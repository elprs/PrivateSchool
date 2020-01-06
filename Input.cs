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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Your course(s) are now added to the database.");
            Console.ForegroundColor = ConsoleColor.White;

        }

        //return methods
        public static List<Course> GetUserCourses()
        {
            Course course = new Course();
            List<Course> userCourses = new List<Course>();

            bool willRepeat = false;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Add a course");
            Console.ForegroundColor = ConsoleColor.White;

            do
            {
                Console.WriteLine("Add a title"); course.Title = Console.ReadLine();
                Console.WriteLine("Add a stream"); course.Stream = Console.ReadLine();
                Console.WriteLine("Add type"); course.Type = Console.ReadLine();

                Console.WriteLine("Add starting date");
                course.StartDate = RepeatUntilDateIsValid();
                Console.WriteLine("Add end date");
                course.EndDate = RepeatUntilDateIsValid();

                userCourses.Add(course);
                willRepeat = RepeatAboveProcess();

            } while (willRepeat);

            return userCourses;
        }
        public static bool RepeatAboveProcess()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Would you like to insert more?");
            Console.WriteLine("Please type yes or if no type any key.");
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
        
        public static DateTime RepeatUntilDateIsValid()
        {
            DateTime userDate = new DateTime(2020, 02, 02);
            bool isInputValid;
            do
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Insert a date in the following format:");
                    Console.WriteLine("Day/Month/Year e.g. 01/02/2020");
                    Console.ForegroundColor = ConsoleColor.White;
                    userDate = Convert.ToDateTime(Console.ReadLine());
                    isInputValid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Your input was invalid, consult the following example.");
                    Console.WriteLine();
                    isInputValid = false;
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

        public static void AddStudentsToDb()
        {
            Database db = new Database();
            db.Students.AddRange(GetUserStudents());
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Your Student(s) are now added to the database.");
            Console.ForegroundColor = ConsoleColor.White;

        }



    }
}
