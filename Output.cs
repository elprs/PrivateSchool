using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    class Output
    {
    //    public List<Course> allCourses = new List<Course>();
    //    public List<Student> allStudents = new List<Student>();
    //    public List<Trainer> allTrainers = new List<Trainer>();
    //    public List<AssignmentProject> allAssignmentsProjects = new List<AssignmentProject>();

    //    public Output()
    //    { }

    //    //printing methods+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    //    //needs fixing, test
    //    public void PrintCourseData(List<Course> courseList)
    //    {

    //        foreach (var course in courseList)
    //        {
    //            Console.WriteLine("Title : {0}", course.Title);
    //            Console.WriteLine("Stream : {0}", course.Stream);
    //            Console.WriteLine("Type : {0}", course.Type);
    //            Console.WriteLine("StartDate : {0}", Convert.ToString(course.StartDate));
    //            Console.WriteLine("EndDate : {0}", Convert.ToString(course.EndDate));

    //            Console.ForegroundColor = ConsoleColor.Green;
    //            Console.WriteLine("The list of students is: ");
    //            Output.PrintStudentData(course.CourseStudents);


    //            Console.ForegroundColor = ConsoleColor.Red;
    //            Console.WriteLine("The list of trainers is: ");
    //            Output.PrintTrainerData(course.CourseTrainers);

    //            Console.ForegroundColor = ConsoleColor.Blue;
    //            Console.WriteLine("The list of assignments/projects is: ");
    //            Output.PrintAssignementProjectData(course.CourseAssignmentsProjects);
    //            Console.ForegroundColor = ConsoleColor.White;
    //        }

    //    }

    //    public static void PrintAssignementProjectData(List<AssignmentProject> assignmentProjectList)
    //    {

    //        foreach (var item in assignmentProjectList)
    //        {
    //            Console.WriteLine("Title : {0}", item.Title);
    //            Console.WriteLine("Description : {0}", item.Description);
    //            Console.WriteLine("SubDateTime : {0}", Convert.ToString(item.SubDateTime));
    //            Console.WriteLine("OralMark : {0}", Convert.ToString(item.OralMark));
    //            Console.WriteLine("TotalMark : {0}", Convert.ToString(item.TotalMark));


    //        }
    //    }

    //    public static void PrintPersonData(List<Person> personList)
    //    {
    //        foreach (var item in personList)
    //        {
    //            Console.WriteLine("First Name : {0}", item.FirstName);
    //            Console.WriteLine("Last Name : {0}", item.LastName);
    //        }
    //    }
    //    public static void PrintTrainerData(List<Trainer> trainerList)
    //    {

    //        foreach (var item in trainerList)
    //        {
    //            Console.WriteLine("First Name : {0}", item.FirstName);
    //            Console.WriteLine("Last Name : {0}", item.LastName);
    //            Console.WriteLine("Subject : {0}", Convert.ToString(item.Subject));

    //        }
    //    }

    //    public static void PrintStudentData(List<Student> studentList)
    //    {
    //        Console.WriteLine("Student count is: {0}", studentList.Count);
    //        foreach (var item in studentList)
    //        {
    //            Console.WriteLine("First name : {0}", item.FirstName);
    //            Console.WriteLine("Last name : {0}", item.LastName);
    //            Console.WriteLine("Date of Birth : {0}", Convert.ToString(item.DateOfBirth));
    //            Console.WriteLine("Tuition fees : {0}", Convert.ToString(item.TuitionFees));

    //        }
    //    }

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
