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
            //print syntetic data
            Course c1 = new Course();
            
            c1.PrintCourseSyntheticData(c1.CourseSyntheticData());

            //PrivateSchool privateSchool = new PrivateSchool();

            //int selection = Menu.GetMainMenuSelection();

            ////according to the user's selection, runs the appropriate method

            //bool keepGoing = true;
            //string yesORno = "yes";
            //bool addMore = true;

            //do
            //{
            //    switch (selection)
            //    {
            //        case 0:
            //            do
            //            {
            //                //inserts a course to the list
            //                Course c1 = Menu.GetCourse();
            //                privateSchool.allCourses.Add(c1);
            //                Console.WriteLine("A course in now added to the course list");

            //                Console.WriteLine("Would you like to add another course.\nPlease type yes or no");
            //                yesORno = Console.ReadLine();
            //                addMore = Menu.AddMore(yesORno);

            //            } while (addMore == true);
            //            //........here you need to give an option to see all the menu again
            //            break;
            //        case 1:
            //            //to insert a trainer")" +
            //            break;
            //        case 2:
            //            //to insert a student")" +
            //            break;
            //        case 3:
            //        //to insert an assignment/ project");
            //        case 4:
            //            //to see all the students.
            //            break;
            //        case 5:
            //            //to see all the trainers.
            //            break;
            //        case 6:
            //            //to see all the assignments / projects.
            //            break;
            //        case 7:
            //            //to see all the courses.
            //            break;
            //        case 8:
            //            //to see the students per course.
            //            break;
            //        case 9:
            //            //to see the trainers per course.
            //            break;
            //        case 10:
            //            //to see the assignments/ projects per course.
            //            break;
            //        case 11:
            //            //to see the assignments/ projects per student
            //            break;
            //        case 12:
            //            //to see the students with more courses.
            //            break;
            //        //exit");
            //        default:
            //            break;

            //    }
            //}
            //while (keepGoing);


            Console.WriteLine("Press any key to exit the program.");
            Console.ReadKey();
        }
    }
}
