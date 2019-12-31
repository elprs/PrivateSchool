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
        public double OralMark { get; set; }
        public double TotalMark { get; set; }

        public AssignmentProject()
        { }

        public AssignmentProject(string title, string description, DateTime subDateTime, double oralMark, double totalMark)
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
                AssignmentProject ap1 = new AssignmentProject(SyntheticData.GetSyntheticAssignmentProjectTitle(), SyntheticData.GetSyntheticAssignmentProjectDescription(), SyntheticData.GetSyntheticAssignmentProjectSubDateTime(), SyntheticData.GetSyntheticAssignmentProjectOralMark(), SyntheticData.GetSyntheticAssignmentProjectTotalMark());

                AssignmentProjectListOfSyntheticData.Add(ap1);
            }
            
            return AssignmentProjectListOfSyntheticData;

        }

       
    }
}
