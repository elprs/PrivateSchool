using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{/// <summary>
/// Contains all the static methods of the project Private School
/// </summary>
    class Menu
    {
        static int showStartMenu()
        {
            int input = 1;
            Console.WriteLine("Start Menu:");
            Console.WriteLine();
            Console.WriteLine("Press 0 to input inforamation.");
            Console.WriteLine("Press 1 to find/read information.");
            Console.WriteLine("Press 2 to exit.");

            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input");
                input = 1;
            }

            return input;
        }

         static int showInputMenu()
        {
            int input = 1;
            Console.WriteLine();
            Console.WriteLine("Press 0 to input courses.");
            Console.WriteLine("Press 1 to input trainers.");
            Console.WriteLine("Press 2 to input students.");
            Console.WriteLine("Press 3 to input ssignments/Projects.");
            Console.WriteLine("Press 4 to exit.");

            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input");
                input = 1;
            }

            return input;
        }

        static int showOutputMenu()
        {
            int input = 1;
            Console.WriteLine();
            Console.WriteLine("Press 0 to find all courses.");
            Console.WriteLine("Press 1 to find all trainers.");
            Console.WriteLine("Press 2 to find all students.");
            Console.WriteLine("Press 3 to find all sssignments/Projects.");
            Console.WriteLine("Press 4 to find students per course.");
            Console.WriteLine("Press 5 to find trainers per course.");
            Console.WriteLine("Press 6 to find assignments/projects per course.");
            Console.WriteLine("Press 7 to find assignments/projects per student.");
            Console.WriteLine("Press 8 to find students enrolled in more that one course.");
            Console.WriteLine("Press 9 to exit.");

            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input");
                input = 1;
            }

            return input;
        }

        public static void selectFromMenu()
        {
            bool keepGoing = false;
            int choice;

            do
            {
                choice = showStartMenu();
                switch (choice)
                {
                    case 0:
                        showInputMenu();
                        break;
                    case 1:
                        showOutputMenu();
                        break;
                    case 2:
                        break;
                    default:
                        keepGoing = true;
                        Console.WriteLine("That was not a valid input.");
                        break;
                }
            }
            while (keepGoing);
        }


        public static void selectFromOutputMenu()
        {
            bool keepGoing = false;
            int choice;

            do
            {
                choice = showOutputMenu();
                switch (choice)
                {
                    case 0:
                        //....
                        break;
                    case 1:
                        //...
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        //exit
                        break;
                    default:
                        Console.WriteLine("That was not a valid input.");
                        keepGoing = true;
                        break;
                }
            }
            while (keepGoing);
        }



        public static void selectFromInputMenu()
        {
            bool keepGoing = false;
            int choice;

            do
            {
                choice = showInputMenu();
                switch (choice)
                {
                    case 0:

                        break;
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:

                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("That was not a valid input.");
                        keepGoing = true;
                        break;
                }
            }
            while (keepGoing);
        }
    }
}
