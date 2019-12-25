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
            Console.WriteLine();
            Console.WriteLine("0...");
            Console.WriteLine("1...");
            Console.WriteLine("2..exit.");

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
            Console.WriteLine("0.input..");
            Console.WriteLine("1...");
            Console.WriteLine("2...");
            Console.WriteLine("3...");
            Console.WriteLine("4 exit...");

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
            Console.WriteLine("0.output..");
            Console.WriteLine("1...");
            Console.WriteLine("2...");
            Console.WriteLine("3...");
            Console.WriteLine("4.exit..");
            Console.WriteLine("1...");
            Console.WriteLine("2...");
            Console.WriteLine("3...");
            Console.WriteLine("4.exit..");

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
