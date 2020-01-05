using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{/// <summary>
/// Contains the fields, the constructors and the methods of the class AssignmentProject
/// </summary>
    class Assignment
    {
        
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public double OralMark { get; set; } // παραδοχη max  oral mark: 50.0
        public double TotalMark { get; set; } //παραδοχη max  total mark: 100.0

        public List<Student> Students = new List<Student>();
        public List<Course> Courses { get; set; } = new List<Course>();
        public Assignment(string title, string description, DateTime subDateTime, double oralMark, double totalMark)
        {
            Title = title;
            Description = description;
            SubDateTime = subDateTime;
            OralMark = oralMark;
            TotalMark = totalMark;
        }

        //public static List<AssignmentProject> AssignmentProjectSyntheticData()
        //{
        //    List<AssignmentProject> AssignmentProjectListOfSyntheticData = new List<AssignmentProject>();

        //    for (int i = 0; i < 9; i++)
        //    {
        //        AssignmentProject ap1 = new AssignmentProject(Database.GetSyntheticAssignmentProjectTitle(), Database.GetSyntheticAssignmentProjectDescription(), Database.GetSyntheticAssignmentProjectSubDateTime(), Database.GetSyntheticAssignmentProjectOralMark(), Database.GetSyntheticAssignmentProjectTotalMark());

        //        AssignmentProjectListOfSyntheticData.Add(ap1);
        //        Console.WriteLine("The assignment/project is now added to the corresponding list.");
        //    }

        //    return AssignmentProjectListOfSyntheticData;

        //}
        //public static List<AssignmentProject> AddAssignmentProjectManually()
        //{
        //    List<AssignmentProject> AssignmentProjectListOfManualData = new List<AssignmentProject>();
        //    Output privateSchool = new Output();
        //    bool addMore = true;
        //    bool isInputValid;
        //    string input = "y";

        //    do
        //    {
        //        AssignmentProject ap1 = new AssignmentProject();

        //        Console.WriteLine("AssignmentProject's title:");
        //        ap1.Title = Console.ReadLine();
        //        Console.WriteLine("AssignmentProject's description (assignment or project):");
        //        ap1.Description = Console.ReadLine();

        //        do
        //        {
        //            try
        //            {
        //                Console.WriteLine("AssignmentProject's submission date in the following form:\nyear/month/day e.g. 2020/01/01):");
        //                ap1.SubDateTime = Convert.ToDateTime(Console.ReadLine());
        //                isInputValid = true;

        //            }
        //            catch (Exception)
        //            {
        //                Console.WriteLine("Your input was invalid, consult the following example.");
        //                Console.WriteLine();
        //                isInputValid = false;
        //            }
        //        } while (isInputValid == false);

        //        do
        //        {
        //            try
        //            {   //maximum oral mark : 50.0
        //                do
        //                {
        //                    Console.WriteLine("AssignmentProject's oral mark:\ne.g. 30.2");
        //                    ap1.OralMark = Convert.ToDouble(Console.ReadLine());
        //                    isInputValid = true; 
        //                } while (!(ap1.OralMark >= 0.0 && ap1.OralMark <= 50.0));

        //            }
        //            catch (Exception)
        //            {
        //                Console.WriteLine("Your input was invalid, consult the format of the following example.");
        //                Console.WriteLine();
        //                isInputValid = false;
        //            }
        //        } while (isInputValid == false);

        //        do
        //        {
        //            try
        //            {   //maximum Total mark : 100.0
        //                do
        //                {
        //                    Console.WriteLine("AssignmentProject's Total mark:\ne.g. 70.2");
        //                    ap1.TotalMark = Convert.ToDouble(Console.ReadLine());
        //                    isInputValid = true;
        //                } while (!(ap1.TotalMark >= 0.0 && ap1.TotalMark <= 100.0));

        //            }
        //            catch (Exception)
        //            {
        //                Console.WriteLine("Your input was invalid, consult the format of the following example.");
        //                Console.WriteLine();
        //                isInputValid = false;
        //            }
        //        } while (isInputValid == false);

        //        AssignmentProjectListOfManualData.Add(ap1);
        //        Console.WriteLine("The AssignmentProject is added to the AssignmentProject list.");


        //        //Let the user choose to add more AssignmentProjects

        //        do
        //        {
        //            try
        //            {

        //                Console.ForegroundColor = ConsoleColor.Cyan;
        //                Console.WriteLine();
        //                Console.WriteLine("If you would you like to add another AssignmentProject, please type the key 'y' followed by 'enter'.");
        //                Console.ForegroundColor = ConsoleColor.White;
        //                input = Console.ReadLine();



        //                if (input.ToLower() == "y")
        //                {
        //                    addMore = true;
        //                }
        //                else
        //                {
        //                    addMore = false;
        //                    privateSchool.ExecuteMenuSelection(Output.GetMenuSelection());

        //                }

        //                isInputValid = true;

        //            }
        //            catch (Exception)
        //            {
        //                Console.WriteLine("Your input was invalid.");
        //                Console.WriteLine();
        //                isInputValid = false;
        //            }
        //        } while (isInputValid == false);

        //    }
        //    while (addMore);



        //    return AssignmentProjectListOfManualData;

        //}


    }
}
