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
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        public List<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
        public List<TrainerCourse> TrainerCourses { get; set; } = new List<TrainerCourse>();
        public List<AssignmentsPerCourse> CourseAssignments { get; set; } = new List<AssignmentsPerCourse>();
        public List<DateTime> SubmissionDates { get; set; } = new List<DateTime>();

        public Database()
        {
            Course c1 = new Course("CB4", "C # ", "Part time", new DateTime(2020, 01, 15), new DateTime(2020, 07, 15));
            Course c2 = new Course("CB3", "Java", "Part time", new DateTime(2020, 01, 15), new DateTime(2020, 07, 15));
            Course c3 = new Course("CB2", "C # ", "Full time", new DateTime(2020, 01, 15), new DateTime(2020, 04, 13));
            Course c4 = new Course("CB1", "Java", "Full time", new DateTime(2020, 01, 15), new DateTime(2020, 04, 13));

            Courses.Add(c1);
            Courses.Add(c2);
            Courses.Add(c3);
            Courses.Add(c4);



            Student s1 = new Student("Eleni", "Vasiliou", new DateTime(1992, 12, 13), 2000);
            Student s2 = new Student("Giorgos", "Zinonos", new DateTime(1993, 10, 23), 3000);
            Student s3 = new Student("Dimitris", "Papadopoulos", new DateTime(1994, 03, 10), 1500);
            Student s4 = new Student("Giannis", "Parisi", new DateTime(1998, 03, 30), 2300);
            Student s5 = new Student("Thanasis", "Konstantinou", new DateTime(1999, 01, 03), 2300);
            Student s6 = new Student("Mitsos", "Axileou", new DateTime(1999, 04, 06), 4560);
            Student s7 = new Student("Chiou", "Chanidou", new DateTime(2000, 05, 23), 1340);
            Student s8 = new Student("Xristos", "Leontou", new DateTime(1999, 11, 09), 1570);
            Student s9 = new Student("Taksiarxis", "Antonioy", new DateTime(1978, 12, 12), 1200);
            Student s10 = new Student("Dimitra", "Liraki", new DateTime(1972, 08, 21), 6700);
            Student s11 = new Student("Athina", "Gaitanou", new DateTime(1992, 10, 04), 9500);
            Student s12 = new Student("Periklis", "Perikleous", new DateTime(1997, 08, 06), 2500);
            Student s13 = new Student("Periklis", "Perikleous", new DateTime(2000, 02, 04), 2500);
            Student s14 = new Student("Periklis", "Perikleous", new DateTime(2001, 08, 12), 2500);
            Student s15 = new Student("Periklis", "Perikleous", new DateTime(2002, 03, 06), 2500);

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
            Students.Add(s13);
            Students.Add(s14);
            Students.Add(s15);



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

      

            //Παραδοχη: καθε assignment anikei se 1 mathiti, alla ta 2 projects (ap1, ap2) anikoun kai se perissoterous
            Assignment a1 = new Assignment("Assignment 1", " Individual", new DateTime(2020, 02, 1), 32.2, 62.4);
            Assignment a2 = new Assignment("Assignment 2", " Individual", new DateTime(2020, 02, 1), 40.6, 95.4);
            Assignment a3 = new Assignment("Assignment 3", " Individual", new DateTime(2020, 02, 1), 25.9, 85.5);
            Assignment a4 = new Assignment("Assignment 4", " Individual", new DateTime(2020, 02, 1), 32.7, 99.4);
            Assignment a5 = new Assignment("Assignment 5", " Individual", new DateTime(2020, 02, 08), 49.9, 94.3);
            Assignment a6 = new Assignment("Assignment 6", " Individual", new DateTime(2020, 02, 08), 45.8, 98.3);
            Assignment a7 = new Assignment("Assignment 7", " Individual", new DateTime(2020, 02, 08), 32.41, 92.2);
            Assignment a8 = new Assignment("Assignment 8", " Individual", new DateTime(2020, 02, 08), 49.7, 98.3);
            Assignment a9 = new Assignment("Assignment 9", " Individual", new DateTime(2020, 02, 15), 44.6, 98.3);
            Assignment a10 = new Assignment("Assignment 10", "Individual", new DateTime(2020, 02, 15), 49.1, 98.6);
            Assignment a11 = new Assignment("Assignment 11", "Individual", new DateTime(2020, 02, 15), 49.4, 93.7);
            Assignment a12 = new Assignment("Assignment 12", "Individual", new DateTime(2020, 02, 15), 49.6, 94.6);
            Assignment a13 = new Assignment("Assignment 13", "Individual", new DateTime(2020, 02, 22), 49.8, 99.7);
            Assignment a14 = new Assignment("Assignment 14", "Individual", new DateTime(2020, 02, 22), 49.9, 98.8);
            Assignment a15 = new Assignment("Assignment 15", "Individual", new DateTime(2020, 02, 22), 49.1, 99.9);

            Assignment ap1 = new Assignment("Project 1    ", "Team proj.", new DateTime(2020, 02, 29), 12.2, 98.2);
            Assignment ap2 = new Assignment("Project 1    ", "Individual.", new DateTime(2020, 06, 06), 12.2, 89.2);
            
            Assignments.Add(a1);
            Assignments.Add(a2);
            Assignments.Add(a3);
            Assignments.Add(a4);
            Assignments.Add(a5);
            Assignments.Add(a6);
            Assignments.Add(a7); 
            Assignments.Add(a8);
            Assignments.Add(a9);
            Assignments.Add(a10);
            Assignments.Add(a11);
            Assignments.Add(a12);
            Assignments.Add(a13);
            Assignments.Add(a14);
            Assignments.Add(a15);
            Assignments.Add(ap1);
            Assignments.Add(ap2);

            foreach (Assignment assignment in Assignments)
            {
                SubmissionDates.Add(assignment.SubDateTime);
            }

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



            AssignmentsPerCourse ac1 = new AssignmentsPerCourse(a1, c1);
            AssignmentsPerCourse ac2 = new AssignmentsPerCourse(a2, c1);
            AssignmentsPerCourse ac3 = new AssignmentsPerCourse(a3, c1);
            AssignmentsPerCourse ac4 = new AssignmentsPerCourse(a4, c1);
            AssignmentsPerCourse ac5 = new AssignmentsPerCourse(a5, c2);
            AssignmentsPerCourse ac6 = new AssignmentsPerCourse(a6, c2);
            AssignmentsPerCourse ac7 = new AssignmentsPerCourse(a7, c2);
            AssignmentsPerCourse ac8 = new AssignmentsPerCourse(a8, c2);
            AssignmentsPerCourse ac9 = new AssignmentsPerCourse(a9, c3);
            AssignmentsPerCourse ac10 = new AssignmentsPerCourse(a10, c3);
            AssignmentsPerCourse ac11 = new AssignmentsPerCourse(a11, c3);
            AssignmentsPerCourse ac12 = new AssignmentsPerCourse(a12, c4);           
            AssignmentsPerCourse ac13 = new AssignmentsPerCourse(a13, c4);
            AssignmentsPerCourse ac14 = new AssignmentsPerCourse(a14, c4);
            AssignmentsPerCourse ac15 = new AssignmentsPerCourse(a15, c4);

            AssignmentsPerCourse apc1 = new AssignmentsPerCourse(ap1, c1);
            AssignmentsPerCourse apc2 = new AssignmentsPerCourse(ap1, c2);
            AssignmentsPerCourse apc3 = new AssignmentsPerCourse(ap1, c3);
            AssignmentsPerCourse apc4 = new AssignmentsPerCourse(ap1, c4);

            AssignmentsPerCourse apc5 = new AssignmentsPerCourse(ap2, c3);
            AssignmentsPerCourse apc6 = new AssignmentsPerCourse(ap2, c4);


            CourseAssignments.Add(ac1);
            CourseAssignments.Add(ac2);
            CourseAssignments.Add(ac3);
            CourseAssignments.Add(ac4);
            CourseAssignments.Add(ac5);
            CourseAssignments.Add(ac6);
            CourseAssignments.Add(ac7);
            CourseAssignments.Add(ac8);
            CourseAssignments.Add(ac9);
            CourseAssignments.Add(ac10);
            CourseAssignments.Add(ac11);
            CourseAssignments.Add(ac12);
            CourseAssignments.Add(ac13);
            CourseAssignments.Add(ac14);
            CourseAssignments.Add(ac15);
            CourseAssignments.Add(apc1);
            CourseAssignments.Add(apc2);
            CourseAssignments.Add(apc3);
            CourseAssignments.Add(apc4);
            CourseAssignments.Add(apc5);
            CourseAssignments.Add(apc6);
        }
        

    }

}
