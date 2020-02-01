using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace PrivateSchool
{/// <summary>
/// A Program that handles a Private School's Data
/// Eleni Parisi, January 2020
/// </summary>
    class Program
    { // For the correction's facilitation the Menu will appear repeatedly. 
        static void Main(string[] args)
        {

          SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ParisiConn"].ToString());
            string query = "Create database parisi_eleni_individual_part_b";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Database Created Successfully");
            }
            catch(SqlException e)
            {
                Console.WriteLine("Error Generated");
            }
            finally
            {
                conn.Close();

            }




            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
            }






            Database db = new Database();

            Output.ProceedWithMenuSelection(Input.PrintMenuGetUserSelection(), db);

            Console.WriteLine("Press any letter key folloewed by enter to exit the program.");
            Console.ReadKey();
        }

    }
}
