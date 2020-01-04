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
            Student st1 = new Student();
            Trainer tr1 = new Trainer();
            Assignment as1 = new Assignment();
            Course c1 = new Course();

            //Output.PrintCourses(db.Courses);
            //Output.PrintAssignments(db.Assignments);
            // Output.PrintStudents(db.Students);
            // Output.PrintTrainers(db.Trainers);

            Output.PrintAssignmentsPerCourse(c1.Assignments, db.Courses[2]); // EDOOOOO PSAKSE POIA LISTA EINAI POIA


            //Output.PrintStudentsPerCourse(db.Students, db.Courses[0]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            //Output.PrintStudentsPerCourse(db.Students, db.Courses[1]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            //Output.PrintStudentsPerCourse(db.Students, db.Courses[2]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            //Output.PrintStudentsPerCourse(db.Students, db.Courses[3]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output

            //Output.PrintTrainersPerCourse(db.Trainers, db.Courses[0]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            //Output.PrintTrainersPerCourse(db.Trainers, db.Courses[1]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            //Output.PrintTrainersPerCourse(db.Trainers, db.Courses[2]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            //Output.PrintTrainersPerCourse(db.Trainers, db.Courses[3]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output

            //Output.PrintCoursesPerStudent(db.Courses, db.Students[0]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            //Output.PrintCoursesPerStudent(db.Courses, db.Students[1]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            //Output.PrintCoursesPerStudent(db.Courses, db.Students[2]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            //Output.PrintCoursesPerStudent(db.Courses, db.Students[3]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output

            //Output.PrintCoursesPerTrainer(db.Courses, db.Trainers[0]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            //Output.PrintCoursesPerTrainer(db.Courses, db.Trainers[1]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            //Output.PrintCoursesPerTrainer(db.Courses, db.Trainers[2]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            //Output.PrintCoursesPerTrainer(db.Courses, db.Trainers[3]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output

            //Output.PrintAssignmentsPerStudent(db.Assignments, db.Students[0]);
            //...
            //Output.PrintStudentsPerAssignment(db.Students, db.Assignments[0]);
            //...



            //privateSchool.ExecuteMenuSelection(PrivateSchool.GetMenuSelection());






            Console.WriteLine("Press any letter key to exit the program.");
            Console.ReadKey();
        }
    }
}
