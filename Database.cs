using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    class Database
    {
        /// <summary>
        /// Reads data, creates synthetic data and saves them in corresponding lists
        /// </summary>

       
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
        public List<TrainerCourse> TrainerCourses { get; set; } = new List<TrainerCourse>();

        public Database()
        {
            Course c1 = new Course("CB4");
            Course c2 = new Course("CB3");
            Course c3 = new Course("CB2");
            Course c4 = new Course("CB1");

            Courses.Add(c1);
            Courses.Add(c2);
            Courses.Add(c3);
            Courses.Add(c4);



            Student s1 = new Student("Eleni", "Vasiliou", new DateTime(1992, 12, 13), 2000);
            Student s2 = new Student("Giorgos", "Zinonos", new DateTime(1993, 10, 23), 3000);
            Student s3 = new Student("Dimitris", "Papadopoulou", new DateTime(1994, 03, 10), 1500);
            Student s4 = new Student("Giannis", "Parisi", new DateTime(1998, 03, 30), 2300);
            Student s5 = new Student("Thanasis", "Konstantinou", new DateTime(1999, 01, 03), 2300);
            Student s6 = new Student("Mitsos", "Axileou", new DateTime(1999, 04, 06), 4560);
            Student s7 = new Student("Chiou", "Chanidou", new DateTime(2000, 05, 23), 1340);
            Student s8 = new Student("Xristos", "Leontou", new DateTime(1999, 11, 09), 1570);
            Student s9 = new Student("Taksiarxis", "Antonioy", new DateTime(1978, 12, 12), 1200);
            Student s10 = new Student("Dimitra", "Liraki", new DateTime(1972, 08, 21), 6700);
            Student s11 = new Student("Athina", "Gaitanou", new DateTime(1992, 10, 04), 9500);
            Student s12 = new Student("Periklis", "Perikleous", new DateTime(1997, 08, 06), 2500);

            Students.Add(s1);
            Students.Add(s2);
            Students.Add(s3);
            Students.Add(s4);
            Students.Add(s5);
            Students.Add(s6);
            Students.Add(s7);
            Students.Add(s8);
            Students.Add(s9);
            Students.Add(s10);
            Students.Add(s11);
            Students.Add(s12);



            Trainer t1 = new Trainer("Eleni", "Papapetrou", Subject.AngularJSReact);
            Trainer t2 = new Trainer("Nikos", "Zinonos", Subject.HTML_CSS);
            Trainer t3 = new Trainer("Hektor", "Papadopoulou", Subject.SQL);
            Trainer t4 = new Trainer("Panos", "Petrakis", Subject.JavaScript);
            Trainer t5 = new Trainer("Kostas", "Konstantinou", Subject.CSharp);
            Trainer t6 = new Trainer("Manos", "Axileou", Subject.Java);
            Trainer t7 = new Trainer("Katia", "Nikouli", Subject.Apache);
            Trainer t8 = new Trainer("Fillip", "Theoxarous", Subject.Bootstrap);

            Trainers.Add(t1);
            Trainers.Add(t2);
            Trainers.Add(t3);
            Trainers.Add(t4);
            Trainers.Add(t5);
            Trainers.Add(t6);
            Trainers.Add(t7);
            Trainers.Add(t8);

            StudentCourse sc1 = new StudentCourse(s1, c1);
            StudentCourse sc2 = new StudentCourse(s2, c2);
            StudentCourse sc3 = new StudentCourse(s3, c3);
            StudentCourse sc4 = new StudentCourse(s4, c4);
            StudentCourse sc5 = new StudentCourse(s5, c1);
            StudentCourse sc6 = new StudentCourse(s6, c2);
            StudentCourse sc7 = new StudentCourse(s7, c3);
            StudentCourse sc8 = new StudentCourse(s8, c4);
            StudentCourse sc9 = new StudentCourse(s9, c1);
            StudentCourse sc10 = new StudentCourse(s10, c2);
            StudentCourse sc11 = new StudentCourse(s11, c3);
            StudentCourse sc12 = new StudentCourse(s12, c4);

            StudentCourse sc13 = new StudentCourse(s12, c3);
            StudentCourse sc14 = new StudentCourse(s1, c2);
            StudentCourse sc15 = new StudentCourse(s1, c3);

            StudentCourses.Add(sc1);
            StudentCourses.Add(sc2);
            StudentCourses.Add(sc3);
            StudentCourses.Add(sc4);
            StudentCourses.Add(sc5);
            StudentCourses.Add(sc6);
            StudentCourses.Add(sc7);
            StudentCourses.Add(sc8);
            StudentCourses.Add(sc9);
            StudentCourses.Add(sc10);
            StudentCourses.Add(sc11);
            StudentCourses.Add(sc12);
            StudentCourses.Add(sc13);
            StudentCourses.Add(sc14);
            StudentCourses.Add(sc15);

            TrainerCourse tc1 = new TrainerCourse(t1, c1);
            TrainerCourse tc2 = new TrainerCourse(t2, c2);
            TrainerCourse tc3 = new TrainerCourse(t3, c3);
            TrainerCourse tc4 = new TrainerCourse(t4, c4);
            TrainerCourse tc5 = new TrainerCourse(t5, c1);
            TrainerCourse tc6 = new TrainerCourse(t6, c2);
            TrainerCourse tc7 = new TrainerCourse(t7, c3);
            TrainerCourse tc8 = new TrainerCourse(t8, c4);

            TrainerCourse tc9 = new TrainerCourse(t1, c2);
            TrainerCourse tc10 = new TrainerCourse(t2, c3);
            TrainerCourse tc11 = new TrainerCourse(t8, c2);



            TrainerCourses.Add(tc1);
            TrainerCourses.Add(tc2);
            TrainerCourses.Add(tc3);
            TrainerCourses.Add(tc4);
            TrainerCourses.Add(tc5);
            TrainerCourses.Add(tc6);
            TrainerCourses.Add(tc7);
            TrainerCourses.Add(tc8);
            TrainerCourses.Add(tc9);
            TrainerCourses.Add(tc10);
            TrainerCourses.Add(tc11);

        }
        // //Course Synthetic Data ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


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




    }
}
