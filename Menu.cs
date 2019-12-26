using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{/// <summary>
/// Contains all the static methods of the menu of project Private School
/// </summary>
    class Menu
    {
        //shows the menu to the user and gets his corresponding selection
        public static int GetMainMenuSelection()
        {

            Console.WriteLine("Main menu");
            Console.WriteLine();
            Console.WriteLine("Press 0 to insert a course.");
            Console.WriteLine("Press 1 to insert a trainer.");
            Console.WriteLine("Press 2 to insert a student.");
            Console.WriteLine("Press 3 to insert an assignment/project.");
            Console.WriteLine("Press 4 to see all the students.");
            Console.WriteLine("Press 5 to see all the trainers.");
            Console.WriteLine("Press 6 to see all the assignments/projects.");
            Console.WriteLine("Press 7 to see all the courses.");
            Console.WriteLine("Press 8 to see the students per course.");
            Console.WriteLine("Press 9 to see the trainers per course.");
            Console.WriteLine("Press 10 to see the assignments/projects per course.");
            Console.WriteLine("Press 11 to see the assignments/projects per student.");
            Console.WriteLine("Press 12 to see the students with more courses.");
            Console.WriteLine("Press 13 exit.");
            Console.WriteLine();
            Console.WriteLine("According to what you want to proceed with,\nplease press a number followed by the enter key");

            int selection = Convert.ToInt32(Console.ReadLine());

            return selection;
        }

        public static bool AddMore(string yesORno)
        {
            bool addMore;

            if (yesORno == "yes")
            {
                addMore = true;
            }
            else
            {
                addMore = false;
            }
            return addMore;
        }

        //creates a course with synthetic data or allows the user to insert his
        public static Course GetCourse()
        {
            Course c1 = new Course();

            Console.WriteLine("Please insert the title of the course.");
            c1.Title = Console.ReadLine();

            if (c1.Title == "")
            {
                c1.FillCourseProperty();
            }
            else
            {
                Console.WriteLine("Please insert the stream of the course (CSharp or Java).");
                c1.Stream = Console.ReadLine();
                Console.WriteLine("Please insert the type of the course(Full time or Part time).");
                c1.Type = Console.ReadLine();
                Console.WriteLine("Please insert the Starting date of the course(eg. 10 - 10 - 2014 15:00:00");
                c1.StartDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Please insert the Starting date of the course(eg. 10 - 10 - 2014 15:00:00");
                c1.EndDate = Convert.ToDateTime(Console.ReadLine());
            }

            return c1;
        }
    }
}
