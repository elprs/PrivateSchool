using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    class SyntheticData
    {
        //Course Synthetic Data ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public static string GetSyntheticCourseTitle()
        {
            List<string> CourseTitles = new List<string>() 
            { 
                "CB8", 
             "CB7", 
             "CB6", 
             "CB5", 
             "CB4", 
             "CB3", 
             "CB2", 
             "CB1",
             "CJ1"
            };
            Random ran = new Random();
            return CourseTitles[ran.Next(0, CourseTitles.Count)];
        }

        public static string GetSyntheticCourseStream()
        {
            List<string> CourseStream = new List<string>()
            {
                "Java", 
                "C#"
            };
            Random ran = new Random();
            return CourseStream[ran.Next(0, CourseStream.Count)];
        }

        public static string GetSyntheticCourseType()
        {
            List<string> CourseType = new List<string>()
            {
                "Full Time",
                "Part Time"
            };
            Random ran = new Random();
            return CourseType[ran.Next(0, CourseType.Count)];
        }

        public static DateTime GetSyntheticCourseStartDate()
        {
            List<DateTime> CourseStartDate = new List<DateTime>()
            { 
                new DateTime(2019, 11, 12),
                new DateTime(2019, 09, 10),
                new DateTime(2020, 02, 12)
                
            };
           
            Random ran = new Random();
            return CourseStartDate[ran.Next(0, CourseStartDate.Count)];
        }

        public static DateTime GetSyntheticCourseEndDate()
        {
            List<DateTime> CourseEndDate = new List<DateTime>()
            {
                new DateTime(2020, 05, 30),
                new DateTime(2020, 02, 19),
                new DateTime(2020, 08, 30)

            };

            Random ran = new Random();
            return CourseEndDate[ran.Next(0, CourseEndDate.Count)];
        }

        //Assignment Project Synthetic Data++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public static string GetSyntheticAssignmentProjectTitle()
        {
            List<string> AssignmentProjectTitles = new List<string>()
            {
             "Assignment 1",
             "Assignment 2",
             "Assignment 3",
             "Assignment 4",
             "Assignment 5",
             "Project 1",
             "Project 2",
             
            };
            Random ran = new Random();
            return AssignmentProjectTitles[ran.Next(0, AssignmentProjectTitles.Count)];
        }

        public static string GetSyntheticAssignmentProjectDescription()
        {
            List<string> AssignmentProjectDescription = new List<string>()
            {
                "Indivudual",
                "Team"
            };
            Random ran = new Random();
            return AssignmentProjectDescription[ran.Next(0, AssignmentProjectDescription.Count)];
        }

        public static double GetSyntheticAssignmentProjectOralMark()
        {
            List<double> AssignmentProjectOralMark = new List<double>()
            {
                32.2,
                40.6,
                25.9,
                32.7,
                50.0,
                12.2,
                30.6,
                45.9,
                12.7,
                30.0
            };
            Random ran = new Random();
            return AssignmentProjectOralMark[ran.Next(0, AssignmentProjectOralMark.Count)];
        }

        public static double GetSyntheticAssignmentProjectTotalMark()
        {
            List<double> AssignmentProjectTotalMark = new List<double>()
            {
                33.2 + GetSyntheticAssignmentProjectOralMark(),
                47.6 + GetSyntheticAssignmentProjectOralMark(),
                20.9 + GetSyntheticAssignmentProjectOralMark(),
                39.7 + GetSyntheticAssignmentProjectOralMark(),
                50.0 + GetSyntheticAssignmentProjectOralMark(),
                13.2 + GetSyntheticAssignmentProjectOralMark(),
                27.6 + GetSyntheticAssignmentProjectOralMark(),
                30.9 + GetSyntheticAssignmentProjectOralMark(),
                49.7 + GetSyntheticAssignmentProjectOralMark(),
                20.0 + GetSyntheticAssignmentProjectOralMark()
            };

            Random ran = new Random();
            return AssignmentProjectTotalMark[ran.Next(0, AssignmentProjectTotalMark.Count)];
        }

        public static DateTime GetSyntheticAssignmentProjectSubDateTime()
        {
            List<DateTime> AssignmentProjectSubDateTime = new List<DateTime>()
            {
                new DateTime(2020, 01, 10, 18, 00, 00),
                new DateTime(2020, 02, 20, 17, 00, 00),
                new DateTime(2020, 03, 30, 18, 00, 00),
                new DateTime(2020, 04, 3, 17, 00, 00),
                new DateTime(2020, 05, 4, 18, 00, 00),
                new DateTime(2020, 06, 10, 18, 00, 00),
                

            };

            Random ran = new Random();
            return AssignmentProjectSubDateTime[ran.Next(0, AssignmentProjectSubDateTime.Count)];
        }

        //Person Synthetic Data++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public static string GetSyntheticPersonFirstName()
        {
            List<string> PersonFirstNames = new List<string>()
            {
             "Eleni",
             "Giorgos",
             "Dimitris",
             "Giannis",
             "Thanasis",
             "Mitsos",
             "Konstantina",
             "Xristos",
             "Taksiarxis",
             "Dimitra",
             "Athina",
             "Periklis"

            };
            Random ran = new Random();
            return PersonFirstNames[ran.Next(0, PersonFirstNames.Count)];
        }

        public static string GetSyntheticPersonLastName()
        {
            List<string> PersonLastNames = new List<string>()
            {
             "Papapetrou",
             "Zinonos",
             "Papadopoulou",
             "Parisi",
             "Konstantinou",
             "Axileou",
             "Xhan",
             "Leontou",
             "Antonioy",
             "Liraki",
             "Gaitanou",
             "Perikleous"

            };
            Random ran = new Random();
            return PersonLastNames[ran.Next(0, PersonLastNames.Count)];
        }

        //Student Synthetic Data++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public static DateTime GetSyntheticStudentDateOfBirth()
        {
            List<DateTime> StudentDateOfBirth = new List<DateTime>()
            {
                new DateTime(1989, 01, 10),
                new DateTime(1972, 02, 21),
                new DateTime(1990, 03, 30),
                new DateTime(1994, 04, 3),
                new DateTime(1988, 05, 4),
                new DateTime(1982, 06, 1),
                new DateTime(1989, 11, 10)


            };

            Random ran = new Random();
            return StudentDateOfBirth[ran.Next(0, StudentDateOfBirth.Count)];
        }

        public static int GetSyntheticStudentFees()
        {
            List<int> StudentFees = new List<int>();
            
                for(int i = 2000; i < 2600; i += 100)
            {
                StudentFees.Add(i);
            }


            Random ran = new Random();
            return StudentFees[ran.Next(0, StudentFees.Count)];
        }

        //Trainer Synthetic Data++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public static Subject GetSyntheticTrainerSubject()
        {
            List<Subject> TrainerSubject = new List<Subject>()
            {
                Subject.AngularJSReact,
                Subject.architecture,
                Subject.BootstrapFramework,
                Subject.CloudBasedServices,
                Subject.CSharp,
                Subject.HTML_CSS,
                Subject.Java,
                Subject.JavaScript,
                Subject.SQL,
                Subject.UiUXDesign,
                Subject.UnixCommandLine,
                Subject.VersionControlGit,
                Subject.webServersApache,
                Subject.xUnit
              
            };

            Random ran = new Random();
            
            return TrainerSubject[ran.Next(0, TrainerSubject.Count)];
        }


    }
}
