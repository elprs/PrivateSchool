using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace PrivateSchool
{/// <summary>
/// A Program that handles a Private School's Data
/// Eleni Parisi, January 2020
/// </summary>
    class Program
    { // For the correction's facilitation the Menu will appear repeatedly. 
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            //Queries.SelectAllStudents();
            //Queries.SelectAllTrainers();
            //Queries.SelectAllAssignments();
            //Queries.SelectAllCourses();
            Queries.SelectAllStudentsPerCourse();




            //Database db = new Database();

            //Output.ProceedWithMenuSelection(Input.PrintMenuGetUserSelection(), db);

            //Console.WriteLine("Press any letter key folloewed by enter to exit the program.");

            Console.ReadKey();
        }

    }
}
