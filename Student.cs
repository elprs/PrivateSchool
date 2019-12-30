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

        public Student(DateTime dateOfBirth, int fees)
        {
            DateOfBirth = dateOfBirth;
            TuitionFees = fees;
        }

        public List<Student> StudentSyntheticData()
        {
            List<Student> StudentSyntheticData = new List<Student>();

            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            Student s4 = new Student();
            Student s5 = new Student();
            Student s6 = new Student();
            Student s7 = new Student();
            Student s8 = new Student();
            Student s9 = new Student();
            Student s10 = new Student();
            Student s11 = new Student();
            Student s12 = new Student();
            Student s13 = new Student();
            Student s14 = new Student();
            Student s15 = new Student();
            Student s16 = new Student();
            Student s17 = new Student();
            Student s18 = new Student();
            Student s19 = new Student();
            Student s20 = new Student();

            StudentSyntheticData.Add(s1);
            StudentSyntheticData.Add(s2);
            StudentSyntheticData.Add(s3);
            StudentSyntheticData.Add(s4);
            StudentSyntheticData.Add(s5);
            StudentSyntheticData.Add(s6);
            StudentSyntheticData.Add(s7);
            StudentSyntheticData.Add(s8);
            StudentSyntheticData.Add(s9);
            StudentSyntheticData.Add(s10);
            StudentSyntheticData.Add(s11);
            StudentSyntheticData.Add(s12);
            StudentSyntheticData.Add(s13);
            StudentSyntheticData.Add(s14);
            StudentSyntheticData.Add(s15);
            StudentSyntheticData.Add(s16);
            StudentSyntheticData.Add(s17);
            StudentSyntheticData.Add(s18);
            StudentSyntheticData.Add(s19);
            StudentSyntheticData.Add(s20);

            return StudentSyntheticData;

        }

        public void PrintStudentSyntheticData(List<Student> studentList)
        {

            foreach (var item in studentList)
            {
                Console.WriteLine("Date of Birth : {0}.", item.DateOfBirth);
                Console.WriteLine("Tuition fees : {0}.", item.TuitionFees);

            }
        }

    }
}
