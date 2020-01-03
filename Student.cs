using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    class Student : Person
    {
        /// <summary>
        /// Contains the fields, properties, the constructors and the methods of the child class Student
        /// </summary>

        //public DateTime DateOfBirth { get; set; }
        //public int TuitionFees { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();

        public Student() { }

        public Student(string firstName)
        {
            FirstName = firstName;
        }

        //public Student(string firstName, string lastName, DateTime dateOfBirth, int fees)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    DateOfBirth = dateOfBirth;
        //    TuitionFees = fees;
        //}

        //public static List<Student> StudentListSyntheticData()
        //{
        //    List<Student> StudentListOfSyntheticData = new List<Student>();

        //    for (int i = 0; i < 20; i++)
        //    {
        //        Student s1 = new Student();

        //        StudentListOfSyntheticData.Add(s1);
        //        Console.WriteLine("The student is added to the list.");

        //    }


        //    return StudentListOfSyntheticData;

        //}

        //public static List<Student> AddStudentManually()
        //{
        //    List<Student> StudentListOfManualData = new List<Student>();
        //    PrivateSchool privateSchool = new PrivateSchool();
        //    bool addMore = true;
        //    bool isInputValid;
        //    string input = "y";

        //    do
        //    {
        //        Student s1 = new Student();

        //        Console.WriteLine("Student's first name:");
        //        s1.FirstName = Console.ReadLine();
        //        Console.WriteLine("Student's last name:");
        //        s1.LastName = Console.ReadLine();

        //        do
        //        {
        //            try
        //            {
        //                Console.WriteLine("Student's date of birth in the following form:\nyear/month/day e.g. 1999/01/01):");
        //                s1.DateOfBirth = Convert.ToDateTime(Console.ReadLine());
        //                isInputValid = true;

        //            }
        //            catch (Exception)
        //            {
        //                Console.WriteLine("Your input was invalid, consult the following example.");
        //                Console.WriteLine();
        //                isInputValid = false;
        //            } 
        //        } while (isInputValid == false);

        //        do
        //        {
        //            try
        //            {
        //                Console.WriteLine("Student's tuition fees:");
        //                s1.TuitionFees = Convert.ToInt32(Console.ReadLine());
        //                isInputValid = true;

        //            }
        //            catch (Exception)
        //            {
        //                Console.WriteLine("Your input was invalid.");
        //                Console.WriteLine();
        //                isInputValid = false;
        //            } 
        //        } while (isInputValid == false);

        //        StudentListOfManualData.Add(s1);
        //        Console.WriteLine("The student is added to the student list.");


        //        //Let the user choose to add more students

        //        do
        //        {
        //            try
        //            {

        //                Console.ForegroundColor = ConsoleColor.Cyan;
        //                Console.WriteLine("If you would you like to add another Student, please type the key 'y' followed by 'enter'.");
        //                Console.ForegroundColor = ConsoleColor.White;
        //                input = Console.ReadLine();



        //                if (input.ToLower() == "y")
        //                {
        //                    addMore = true;
        //                }
        //                else
        //                {
        //                    addMore = false;
        //                    privateSchool.ExecuteMenuSelection(PrivateSchool.GetMenuSelection());

        //                }

        //                isInputValid = true;

        //            }
        //            catch (Exception)
        //            {
        //                Console.WriteLine("Your input was invalid.");
        //                Console.WriteLine();
        //                isInputValid = false;
        //            } 
        //        } while (isInputValid == false);

        //    }
        //    while (addMore);



        //    return StudentListOfManualData;

        //}

    }
}
