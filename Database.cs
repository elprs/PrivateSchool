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
        public List<StudentAssignment> StudentAssignments { get; set; } = new List<StudentAssignment>();

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
            Assignment a1 = new Assignment("Assignment 1", "Individual", new DateTime(2020, 02, 1), 32.2, 62.4);
            Assignment a2 = new Assignment("Assignment 2", "Individual", new DateTime(2020, 02, 1), 40.6, 95.4);
            Assignment a3 = new Assignment("Assignment 3", "Individual", new DateTime(2020, 02, 1), 25.9, 85.5);
            Assignment a4 = new Assignment("Assignment 4", "Individual", new DateTime(2020, 02, 1), 32.7, 99.4);
            Assignment a5 = new Assignment("Assignment 5", "Individual", new DateTime(2020, 02, 10), 49.9, 94.3);
            Assignment a6 = new Assignment("Assignment 6", "Individual", new DateTime(2020, 02, 10), 45.8, 98.3);
            Assignment a7 = new Assignment("Assignment 7", "Individual", new DateTime(2020, 02, 10), 32.41, 92.2);
            Assignment a8 = new Assignment("Assignment 8", "Individual", new DateTime(2020, 02, 10), 49.7, 98.3);
            Assignment a9 = new Assignment("Assignment 9", "Individual", new DateTime(2020, 02, 18), 44.6, 98.3);
            Assignment a10 = new Assignment("Assignment 10", "Individual", new DateTime(2020, 02, 20), 49.1, 98.6);
            Assignment a11 = new Assignment("Assignment 11", "Individual", new DateTime(2020, 02, 20), 49.4, 93.7);
            Assignment a12 = new Assignment("Assignment 12", "Individual", new DateTime(2020, 02, 20), 49.6, 94.6);
            Assignment a13 = new Assignment("Assignment 13", "Individual", new DateTime(2020, 02, 25), 49.8, 99.7);
            Assignment a14 = new Assignment("Assignment 14", "Individual", new DateTime(2020, 02, 28), 49.9, 98.8);
            Assignment a15 = new Assignment("Assignment 15", "Individual", new DateTime(2020, 02, 28), 49.1, 99.9);

            Assignment ap1 = new Assignment("Project 1", "Team proj.", new DateTime(2020, 03, 01), 12.2, 98.2);
            Assignment ap2 = new Assignment("Project 1", "Individual.", new DateTime(2020, 06, 01), 12.2, 89.2);
            


            Assignments.Add(a1);
            Assignments.Add(a2);
            Assignments.Add(a3);
            Assignments.Add(a4);
            Assignments.Add(a5);
            Assignments.Add(a6);
            Assignments.Add(a7);

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

            StudentAssignment sa1 = new StudentAssignment(s1, a1);
            StudentAssignment sa2 = new StudentAssignment(s2, a2);
            StudentAssignment sa3 = new StudentAssignment(s3, a3);
            StudentAssignment sa4 = new StudentAssignment(s4, a4);
            StudentAssignment sa5 = new StudentAssignment(s5, a5);
            StudentAssignment sa6 = new StudentAssignment(s6, a6);
            StudentAssignment sa7 = new StudentAssignment(s7, a7);
            StudentAssignment sa8 = new StudentAssignment(s8, a1);            
            StudentAssignment sa9 = new StudentAssignment(s9, a9);
            StudentAssignment sa10 = new StudentAssignment(s10, a10);
            StudentAssignment sa11 = new StudentAssignment(s11, a11);
            StudentAssignment sa12 = new StudentAssignment(s12, a12);
            StudentAssignment sa13 = new StudentAssignment(s13, a13);
            StudentAssignment sa14 = new StudentAssignment(s14, a14);
            StudentAssignment sa15 = new StudentAssignment(s15, a15);

            StudentAssignment sa16 = new StudentAssignment(s1, ap1);
            StudentAssignment sa17 = new StudentAssignment(s2, ap1);
            StudentAssignment sa18 = new StudentAssignment(s3, ap1);
            StudentAssignment sa19 = new StudentAssignment(s4, ap1);
            StudentAssignment sa20 = new StudentAssignment(s5, ap1);
            StudentAssignment sa21 = new StudentAssignment(s6, ap1);
            StudentAssignment sa22 = new StudentAssignment(s7, ap1);
            StudentAssignment sa23 = new StudentAssignment(s8, ap1);
            StudentAssignment sa24 = new StudentAssignment(s9, ap1);
            StudentAssignment sa25 = new StudentAssignment(s10, ap1);
            StudentAssignment sa26 = new StudentAssignment(s11, ap1);
            StudentAssignment sa27 = new StudentAssignment(s12, ap1);
            StudentAssignment sa28 = new StudentAssignment(s13, ap1);
            StudentAssignment sa29 = new StudentAssignment(s14, ap1);
            StudentAssignment sa30 = new StudentAssignment(s15, ap1);

            StudentAssignment sa31 = new StudentAssignment(s14, ap2);
            StudentAssignment sa32 = new StudentAssignment(s15, ap2);



            StudentAssignments.Add(sa1);
            StudentAssignments.Add(sa2);
            StudentAssignments.Add(sa3);
            StudentAssignments.Add(sa4);
            StudentAssignments.Add(sa5);
            StudentAssignments.Add(sa6);
            StudentAssignments.Add(sa7);
            StudentAssignments.Add(sa8);
            StudentAssignments.Add(sa9);
            StudentAssignments.Add(sa10);
            StudentAssignments.Add(sa11);
            StudentAssignments.Add(sa12);
            StudentAssignments.Add(sa13);
            StudentAssignments.Add(sa14);
            StudentAssignments.Add(sa15);
            StudentAssignments.Add(sa16);
            StudentAssignments.Add(sa17);
            StudentAssignments.Add(sa18);
            StudentAssignments.Add(sa19);
            StudentAssignments.Add(sa20);
            StudentAssignments.Add(sa21);
            StudentAssignments.Add(sa22);
            StudentAssignments.Add(sa23);
            StudentAssignments.Add(sa24);
            StudentAssignments.Add(sa25);
            StudentAssignments.Add(sa26);
            StudentAssignments.Add(sa27);
            StudentAssignments.Add(sa28);
            StudentAssignments.Add(sa29);
            StudentAssignments.Add(sa30);
            StudentAssignments.Add(sa31);
            StudentAssignments.Add(sa32);

        }
        

    }
}
