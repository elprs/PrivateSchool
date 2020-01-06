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

        //Printing domain entities' information
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

            foreach (var course in courses)
            {

                Console.Write(" -------");
                Console.Write(" --------- ");
                Console.Write(" ------------ ");
                Console.Write(" ------------------------ ");
                Console.WriteLine(" ----------------------- ");
                Console.Write("|  " + course.Title);
                Console.Write("\t  | " + course.Stream);
                Console.Write("    |  " + course.Type);
                Console.Write("  |  " + course.StartDate);
                Console.WriteLine("    | " + course.EndDate);
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

            foreach (var student in students)
            {

                Console.Write(" ------------- ");
                Console.Write(" ---------------- ");
                Console.Write(" ------------------------ ");
                Console.WriteLine(" ---------------- ");
                Console.Write("| " + student.FirstName + "   ");
                Console.Write("\t| " + student.LastName);
                Console.Write("\t  | " + student.DateOfBirth);
                Console.WriteLine("\t    | " + student.TuitionFees);
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


            foreach (var trainer in trainers)
            {

                Console.Write(" ------------- ");
                Console.Write(" ---------------- ");
                Console.WriteLine(" ---------------- ");
                Console.Write("| " + trainer.FirstName + "   ");
                Console.Write("\t|  " + trainer.LastName);
                Console.WriteLine("\t  | " + trainer.Subject);
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

            foreach (var assignment in assignments)
            {

                Console.Write(" ---------------- ");
                Console.Write(" ------------- ");
                Console.Write(" ------------------------ ");
                Console.Write(" --------- ");
                Console.WriteLine(" ---------- ");
                Console.Write("|  " + assignment.Title);
                Console.Write("  | " + assignment.Description);
                Console.Write("    |  " + assignment.SubDateTime);
                Console.Write("    |  " + assignment.OralMark);
                Console.WriteLine("    | " + assignment.TotalMark);
                Console.Write(" ---------------- ");
                Console.Write(" ------------- ");
                Console.Write(" ------------------------ ");
                Console.Write(" --------- ");
                Console.WriteLine(" ---------- ");

            }

        }

        //Printing aggregated-classes' information
        public static void PrintStudentsPerCourse(Course course)
        {
            Console.WriteLine();
            Console.WriteLine("The students of the course {0} are: ", course.Title);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ------------- ");
            Console.WriteLine("|  " + course.Title + "   ");
            Console.WriteLine(" ------------- ");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var student in course.Students)
            {

                Console.WriteLine(" ------------- ");
                Console.WriteLine("| " + student.FirstName);
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

            foreach (var course in student.Courses)
            {

                Console.WriteLine(" ------------- ");
                Console.WriteLine("| " + course.Title);
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

            foreach (var trainer in course.Trainers)
            {

                Console.WriteLine(" ------------- ");
                Console.WriteLine("| " + trainer.FirstName);
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

            foreach (var course in Trainer.Courses)
            {

                Console.WriteLine(" ------------- ");
                Console.WriteLine("| " + course.Title);
                Console.WriteLine(" ------------- ");


            }

        }
        public static void PrintAssignmentsPerStudent(Student student)
        {
            //takes courses per student and returns the associated assignments
            List<Assignment> Assignments = AssignmentsPerStudent(CoursesPerStudent(student));

            Console.WriteLine();
            Console.WriteLine("The Assignments of the student are: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" --------------------- ");
            Console.WriteLine("| " + student.FirstName + " " + student.LastName);
            Console.WriteLine(" --------------------- ");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var assignment in Assignments)
            {

                Console.WriteLine(" --------------- ");
                Console.WriteLine("| " + assignment.Title);
                Console.WriteLine(" --------------- ");

            }

        }
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
        }
        public static void PrintStudentsPerAssignment(Assignment Assignment)
        {
            Console.WriteLine();
            Console.WriteLine("The students of the Assignment {0} are: ", Assignment.Title);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" --------------- ");
            Console.WriteLine("|  " + Assignment.Title + "   ");
            Console.WriteLine(" --------------- ");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var student in Assignment.Students)
            {

                Console.WriteLine(" ------------- ");
                Console.WriteLine("| " + student.FirstName);
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

            foreach (var assignemt in course.Assignments)
            {

                Console.WriteLine(" ------------- ");
                Console.WriteLine("| " + assignemt.Title);
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

            foreach (var course in Assignment.Courses)
            {

                Console.WriteLine(" ------------- ");
                Console.WriteLine("| " + course.Title);
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
        public static void FindStudentsWhoNeedToSubmit()
        {
            int userWeekOfYear = GetWeekOfYearFromUsersDate();
            Database db = new Database();
            Console.WriteLine();
            Console.WriteLine("The students who need to submit an assignment the week of the given date are:");
            foreach (StudentCourse sc in db.StudentCourses)
            {
                foreach (AssignmentCourse ac in db.CourseAssignments)
                {
                    MakeStudentSubmissionList(sc, ac, userWeekOfYear);
                }
            }
        }
        public static void MakeStudentSubmissionList(StudentCourse sc, AssignmentCourse ac, int userWeekOfYear)
        {
            if (sc.course == ac.course)
            {
                if (WeekOfYear(ac.assignment.SubDateTime) == userWeekOfYear)//Dates converted to week 
                {
                    
                    Console.WriteLine(" -------------------------- ");
                    Console.Write("| " + sc.student.FirstName);
                    Console.WriteLine(" " + sc.student.LastName);
                }
            }
        }
        public static void ExpressGratitude()
        {
            Console.WriteLine("Thank you, Daskale.");
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
            weekNum = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(dateTime, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }
        public static int GetWeekOfYearFromUsersDate()
        {
            int weekOfYear = 0;
            bool isInputValid;
           
            do
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Insert a date in the following format:");
                    Console.WriteLine("Day/Month/Year e.g. 01/02/2020");
                    Console.WriteLine("TIP: The SubDates of the DataBase is between 01/02/2020 and 06/06/2020");
                    Console.ForegroundColor = ConsoleColor.White;
                    DateTime userDate = Convert.ToDateTime(Console.ReadLine());
                    weekOfYear = WeekOfYear(userDate);
                    isInputValid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Your input was invalid, consult the following example.");
                    Console.WriteLine();
                    isInputValid = false;
                } 
            } while (isInputValid == false);
          
            return weekOfYear;
        } 
       
        //Main menu method
        public static void ProceedWithMenuSelection(int selection, Database db)
        {
           
            switch (selection)
            {
                case 0:
                    Input.AddCoursesToDb(db);
                    ProceedWithMenuSelection(Input.PrintMenuGetUserSelection(), db);
                    break;
                case 1:
                    Input.AddTrainersToDb(db);
                    ProceedWithMenuSelection(Input.PrintMenuGetUserSelection(), db);
                    break;
                case 2:
                    Input.AddStudentsToDb(db);
                    ProceedWithMenuSelection(Input.PrintMenuGetUserSelection(), db);
                    break;
                case 3:
                    Input.AddAssignmentsToDb(db);
                    ProceedWithMenuSelection(Input.PrintMenuGetUserSelection(), db);
                    break;
                case 4:
                    PrintStudents(db.Students);
                    ProceedWithMenuSelection(Input.PrintMenuGetUserSelection(), db);
                    break;
                case 5:
                    PrintTrainers(db.Trainers);
                    ProceedWithMenuSelection(Input.PrintMenuGetUserSelection(), db);
                    break;
                case 6:
                    PrintAssignments(db.Assignments);
                    ProceedWithMenuSelection(Input.PrintMenuGetUserSelection(), db);
                    break;
                case 7:
                    PrintCourses(db.Courses); 
                    ProceedWithMenuSelection(Input.PrintMenuGetUserSelection(), db);
                    break;
                case 8:
                    for (int i = 0; i < db.Courses.Count; i++) 
                    { PrintStudentsPerCourse(db.Courses[i]);}
                    ProceedWithMenuSelection(Input.PrintMenuGetUserSelection(), db);
                    break;
                case 9:
                    for (int i = 0; i < db.Courses.Count; i++) 
                    { PrintTrainersPerCourse(db.Courses[i]); }
                    ProceedWithMenuSelection(Input.PrintMenuGetUserSelection(), db);
                    break;
                case 10:
                    for (int i = 0; i < db.Courses.Count; i++) 
                    { PrintAssignmentsPerCourse(db.Courses[i]); }
                    ProceedWithMenuSelection(Input.PrintMenuGetUserSelection(), db);
                    break;
                case 11:
                    for (int i = 0; i < db.Students.Count; i++)
                    {PrintAssignmentsPerStudent(db.Students[i]);}
                    ProceedWithMenuSelection(Input.PrintMenuGetUserSelection(), db);
                    break;
                case 13:
                    FindStudentsWhoNeedToSubmit();
                    ProceedWithMenuSelection(Input.PrintMenuGetUserSelection(), db);
                    break;
                case 14:
                    break;
                case 42:
                    ExpressGratitude();
                    ProceedWithMenuSelection(Input.PrintMenuGetUserSelection(), db);
                    break;
                default:
                    ProceedWithMenuSelection(Input.PrintMenuGetUserSelection(), db);
                    break;
            }
        }
    }
}