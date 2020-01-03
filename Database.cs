using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    class Database
    {

        public List<Course> Courses { get; set; } = new List<Course>();

        public Database()
        {
            Course c1 = new Course("CB4");
            Course c1 = new Course("CB4");
        }
       // //Course Synthetic Data ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
       // public static string GetSyntheticCourseTitle()
       // {
       //     List<string> CourseTitles = new List<string>() 
       //     { 
       //      "CB4", 
       //      "CB3", 
       //      "CB2", 
       //      "CB1",
            
       //     };
            
       //     return CourseTitles[ran.Next(0, CourseTitles.Count)];
       // }

       // public static string GetSyntheticCourseStream()
       // {
       //     List<string> CourseStream = new List<string>()
       //     {
       //         "Java", 
       //         "C#"
       //     };
            
       //     return CourseStream[ran.Next(0, CourseStream.Count)];
       // }

       // public static string GetSyntheticCourseType()
       // {
       //     List<string> CourseType = new List<string>()
       //     {
       //         "Full Time",
       //         "Part Time"
       //     };
           
       //     return CourseType[ran.Next(0, CourseType.Count)];
       // }

       // public static DateTime GetSyntheticCourseStartDate()
       // {
       //     List<DateTime> CourseStartDate = new List<DateTime>()
       //     { 
       //         new DateTime(2019, 11, 12),
       //         new DateTime(2019, 09, 10),
       //         new DateTime(2020, 02, 12)
                
       //     };
           
           
       //     return CourseStartDate[ran.Next(0, CourseStartDate.Count)];
       // }

       // public static DateTime GetSyntheticCourseEndDate()
       // {
       //     List<DateTime> CourseEndDate = new List<DateTime>()
       //     {
       //         new DateTime(2020, 05, 30),
       //         new DateTime(2020, 02, 19),
       //         new DateTime(2020, 08, 30)

       //     };

            
       //     return CourseEndDate[ran.Next(0, CourseEndDate.Count)];
       // }

       // //Assignment Project Synthetic Data++++++++++++++++++++++++++++++++++++++++++++++++++++++++
       // public static string GetSyntheticAssignmentProjectTitle()
       // {
       //     List<string> AssignmentProjectTitles = new List<string>()
       //     {
       //      "Assignment 1",
       //      "Assignment 2",
       //      "Assignment 3",
       //      "Assignment 4",
       //      "Assignment 5",
       //      "Project 1",
       //      "Project 2",
             
       //     };
          
       //     return AssignmentProjectTitles[ran.Next(0, AssignmentProjectTitles.Count)];
       // }

       // public static string GetSyntheticAssignmentProjectDescription()
       // {
       //     List<string> AssignmentProjectDescription = new List<string>()
       //     {
       //         "Individual",
       //         "Team"
       //     };
          
       //     return AssignmentProjectDescription[ran.Next(0, AssignmentProjectDescription.Count)];
       // }

       // public static double GetSyntheticAssignmentProjectOralMark()
       // {
       //     List<double> AssignmentProjectOralMark = new List<double>()
       //     {
       //         32.2,
       //         40.6,
       //         25.9,
       //         32.7,
       //         50.0,
       //         12.2,
       //         30.6,
       //         45.9,
       //         12.7,
       //         30.0
       //     };
       
       //     return AssignmentProjectOralMark[ran.Next(0, AssignmentProjectOralMark.Count)];
       // }

       // public static double GetSyntheticAssignmentProjectTotalMark()
       // {
       //     List<double> AssignmentProjectTotalMark = new List<double>()
       //     {
       //         33.2 + GetSyntheticAssignmentProjectOralMark(),
       //         47.6 + GetSyntheticAssignmentProjectOralMark(),
       //         20.9 + GetSyntheticAssignmentProjectOralMark(),
       //         39.7 + GetSyntheticAssignmentProjectOralMark(),
       //         50.0 + GetSyntheticAssignmentProjectOralMark(),
       //         13.2 + GetSyntheticAssignmentProjectOralMark(),
       //         27.6 + GetSyntheticAssignmentProjectOralMark(),
       //         30.9 + GetSyntheticAssignmentProjectOralMark(),
       //         49.7 + GetSyntheticAssignmentProjectOralMark(),
       //         20.0 + GetSyntheticAssignmentProjectOralMark()
       //     };

       //     return AssignmentProjectTotalMark[ran.Next(0, AssignmentProjectTotalMark.Count)];
       // }

       // public static DateTime GetSyntheticAssignmentProjectSubDateTime()
       // {
       //     List<DateTime> AssignmentProjectSubDateTime = new List<DateTime>()
       //     {
       //         new DateTime(2020, 01, 10, 8, 00, 00),
       //         new DateTime(2020, 02, 20, 9, 00, 00),
       //         new DateTime(2020, 03, 30, 8, 00, 00),
       //         new DateTime(2020, 04, 3, 9, 00, 00),
       //         new DateTime(2020, 05, 4, 8, 00, 00),
       //         new DateTime(2020, 06, 10, 8, 00, 00),
                

       //     };

       //     return AssignmentProjectSubDateTime[ran.Next(0, AssignmentProjectSubDateTime.Count)];
       // }

       // //Person Synthetic Data++++++++++++++++++++++++++++++++++++++++++++++++++++++++
       // public static string GetSyntheticPersonFirstName()
       // {
       //     List<string> PersonFirstNames = new List<string>()
       //     {
       //      "Eleni",
       //      "Giorgos",
       //      "Dimitris",
       //      "Giannis",
       //      "Thanasis",
       //      "Mitsos",
       //      "Konstantina",
       //      "Xristos",
       //      "Taksiarxis",
       //      "Dimitra",
       //      "Athina",
       //      "Periklis"

       //     };
          
       //     return PersonFirstNames[ran.Next(0, PersonFirstNames.Count)];
       // }

       // public static string GetSyntheticPersonLastName()
       // {
       //     List<string> PersonLastNames = new List<string>()
       //     {
       //      "Papapetrou",
       //      "Zinonos",
       //      "Papadopoulou",
       //      "Parisi",
       //      "Konstantinou",
       //      "Axileou",
       //      "Xhan",
       //      "Leontou",
       //      "Antonioy",
       //      "Liraki",
       //      "Gaitanou",
       //      "Perikleous"

       //     };
           
       //     return PersonLastNames[ran.Next(0, PersonLastNames.Count)];
       // }

       // //Student Synthetic Data++++++++++++++++++++++++++++++++++++++++++++++++++++++++

       // public static DateTime GetSyntheticStudentDateOfBirth()
       // {
       //     List<DateTime> StudentDateOfBirth = new List<DateTime>()
       //     {
       //         new DateTime(1989, 01, 10),
       //         new DateTime(1972, 02, 21),
       //         new DateTime(1990, 03, 30),
       //         new DateTime(1994, 04, 3),
       //         new DateTime(1988, 05, 4),
       //         new DateTime(1982, 06, 1),
       //         new DateTime(1989, 11, 10)


       //     };

           
       //     return StudentDateOfBirth[ran.Next(0, StudentDateOfBirth.Count)];
       // }

       // public static int GetSyntheticStudentFees()
       // {
       //     List<int> StudentFees = new List<int>();
            
       //         for(int i = 2000; i < 2600; i += 100)
       //     {
       //         StudentFees.Add(i);
       //     }

       //     return StudentFees[ran.Next(0, StudentFees.Count)];
       // }

       // //Trainer Synthetic Data++++++++++++++++++++++++++++++++++++++++++++++++++++++++

       // public static Subject GetSyntheticTrainerSubject()
       // {
       //     List<Subject> TrainerSubject = new List<Subject>()
       //     {
       //         Subject.AngularJSReact,
       //         Subject.architecture,
       //         Subject.BootstrapFramework,
       //         Subject.CloudBasedServices,
       //         Subject.CSharp,
       //         Subject.HTML_CSS,
       //         Subject.Java,
       //         Subject.JavaScript,
       //         Subject.SQL,
       //         Subject.UiUXDesign,
       //         Subject.UnixCommandLine,
       //         Subject.VersionControlGit,
       //         Subject.webServersApache,
       //         Subject.xUnit
              
       //     };

       //     return TrainerSubject[ran.Next(0, TrainerSubject.Count)];
       // }

       // //StudentsPersCourse+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
       // //create a list of the courses which holds the corresponding list of students
       // public List<List<Student>> GetSyntheticStudentsPerCourse(List<Course> courseListOfSyntheticData, List<Student> studentListOfSyntheticData)
       // {
       //     List<List<Student>> studentsPerCourses = new List<List<Student>>();
       //     List<Course> courseList = courseListOfSyntheticData;
       //     List<Student> studentList = studentListOfSyntheticData;

       //     foreach (var course in courseList)
       //     {
       //         for (int i = 0; i < courseList.Count; i++)
       //         {

       //         }
       //     };


       //     return studentsPerCourses;
       // }


    }
}
