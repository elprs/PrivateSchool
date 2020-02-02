using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PrivateSchool
{
    public class Service
    {
        public static string ConString = ConfigurationManager.ConnectionStrings["ParisiConn"].ToString();
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            using (SqlConnection conn = new SqlConnection(ConString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from student", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    int id = Convert.ToInt32(reader[0]);
                    string firstName = string.IsNullOrWhiteSpace(reader[1].ToString()) ? null : reader[1].ToString();
                    string lastName = reader[2].ToString();
                    DateTime? dateOfBirth = (string.IsNullOrWhiteSpace(reader[3].ToString()) ? (DateTime?)null : Convert.ToDateTime(reader[3].ToString()));
                    int? tuitionFees = string.IsNullOrWhiteSpace(reader[4].ToString()) ? (int?)null : Convert.ToInt32(reader[4].ToString());

                    Student s = new Student(id, firstName, lastName, dateOfBirth, tuitionFees);
                    students.Add(s);
                }
                
            }

            return students;

        }
        

        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    Console.WriteLine("********************************************");
        //    Console.WriteLine("                  STUDENTS        ");
        //    Console.WriteLine($"|Id |Name Surname| Date&Time Of Birth| Fees");
        //    Console.ForegroundColor = ConsoleColor.White;
        //    while (reader.Read())
        //    {
        //        Console.WriteLine(" " + reader[0].ToString() + "  " + reader[1].ToString() + " " + reader[2].ToString() + " " + reader[3].ToString() +" " + "€ " + reader[4].ToString());
        //        Console.WriteLine();
          
        //    }
        //    reader.Close();
        //    conn.Close();
        //}
        public static void GetAllTrainers()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ParisiConn"].ToString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from trainer", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("***********************************");
            Console.WriteLine("            TRAINERS        ");
            Console.WriteLine($"|Id |Name Surname | School Subject");
            Console.ForegroundColor = ConsoleColor.White;
            while (reader.Read())
            {
                Console.WriteLine(" " + reader[0].ToString() + "  " + reader[1].ToString() + " " + reader[2].ToString() + " " + reader[3].ToString());
                Console.WriteLine();

            }
            reader.Close();
            conn.Close();
        }
        public static void GetAllAssignments()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ParisiConn"].ToString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from assignment", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("                                     ASSIGNMENTS        ");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine($"| Id |       Title       |  Description |    Submission Date |     Oral & Total Mark   ");
            Console.ForegroundColor = ConsoleColor.White;
            while (reader.Read())
            {
                Console.WriteLine("  " + reader[0].ToString() + "   " + reader[1].ToString() + "   " + reader[2].ToString() + "     " + reader[3].ToString() + "        " + reader[4].ToString() + " & " + reader[5].ToString());
                Console.WriteLine();

            }
            reader.Close();
            conn.Close();
        }
        public static void GetAllCourses()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ParisiConn"].ToString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Course", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("                                     Courses        ");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine($"| Id | Title |  Stream |  Duration Type  |    Start Date    &     End Date    ");
            Console.ForegroundColor = ConsoleColor.White;
            while (reader.Read())
            {
                Console.WriteLine("  " + reader[0].ToString() + "     " + reader[1].ToString() + "       " + reader[2].ToString() + "       " + reader[3].ToString() + "    " + reader[4].ToString() + " & " + reader[5].ToString());
                Console.WriteLine();

            }
            reader.Close();
            conn.Close();
        }



        //public static void GetAllStudentsPerCourse()
        //{ }

        //    DataSet ds = null; 
        //    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ParisiConn"].ToString());
        //    using (conn)
        //    {
        //        conn.Open();
        //        var cmd = new SqlCommand(
        //        "SELECT Title, FirstName, LastName " +
        //        "FROM Student  s" +
        //        "INNER JOIN StudentCourse sc" +
        //        "ON sc.id_student = s.id" +
        //        "INNER JOIN Course c" +
        //        "ON c.id = sc.id_course" +
        //        "ORDER BY Title; ",
        //        conn); 



        //        using (var adapter = new SqlDataAdapter(cmd))
        //        {
        //            ds = new DataSet();
        //            adapter.Fill(ds);
        //        } 

        //    var table = ds.Tables[0]; //epeksergasia ton eggrafon me tin isiaxia mou
        //    for (int i = 0; i < table.Rows.Count; i++)
        //    {
        //        var row = table.Rows[i];
        //        var lnum = row[0];
        //        var bcode = row[1];
        //        var amount = row[2];
        //        var interestrate = row[3] == DBNull.Value ? "NULL" : row[3];//dbnull.value einai auto me to topoio sigkino gia na do an mia grammi einai null

        //        Console.WriteLine($"LNUM: {lnum}, BCode: {bcode}, Amount: {amount}, Rate: {interestrate}");
        //    }





        //    Console.WriteLine("--------------------------------------------------");


               
        //    SqlDataReader reader = cmd.ExecuteReader();

        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    Console.WriteLine("**************************************************************************************");
        //    Console.WriteLine("                                     Students Per Course       ");
        //    Console.WriteLine("**************************************************************************************");
        //    Console.WriteLine($"| Title | Name |  Last Name ");
        //    Console.ForegroundColor = ConsoleColor.White;
        //    while (reader.Read())
        //    {
        //        Console.WriteLine("  " + reader[0].ToString() + "     " + reader[1].ToString() + "       " + reader[2].ToString() );
        //        Console.WriteLine();

        //    }
        //    reader.Close();
        //    conn.Close();
        //}
    }
}
