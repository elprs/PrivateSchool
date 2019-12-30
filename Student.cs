using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    class Student : Person
    {/// <summary>
    /// Contains the fields, the constructors and the methods of the child class Student
    /// </summary>
        public DateTime DateOfBirth { get; set; }
        public int TuitionFees { get; set; }

        public Student()
        {

        }

        public Student(string firstName, string lastName, DateTime dateOfBirth, int fees)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            TuitionFees = fees;
        }

        public static List<Student> StudentSyntheticData()
        {
            List<Student> StudentListOfSyntheticData = new List<Student>();

            for (int i = 0; i < 20; i++)
            {
                Student s1 = new Student(SyntheticData.GetSyntheticPersonFirstName(), SyntheticData.GetSyntheticPersonLastName(), SyntheticData.GetSyntheticStudentDateOfBirth(), SyntheticData.GetSyntheticStudentFees()) ;

                StudentListOfSyntheticData.Add(s1);

            }


            return StudentListOfSyntheticData;

        }

        public static void PrintStudentSyntheticData(List<Student> studentList)
        {

            foreach (var item in studentList)
            {
                Console.WriteLine("First name : {0}.", item.FirstName);
                Console.WriteLine("Last name : {0}.", item.LastName);
                Console.WriteLine("Date of Birth : {0}.", Convert.ToString(item.DateOfBirth) );
                Console.WriteLine("Tuition fees : {0}.", Convert.ToString(item.TuitionFees)  );

            }
        }

    }
}
