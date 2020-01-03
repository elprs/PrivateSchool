using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{/// <summary>
/// Contains the Main method
/// Eleni Parisi, January 2020
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();

            //List<Course> Courses = db.Courses;
            //List<Course> Students = db.Students;

            Output.PrintCourses(db.Courses);
            Output.PrintStudents(db.Students);
            Output.PrintTrainers(db.Trainers);

            Output.PrintStudentsPerCourse(db.Students, db.Courses[0]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            Output.PrintStudentsPerCourse(db.Students, db.Courses[1]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            Output.PrintStudentsPerCourse(db.Students, db.Courses[2]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            Output.PrintStudentsPerCourse(db.Students, db.Courses[3]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
        
            Output.PrintCoursesPerStudent(db.Courses, db.Students[0]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            Output.PrintCoursesPerStudent(db.Courses, db.Students[1]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            Output.PrintCoursesPerStudent(db.Courses, db.Students[2]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            Output.PrintCoursesPerStudent(db.Courses, db.Students[3]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output



            //PrivateSchool privateSchool = new PrivateSchool();
            //privateSchool.ExecuteMenuSelection(PrivateSchool.GetMenuSelection());






            Console.WriteLine("Press any letter key to exit the program.");
            Console.ReadKey();
        }
    }
}
