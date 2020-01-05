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

            //Objects of entities
            Student st1 = new Student();
            Trainer tr1 = new Trainer();
            Assignment as1 = new Assignment();
            Course c1 = new Course();

            //Lists Of entities
            List<Course> Courses = new List<Course>();
            List<Student> Students  = new List<Student>();
            List<Trainer> Trainers = new List<Trainer>();
            List<Assignment> Assignments = new List<Assignment>();

            Output.PrintAssignmentsPerStudent(db.Students[0]);
            Output.PrintStudentsWithMultipleCourses(db.Students);
          
           // Output.PrintStudentsPerAssignment(db.Assignments[0]);

            //Output.PrintCourses(db.Courses);
            //Output.PrintAssignments(db.Assignments);
            // Output.PrintStudents(db.Students);
            // Output.PrintTrainers(db.Trainers);


            //Output.PrintAssignmentsPerCourse( db.Courses[1]);
            //Output.PrintCoursePerAssignment(db.Assignments[0]);

            //????    Output.PrintStudentsPerCourse(db.Students, db.Courses[0]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            //Output.PrintAssignmentsPerCourse(db.Courses[0].Assignments, db.Courses[0]); // EDOOOOO PSAKSE POIA LISTA EINAI POIA
            //Output.PrintStudentsPerCourse( db.Courses[1]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            //Output.PrintStudentsPerCourse( db.Courses[2]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            //Output.PrintStudentsPerCourse( db.Courses[3]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output

            //Output.PrintTrainersPerCourse( db.Courses[0]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            //Output.PrintTrainersPerCourse( db.Courses[1]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            //Output.PrintTrainersPerCourse( db.Courses[2]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            //Output.PrintTrainersPerCourse( db.Courses[3]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output

            //Output.PrintCoursesPerStudent( db.Students[0]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            //Output.PrintCoursesPerStudent( db.Students[1]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            //Output.PrintCoursesPerStudent( db.Students[2]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            //Output.PrintCoursesPerStudent( db.Students[3]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output

            //Output.PrintCoursesPerTrainer( db.Trainers[0]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            //Output.PrintCoursesPerTrainer( db.Trainers[1]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            //Output.PrintCoursesPerTrainer( db.Trainers[2]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output
            //Output.PrintCoursesPerTrainer( db.Trainers[3]); //idea! find a method to do the foreach for 0 to Courses.Count.do it in Output

            //Output.PrintAssignmentsPerStudent(db.Students[0]);
            //...
            //Output.PrintStudentsPerAssignment(db.Assignments[0]);
            //...



            //privateSchool.ExecuteMenuSelection(PrivateSchool.GetMenuSelection());






            Console.WriteLine("Press any letter key to exit the program.");
            Console.ReadKey();
        }
    }
}
