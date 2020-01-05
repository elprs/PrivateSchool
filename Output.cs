using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace PrivateSchool
{
    static class Output
    {
        
        static Output() { }

        //Printing Domain's information
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
                Console.Write("    |  " + item.Type);
                Console.Write("  |  " + item.StartDate);
                Console.WriteLine("    | " + item.EndDate);
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
                Console.Write("  | " + item.Description);
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

        //Printing helper-classes' information
        public static void PrintStudentsPerCourse(Course course)
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
        public static void PrintCoursesPerStudent(Student student)
        {


            Console.WriteLine();
            Console.WriteLine("The courses of the student {0} are: ", student.FirstName);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ------------- ");
            Console.WriteLine("|  " + student.FirstName + "   ");
            Console.WriteLine(" ------------- ");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var item in student.Courses)
            {

                Console.WriteLine(" ------------- ");
                Console.WriteLine("| " + item.Title);
                Console.WriteLine(" ------------- ");


            }

        }
        public static void PrintTrainersPerCourse(Course course)
        {
            Console.WriteLine();
            Console.WriteLine("The Trainers of the course {0} are: ", course.Title);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ------------- ");
            Console.WriteLine("|  " + course.Title + "   ");
            Console.WriteLine(" ------------- ");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var item in course.Trainers)
            {

                Console.WriteLine(" ------------- ");
                Console.WriteLine("| " + item.FirstName);
                Console.WriteLine(" ------------- ");


            }

        }
        public static void PrintCoursesPerTrainer(Trainer Trainer)
        {

            Console.WriteLine();
            Console.WriteLine("The courses of the Trainer {0} are: ", Trainer.FirstName);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ------------- ");
            Console.WriteLine("|  " + Trainer.FirstName + "   ");
            Console.WriteLine(" ------------- ");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var item in Trainer.Courses)
            {

                Console.WriteLine(" ------------- ");
                Console.WriteLine("| " + item.Title);
                Console.WriteLine(" ------------- ");


            }

        }
        public static void PrintAssignmentsPerStudent(Student student)
        {
            //takes courses per student and returns the associated assignments
            List<Assignment> Assignments = AssignmentsPerStudent(CoursesPerStudent(student));

            Console.WriteLine();
            Console.WriteLine("The Assignments of the student {0} are: ", student.FirstName);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ------------- ");
            Console.WriteLine("|  " + student.FirstName + "   ");
            Console.WriteLine(" ------------- ");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var item in Assignments)
            {

                Console.WriteLine(" --------------- ");
                Console.WriteLine("| " + item.Title);
                Console.WriteLine(" --------------- ");

            }

        }//nice
        public static void PrintStudentsWithMultipleCourses(List<Student> Students)
        {
            Console.WriteLine();
            foreach (var student in Students)
            {
                int a = NumberOfCoursesPerStudent(student);

                if (a > 1)
                {
                    Console.WriteLine("The student {0} {1} has {2} courses.", student.FirstName, student.LastName, a);
                }
            }
        }//nice
        public static void PrintStudentsPerAssignment(Assignment Assignment)
        {
            Console.WriteLine();
            Console.WriteLine("The students of the Assignment {0} are: ", Assignment.Title);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" --------------- ");
            Console.WriteLine("|  " + Assignment.Title + "   ");
            Console.WriteLine(" --------------- ");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var item in Assignment.Students)
            {

                Console.WriteLine(" ------------- ");
                Console.WriteLine("| " + item.FirstName);
                Console.WriteLine(" ------------- ");


            }

        }
        public static void PrintAssignmentsPerCourse(Course course)
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
        public static void PrintCoursePerAssignment(Assignment Assignment)
        {
            Console.WriteLine();
            Console.WriteLine("The Course of the Assignment {0} are: ", Assignment.Title);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" --------------- ");
            Console.WriteLine("|  " + Assignment.Title + "   ");
            Console.WriteLine(" --------------- ");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var item in Assignment.Courses)
            {

                Console.WriteLine(" ------------- ");
                Console.WriteLine("| " + item.Title);
                Console.WriteLine(" ------------- ");


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
        //Return methods
        public static List<Course> CoursesPerStudent(Student student)
        {
            List<Course> CoursesPerStudent = new List<Course>();


            foreach (var course in student.Courses)
            {
                CoursesPerStudent.Add(course);
            }

            return CoursesPerStudent;
        }
        public static List<Assignment> AssignmentsPerStudent(List<Course> CoursesPerStudent)
        {
            List<Assignment> assignmentsPerStudent = new List<Assignment>();

            foreach (var course in CoursesPerStudent)
            {
                assignmentsPerStudent.AddRange(course.Assignments); // concatenates every list of assignment to the assignmentPerStudent List
            }

            return assignmentsPerStudent;
        } 

        public static int NumberOfCoursesPerStudent(Student student)
        {
            int count = 0;


            foreach (var course in student.Courses)
            {
                count += 1;
            }

            return count;



        }
        public static int WeekOfYear(DateTime dateTime) // source : https://stackoverflow.com/questions/11154673/get-the-correct-week-number-of-a-given-date //refers to ISO8601
        {
            int weekNum = 0;
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(dateTime);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                dateTime = dateTime.AddDays(3);
            }
            // Return the week of our adjusted day
            weekNum =  CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(dateTime, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }
        public static List<int> SubmissionWeeks(List<DateTime> SubDates)
        {
            List<int> submissionWeeks = new List<int>();

            foreach (var item in SubDates)
            {
                submissionWeeks.Add(WeekOfYear(item));
            }
            return submissionWeeks;
        }
        public static bool CompareSubDatesWithUserDate(List<int> SubmissionWeeks, int weekOfYear)
        {
            bool isInSubWeek = false;
            foreach (int item in SubmissionWeeks)
            {
                if (item == weekOfYear)
                {
                    isInSubWeek = true;
                }
                else
                {
                    isInSubWeek = false;
                }
            }
            return isInSubWeek;
        }

        //shows the menu to the user and gets his corresponding selection
        public static int PrintMenuGetUserSelection()
        {
            Console.WriteLine();
            Console.WriteLine("     Main menu");
            Console.WriteLine();
            Console.WriteLine("Press 0 to insert a course");
            Console.WriteLine("Press 1 to insert a trainer");
            Console.WriteLine("Press 2 to insert a student");
            Console.WriteLine("Press 3 to insert an assignment/project");
            Console.WriteLine("Press 4 to print all the students");
            Console.WriteLine("Press 5 to see all the trainers");
            Console.WriteLine("Press 6 to see all the assignments");
            Console.WriteLine("Press 7 to see all the courses");
            Console.WriteLine("Press 8 to see the students per course");
            Console.WriteLine("Press 9 to see the trainers per course");
            Console.WriteLine("Press 10 to see the assignments per course");
            Console.WriteLine("Press 11 to see the assignments per student");
            Console.WriteLine("Press 12 to see the students with more courses");
            Console.WriteLine("Press 13 exit");
            Console.WriteLine();
            Console.WriteLine("According to what you want to proceed with,\nplease press a number followed by the enter key");

            int selection = Convert.ToInt32(Console.ReadLine());

            return selection;
        }
        public static bool ProceedWithSelection(int selection)
        {
            Database db = new Database();
            bool goToMenu = false;

            switch (selection)
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
                    PrintStudents(db.Students);
                    ProceedWithSelection(PrintMenuGetUserSelection());
                    break;
                case 5:
                    PrintTrainers(db.Trainers);
                    ProceedWithSelection(PrintMenuGetUserSelection());
                    break;
                case 6:
                    PrintAssignments(db.Assignments);
                    ProceedWithSelection(PrintMenuGetUserSelection());
                    break;
                case 7:
                    PrintCourses(db.Courses);
                    ProceedWithSelection(PrintMenuGetUserSelection());
                    break;
                case 8:
                    for (int i = 0; i < db.Courses.Count; i++)
                    {
                        PrintStudentsPerCourse(db.Courses[i]);
                    }
                    ProceedWithSelection(PrintMenuGetUserSelection());
                    break;
                case 9:
                    for (int i = 0; i < db.Courses.Count; i++)
                    {
                        PrintTrainersPerCourse(db.Courses[i]);
                    }
                    ProceedWithSelection(PrintMenuGetUserSelection());
                    break;
                case 10:
                    for (int i = 0; i < db.Courses.Count; i++)
                    {
                        PrintAssignmentsPerCourse(db.Courses[i]);
                    }
                    ProceedWithSelection(PrintMenuGetUserSelection());
                    break;

                case 11:
                    break;

                case 13: 
                    break;

                default:
                    break;
            }

            return goToMenu;
        }
    }
}