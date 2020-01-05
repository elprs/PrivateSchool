using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    static class Output
    {
        static Output() {}
        public static void PrintCourses(List<Course> Courses)
        {
            List<Course> courses = Courses;

            Console.WriteLine();
            Console.WriteLine("The available courses are: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" -------");
            Console.Write(" --------- ");
            Console.Write(" ------------ ");
            Console.Write(" ------------------------ ");
            Console.WriteLine(" ----------------------- ");
            Console.Write("| Title  ");
            Console.Write("| Stream  ");
            Console.Write(" | Type  ");
            Console.Write("\t  |    Start Date  ");
            Console.WriteLine("\t    |    End Date  ");
            Console.Write(" -------");
            Console.Write(" --------- ");
            Console.Write(" ------------ ");
            Console.Write(" ------------------------ ");
            Console.WriteLine(" ----------------------- ");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var item in courses)
            {
                
                Console.Write(" -------");
                Console.Write(" --------- ");
                Console.Write(" ------------ ");
                Console.Write(" ------------------------ ");
                Console.WriteLine(" ----------------------- ");
                Console.Write("|  " + item.Title);
                Console.Write("\t  | " + item.Stream);
                Console.Write("    |  " + item.Type );
                Console.Write("  |  " + item.StartDate );
                Console.WriteLine("    | " + item.EndDate );
                Console.Write(" -------");
                Console.Write(" --------- ");
                Console.Write(" ------------ ");
                Console.Write(" ------------------------ ");
                Console.WriteLine(" ----------------------- ");

            }

        }
        public static void PrintStudents(List<Student> Students)
        {
            List<Student> students = Students;

            Console.WriteLine();
            Console.WriteLine("The Students are: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" ------------- ");
            Console.Write(" ---------------- ");
            Console.Write(" ------------------------- ");
            Console.WriteLine(" ---------------- ");
            Console.Write("|  First Name   ");
            Console.Write("|   Last Name     ");
            Console.Write("|    Date Of Birth    ");
            Console.WriteLine("    | Fees     ");
            Console.Write(" ------------- ");
            Console.Write(" ---------------- ");
            Console.Write(" ------------------------- ");
            Console.WriteLine(" ---------------- ");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var item in students)
            {

                Console.Write(" ------------- ");
                Console.Write(" ---------------- ");
                Console.Write(" ------------------------ ");
                Console.WriteLine(" ---------------- ");
                Console.Write("| " + item.FirstName + "   ");
                Console.Write("\t| " + item.LastName);
                Console.Write("\t  | " + item.DateOfBirth);
                Console.WriteLine("\t    | " + item.TuitionFees);
                Console.Write(" ------------- ");
                Console.Write(" ---------------- ");
                Console.Write(" ------------------------ ");
                Console.WriteLine(" ---------------- ");

            }

        }
        public static void PrintTrainers(List<Trainer> Trainers)
        {
            List<Trainer> trainers = Trainers;

            Console.WriteLine();
            Console.WriteLine("The Trainers are: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" ------------- ");
            Console.Write(" ---------------- ");
            Console.WriteLine(" ---------------- ");
            Console.Write("|  First Name   ");
            Console.Write("| Last Name      ");
            Console.WriteLine(" | Subject   ");
            Console.Write(" ------------- ");
            Console.Write(" ---------------- ");
            Console.WriteLine(" ---------------- ");

            Console.ForegroundColor = ConsoleColor.White;


            foreach (var item in trainers)
            {

                Console.Write(" ------------- ");
                Console.Write(" ---------------- ");
                Console.WriteLine(" ---------------- ");
                Console.Write("| " + item.FirstName + "   ");
                Console.Write("\t|  " + item.LastName);
                Console.WriteLine("\t  | " + item.Subject);
                Console.Write(" ------------- ");
                Console.Write(" ---------------- ");
                Console.WriteLine(" ---------------- ");


            }

        }
        public static void PrintAssignments(List<Assignment> Assignments)
        {
            List<Assignment> assignments = Assignments;

            Console.WriteLine();
            Console.WriteLine("The available Assignments are: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" ---------------- ");
            Console.Write(" ------------- ");
            Console.Write(" ------------------------ ");
            Console.Write(" --------- ");
            Console.WriteLine(" ---------- ");
            Console.Write("| Title        ");
            Console.Write("   | Description  ");
            Console.Write(" |  Submision Date  ");
            Console.Write("\t    |Oral Mark");
            Console.WriteLine(" | Total Mark");
            Console.Write(" ---------------- ");
            Console.Write(" ------------- ");
            Console.Write(" ------------------------ ");
            Console.Write(" --------- ");
            Console.WriteLine(" ---------- ");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var item in assignments)
            {

                Console.Write(" ---------------- ");
                Console.Write(" ------------- ");
                Console.Write(" ------------------------ ");
                Console.Write(" --------- ");
                Console.WriteLine(" ---------- ");
                Console.Write("|  " + item.Title);
                Console.Write("\t  | " + item.Description);
                Console.Write("    |  " + item.SubDateTime);
                Console.Write("    |  " + item.OralMark);
                Console.WriteLine("    | " + item.TotalMark);
                Console.Write(" ---------------- ");
                Console.Write(" ------------- ");
                Console.Write(" ------------------------ ");
                Console.Write(" --------- ");
                Console.WriteLine(" ---------- ");

            }

        }


        public static void PrintStudentsPerCourse(List<Student> Students, Course course )
        {

            Console.WriteLine();
            Console.WriteLine("The students of the course {0} are: ", course.Title);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ------------- ");
            Console.WriteLine("|  " + course.Title + "   ");
            Console.WriteLine(" ------------- ");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var item in course.Students)
            {

                Console.WriteLine(" ------------- ");
                Console.WriteLine("| " + item.FirstName);
                Console.WriteLine(" ------------- ");


            }

        }
        public static void PrintCoursesPerStudent(List<Course> Courses, Student student)
        {
            List<Course> courses = Courses;
            Student student1 = student;

            Console.WriteLine();
            Console.WriteLine("The courses of the student {0} are: ", student1.FirstName);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ------------- ");
            Console.WriteLine("|  " + student1.FirstName + "   ");
            Console.WriteLine(" ------------- ");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var item in student1.Courses)
            {

                Console.WriteLine(" ------------- ");
                Console.WriteLine("| " + item.Title);
                Console.WriteLine(" ------------- ");


            }

        }
        public static void PrintTrainersPerCourse(List<Trainer> Trainers, Course course)
        {
            List<Trainer> trainers = Trainers;
            Course course1 = course;

            Console.WriteLine();
            Console.WriteLine("The Trainers of the course {0} are: ", course1.Title);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ------------- ");
            Console.WriteLine("|  " + course1.Title + "   ");
            Console.WriteLine(" ------------- ");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var item in course1.Trainers)
            {

                Console.WriteLine(" ------------- ");
                Console.WriteLine("| " + item.FirstName);
                Console.WriteLine(" ------------- ");


            }

        }
        public static void PrintCoursesPerTrainer(List<Course> Courses, Trainer Trainer)
        {
            List<Course> courses = Courses;
            Trainer Trainer1 = Trainer;

            Console.WriteLine();
            Console.WriteLine("The courses of the Trainer {0} are: ", Trainer1.FirstName);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ------------- ");
            Console.WriteLine("|  " + Trainer1.FirstName + "   ");
            Console.WriteLine(" ------------- ");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var item in Trainer1.Courses)
            {

                Console.WriteLine(" ------------- ");
                Console.WriteLine("| " + item.Title);
                Console.WriteLine(" ------------- ");


            }

        }
        public static void PrintAssignmentsPerStudent(List<Assignment> Assignments, Student student)
        {
            List<Assignment> assignments = Assignments;
            Student student1 = student;

            Console.WriteLine();
            Console.WriteLine("The Assignments of the student {0} are: ", student1.FirstName);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ------------- ");
            Console.WriteLine("|  " + student1.FirstName + "   ");
            Console.WriteLine(" ------------- ");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var item in student1.Assignments)
            {

                Console.WriteLine(" --------------- ");
                Console.WriteLine("| " + item.Title);
                Console.WriteLine(" --------------- ");


            }

        }
        public static void PrintStudentsPerAssignment(List<Student> Students, Assignment Assignment)
        {
            List<Student> students = Students;
            Assignment Assignment1 = Assignment;

            Console.WriteLine();
            Console.WriteLine("The students of the Assignment {0} are: ", Assignment1.Title);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" --------------- ");
            Console.WriteLine("|  " + Assignment1.Title + "   ");
            Console.WriteLine(" --------------- ");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var item in Assignment1.Students)
            {

                Console.WriteLine(" ------------- ");
                Console.WriteLine("| " + item.FirstName);
                Console.WriteLine(" ------------- ");


            }

        }
        public static void PrintAssignmentsPerCourse(List<Assignment> Assignments, Course course)
        {

            Console.WriteLine();
            Console.WriteLine("The Assignments of the course {0} are: ", course.Title);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ------------- ");
            Console.WriteLine("|  " + course.Title + "   ");
            Console.WriteLine(" ------------- ");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var item in course.Assignments)
            {

                Console.WriteLine(" ------------- ");
                Console.WriteLine("| " + item.Title);
                Console.WriteLine(" ------------- ");


            }

        }






        //    //MenuMethods+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //    public static int GetMenuSelection()
        //    {
        //        //initialised for test
        //        int selection = -1;
        //        bool isInputValid;

        //        do
        //        {
        //            //print menu
        //            Console.ForegroundColor = ConsoleColor.Cyan;
        //            Console.WriteLine();
        //            Console.WriteLine("\tMenu");
        //            Console.WriteLine();
        //            Console.ForegroundColor = ConsoleColor.White;
        //            Console.WriteLine("0. Input courses");
        //            Console.WriteLine("1. Input trainer");
        //            Console.WriteLine("2. Input students");
        //            Console.WriteLine("3. Input assignments/projects");
        //            Console.WriteLine("4. Output students");
        //            Console.WriteLine("5. Output trainers");
        //            Console.WriteLine("6. Output assignments/projects");
        //            Console.WriteLine("7. Output courses");
        //            Console.WriteLine("8. Output students per course");
        //            Console.WriteLine("9. Output trainers per course");
        //            Console.WriteLine("10. Output assignments/projects per course");
        //            Console.WriteLine("11. Output assignments/projects per student");
        //            Console.WriteLine("12. Output students per more courses");
        //            Console.WriteLine("13. Exit the program");





        //            do
        //            {
        //                //Get selection from user
        //                try
        //                {

        //                    Console.ForegroundColor = ConsoleColor.Cyan;
        //                    Console.WriteLine("Please select an option \nby typing the number followed by the 'enter' key");
        //                    Console.WriteLine("or type any other key followed by 'enter' to get to the main menu.");
        //                    Console.ForegroundColor = ConsoleColor.White;
        //                    selection = Convert.ToInt32(Console.ReadLine());
        //                    isInputValid = true;


        //                }
        //                catch (Exception)
        //                {
        //                    Console.WriteLine("Your input was invalid.");
        //                    Console.WriteLine();
        //                    isInputValid = false;
        //                }

        //            }
        //            while (isInputValid == false);



        //        } while (!(selection >= 0 && selection <= 13));


        //        return selection;
        //    }


        //    public void ExecuteMenuSelection(int inputedSelection)
        //    {
        //        //according to the user's selection, runs the appropriate methods
        //        int selection = inputedSelection;
        //        bool isInputValid;
        //        char input = 's';
        //        bool keepGoing = true;



        //        do
        //        {
        //            switch (selection)
        //            {
        //                case 0:

        //                    //                inserts a course to the list


        //                    //                Course c1 = Menu.GetCourse();
        //                    //                privateSchool.allCourses.Add(c1);
        //                    //                Console.WriteLine("A course in now added to the course list");

        //                    //            //........here you need to give an option to see all the menu again
        //                    break;//endCase0

        //                case 1:
        //                    Console.WriteLine();

        //                    Console.WriteLine("Press 's' followed by enter to insert synthetic data.");
        //                    Console.WriteLine("Press 'm' followed by enter to insert manually your data.");
        //                    do
        //                    {
        //                        try
        //                        {

        //                            input = Convert.ToChar(Console.ReadLine());
        //                            isInputValid = true;
        //                            if (input == 's')
        //                            {
        //                                allTrainers = Trainer.TrainerSyntheticData();
        //                                Console.WriteLine("The synthetic data is now added to Trainer 's list.");
        //                                isInputValid = true;
        //                                GetMenuSelection();
        //                            }
        //                            else if (input == 'm')
        //                            {
        //                                allTrainers = Trainer.AddTrainerManually();
        //                                Console.WriteLine("Your data is now added to Trainer 's list.");
        //                                isInputValid = true;
        //                                GetMenuSelection();

        //                            }


        //                        }
        //                        catch (Exception)
        //                        {
        //                            Console.WriteLine("Your input is invalid.");
        //                            isInputValid = false;
        //                        }

        //                    }
        //                    while (isInputValid == false);
        //                    break;//endCase:1

        //                case 2:

        //                    Console.WriteLine();

        //                    Console.WriteLine("Press 's' followed by enter to insert synthetic data.");
        //                    Console.WriteLine("Press 'm' followed by enter to insert manually your data.");
        //                    do
        //                    {
        //                        try
        //                        {

        //                            input = Convert.ToChar(Console.ReadLine());
        //                            isInputValid = true;
        //                            if (input == 's')
        //                            {
        //                                allStudents = Student.StudentListSyntheticData();
        //                                Console.WriteLine("The synthetic data is now added to student 's list.");
        //                                isInputValid = true;
        //                                GetMenuSelection();
        //                            }
        //                            else if (input == 'm')
        //                            {
        //                                allStudents = Student.AddStudentManually();
        //                                Console.WriteLine("Your data is now added to student 's list.");
        //                                isInputValid = true;
        //                                GetMenuSelection();

        //                            }


        //                        }
        //                        catch (Exception)
        //                        {
        //                            Console.WriteLine("Your input is invalid.");
        //                            isInputValid = false;
        //                        }

        //                    }
        //                    while (isInputValid == false);
        //                    break;//endCase:2

        //                case 3:

        //                    Console.WriteLine();

        //                    Console.WriteLine("Press 's' followed by enter to insert synthetic data.");
        //                    Console.WriteLine("Press 'm' followed by enter to insert manually your data.");
        //                    do
        //                    {
        //                        try
        //                        {

        //                            input = Convert.ToChar(Console.ReadLine());
        //                            isInputValid = true;
        //                            if (input == 's')
        //                            {
        //                                allAssignmentsProjects = AssignmentProject.AssignmentProjectSyntheticData();
        //                                Console.WriteLine("The synthetic data is now added to AssignmentProject 's list.");
        //                                isInputValid = true;
        //                                GetMenuSelection();
        //                            }
        //                            else if (input == 'm')
        //                            {
        //                                allAssignmentsProjects = AssignmentProject.AddAssignmentProjectManually();
        //                                Console.WriteLine("Your data is now added to AssignmentProject 's list.");
        //                                isInputValid = true;
        //                                GetMenuSelection();

        //                            }


        //                        }
        //                        catch (Exception)
        //                        {
        //                            Console.WriteLine("Your input is invalid.");
        //                            isInputValid = false;
        //                        }

        //                    }
        //                    while (isInputValid == false);
        //                    break;//endCase:3

        //                //        case 4:
        //                //            //to see all the students.
        //                //            break;
        //                //        case 5:
        //                //            //to see all the trainers.
        //                //            break;
        //                //        case 6:
        //                //            //to see all the assignments / projects.
        //                //            break;
        //                //        case 7:
        //                //            //to see all the courses.
        //                //            break;
        //                //        case 8:
        //                //            //to see the students per course.
        //                //            break;
        //                //        case 9:
        //                //            //to see the trainers per course.
        //                //            break;
        //                //        case 10:
        //                //            //to see the assignments/ projects per course.
        //                //            break;
        //                //        case 11:
        //                //            //to see the assignments/ projects per student
        //                //            break;
        //                //        case 12:
        //                //            //to see the students with more courses.
        //                //            break;
        //                //        //exit");
        //                default:
        //                    break;


        //            }
        //        } while (keepGoing);
        //    }



    }
}
