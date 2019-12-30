using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{/// <summary>
/// Contains the fields, the constructors and the methods of the class AssignmentProject
/// </summary>
    class AssignmentProject
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public float OralMark { get; set; }
        public float TotalMark { get; set; }

        public AssignmentProject()
        { }

        public AssignmentProject(string title, string description, DateTime subDateTime, float oralMark, float totalMark)
        {
            Title = title;
            Description = description;
            SubDateTime = subDateTime;
            OralMark = oralMark;
            TotalMark = totalMark;
        }

        public static List<AssignmentProject> AssignmentProjectListOfSyntheticData()
        {
            List<AssignmentProject> AssignmentProjectListOfSyntheticData = new List<AssignmentProject>();

            for (int i = 0; i < 9; i++)
            {
                AssignmentProject ap1 = new AssignmentProject();

                AssignmentProjectListOfSyntheticData.Add(ap1);
            }
            
            return AssignmentProjectListOfSyntheticData;

        }

        public static void PrintAssignementProjectSyntheticData(List<AssignmentProject> assignmentProjectList)
        {

            foreach (var item in assignmentProjectList)
            {
                Console.WriteLine("Title : {0}.", item.Title);
                Console.WriteLine("Description : {0}.", item.Description);
                Console.WriteLine("SubDateTime : {0}.", Convert.ToString(item.SubDateTime));
                Console.WriteLine("OralMark : {0}.", item.OralMark);
                Console.WriteLine("TotalMark : {0}.", item.TotalMark);


            }
        }
    }
}
