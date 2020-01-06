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
        //Methods about courses
        public static List<Course> GetCoursesFromUser()
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
        public static void AddCoursesToDb(Database db)
        {
            db.Courses.AddRange(GetCoursesFromUser());
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Your course(s) are now added to the database.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        
        //General purpose methods
        public static bool RepeatAboveProcess()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("Would you like to insert more?");
            Console.WriteLine("Please type 'yes' followed by enter ");
            Console.WriteLine("or type any key.");
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
        public static int RepeatUntilDoubleNumberIsValid()
        {
            int userNumber = 0;
            bool isInputValid;
            do
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Insert an decimal number");
                    Console.WriteLine("TIP: min oral mark: 0.0");
                    Console.WriteLine("TIP: max oral mark: 50.0");
                    Console.ForegroundColor = ConsoleColor.White;
                    userNumber = Convert.ToInt32(Console.ReadLine());
                    isInputValid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Your input was invalid, consult the following form.");
                    Console.WriteLine();
                    isInputValid = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Your input was invalid, consult the following form.");
                    Console.WriteLine();
                    isInputValid = false;
                }
            } while (isInputValid == false);

            return userNumber;

        }
        public static int RepeatUntilIntegerIsValid()
        {
            int userNumber = 0;
            bool isInputValid;
            do
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Insert an integer number");
                    Console.WriteLine("e.g. 200");
                    Console.ForegroundColor = ConsoleColor.White;
                    userNumber = Convert.ToInt32(Console.ReadLine());
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

            return userNumber;

        }


        //Methods about Students
        public static List<Student> GetStudentsFromUser()
        {
            Student Student = new Student();
            List<Student> userStudents = new List<Student>();

            bool willRepeat = false;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Add a Student");
            Console.ForegroundColor = ConsoleColor.White;

            do
            {
                Console.WriteLine("Add a first name"); Student.FirstName = Console.ReadLine();
                Console.WriteLine("Add a last name"); Student.LastName = Console.ReadLine();

                Console.WriteLine("Add date of birth");
                Student.DateOfBirth = RepeatUntilDateIsValid();
                Console.WriteLine("Add student's fees");
                Student.TuitionFees = RepeatUntilIntegerIsValid();

                userStudents.Add(Student);
                willRepeat = RepeatAboveProcess();

            } while (willRepeat);

            return userStudents;
        }
        public static void AddStudentsToDb(Database db)
        {
            db.Students.AddRange(GetStudentsFromUser());
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Your Student(s) are now added to the database.");
            Console.ForegroundColor = ConsoleColor.White;
        }
       

        //Methods about assignments
        public static List<Assignment> GetAssignmentsFromUser()
        {
            Assignment assignment = new Assignment();
            List<Assignment> userAssignments = new List<Assignment>();

            bool willRepeat = false;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Add an Assignment");
            Console.ForegroundColor = ConsoleColor.White;

            do
            {
                Console.WriteLine("Add a title"); assignment.Title = Console.ReadLine();
                Console.WriteLine("Add a description"); assignment.Description = Console.ReadLine();

                Console.WriteLine("Add a submission date");
                assignment.SubDateTime = RepeatUntilDateIsValid();
                Console.WriteLine("Add Assignment's oral mark");
                assignment.OralMark = RepeatUntilDoubleNumberIsValid();

                userAssignments.Add(assignment);
                willRepeat = RepeatAboveProcess();

            } while (willRepeat);

            return userAssignments;
        }
        public static void AddAssignmentsToDb(Database db)
        {
            db.Assignments.AddRange(GetAssignmentsFromUser());
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Your assignment(s) are now added to the database.");
            Console.ForegroundColor = ConsoleColor.White;
        }
       

        //Methods about trainers
        public static List<Trainer> GetTrainersFromUser()
        {
            Trainer t1 = new Trainer();
            List<Trainer> userTrainers = new List<Trainer>();

            bool willRepeat;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Add a Trainer");
            Console.ForegroundColor = ConsoleColor.White;

            do
            {
                Console.WriteLine("Add a first name"); t1.FirstName = Console.ReadLine();
                Console.WriteLine("Add a last name"); t1.LastName = Console.ReadLine();

                SelectSubjectForTrainer(t1);

                userTrainers.Add(t1);
                willRepeat = RepeatAboveProcess();

            } while (willRepeat);

            return userTrainers;
        }
        public static void AddTrainersToDb(Database db)
        {
            db.Trainers.AddRange(GetTrainersFromUser());
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Your Trainer(s) are now added to the database.");
            Console.ForegroundColor = ConsoleColor.White;

        }
        public static int RepeatUntilSelectionIsValid()
        {
            int userNumber = 0;
            bool isInputValid;
            do
            {//Check if switch can be used her"""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""!!!!!!!!!!!!!!!!!!!!!!!!!!!
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Insert an integer number");
                    Console.WriteLine("e.g. 200");
                    Console.ForegroundColor = ConsoleColor.White;
                    userNumber = Convert.ToInt32(Console.ReadLine());
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

            return userNumber;

        }
        public static int SelectSubjectForTrainer(Trainer trainer)
        {
            int selection = 0;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Add subject by typing its number shown at the following list :");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(" 0 CSharp");
            Console.WriteLine(" 1 Java");
            Console.WriteLine(" 2 HTML_CSS");
            Console.WriteLine(" 3 SQL");
            Console.WriteLine();
            Console.WriteLine(" 4 JavaScript");
            Console.WriteLine(" 5 Bootstrap ");
            Console.WriteLine(" 6 AngularJSReact");
            Console.WriteLine(" 7 VersionControlGit");
            Console.WriteLine();
            Console.WriteLine(" 8 Architecture");
            Console.WriteLine(" 9 Apache");
            Console.WriteLine(" 10 xUnit");
            Console.WriteLine();
            Console.WriteLine(" 11 UnixCommandLine");
            Console.WriteLine(" 12 UiUXDesign");
            Console.WriteLine(" 13 CloudBasedServices");

            selection = RepeatUntilIntegerIsValid();

            switch (selection)
            {
                case 0:
                    trainer.Subject = Subject.CSharp;
                    break;
                case 1:
                    trainer.Subject = Subject.Java;
                    break;
                case 2:
                    trainer.Subject = Subject.HTML_CSS;
                    break;
                case 3:
                    trainer.Subject = Subject.SQL;
                    break;
                case 4:
                    trainer.Subject = Subject.JavaScript;
                    break;
                case 5:
                    trainer.Subject = Subject.Bootstrap;
                    break;
                case 6:
                    trainer.Subject = Subject.AngularJSReact;
                    break;
                case 8:
                    trainer.Subject = Subject.VersionControlGit;
                    break;
                case 9:
                    trainer.Subject = Subject.architecture;
                    break;
                case 10:
                    trainer.Subject = Subject.Apache;
                    break;
                case 11:
                    trainer.Subject = Subject.xUnit;
                    break;
                case 13:
                    trainer.Subject = Subject.UnixCommandLine;
                    break;
                case 14:
                    trainer.Subject = Subject.UiUXDesign;
                    break;
                case 15:
                    trainer.Subject = Subject.CloudBasedServices;
                    break;
                default:
                    trainer.Subject = Subject.CSharp;
                    break;
            }

            return selection;

        }

        // Menu method
        public static int PrintMenuGetUserSelection()
        {
            int selection = 42;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("     Main menu");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Press 0 to insert a course");
            Console.WriteLine("Press 1 to insert a trainer");
            Console.WriteLine("Press 2 to insert a student");
            Console.WriteLine("Press 3 to insert an assignment");
            Console.WriteLine();
            Console.WriteLine("Press 4 to output all the students");
            Console.WriteLine("Press 5 to output all the trainers");
            Console.WriteLine("Press 6 to output all the assignments");
            Console.WriteLine("Press 7 to output all the courses");
            Console.WriteLine();
            Console.WriteLine("Press 8 to output the students per course");
            Console.WriteLine("Press 9 to output the trainers per course");
            Console.WriteLine("Press 10 to output the assignments per course");
            Console.WriteLine();
            Console.WriteLine("Press 11 to output the assignments per student");
            Console.WriteLine("Press 12 to output the students with more courses");
            Console.WriteLine("Press 13 to output the students who need to submit close to a date");
            Console.WriteLine("Press 14 exit");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("According to what you want to proceed with,\nplease press a number followed by the enter key");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            try
            {
                selection = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input. Please insert a number from the menu");
            }

            return selection;
        }

    }
}