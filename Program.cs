using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{/// <summary>
/// Contains the Main method
/// Eleni Parisi, January 2020
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            PrivateSchool privateSchool = new PrivateSchool();
            PrivateSchool.ExecuteMenuSelection(PrivateSchool.GetMenuSelection());
           
            

            


            Console.WriteLine("Press any letter key to exit the program.");
            Console.ReadKey();
        }
    }
}
