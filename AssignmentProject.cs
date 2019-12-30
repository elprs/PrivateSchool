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

        public List<AssignmentProject> AssignmentProjectSyntheticData()
        {
            List<AssignmentProject> AssignmentProjectSyntheticData = new List<AssignmentProject>();

            AssignmentProject ap1 = new AssignmentProject();
            AssignmentProject ap2 = new AssignmentProject();
            AssignmentProject ap3 = new AssignmentProject();
            AssignmentProject ap4 = new AssignmentProject();
            AssignmentProject ap5 = new AssignmentProject();
            AssignmentProject ap6 = new AssignmentProject();
            AssignmentProject ap7 = new AssignmentProject();
            AssignmentProject ap8 = new AssignmentProject();
            AssignmentProject ap9 = new AssignmentProject();
            

            AssignmentProjectSyntheticData.Add(ap1);
            AssignmentProjectSyntheticData.Add(ap2);
            AssignmentProjectSyntheticData.Add(ap3);
            AssignmentProjectSyntheticData.Add(ap4);
            AssignmentProjectSyntheticData.Add(ap5);
            AssignmentProjectSyntheticData.Add(ap6);
            AssignmentProjectSyntheticData.Add(ap7);
            AssignmentProjectSyntheticData.Add(ap8);
            AssignmentProjectSyntheticData.Add(ap9);
            

            return AssignmentProjectSyntheticData;

        }

        public void PrintAssignementProjectSyntheticData(List<AssignmentProject> assignmentProjectList)
        {

            foreach (var item in assignmentProjectList)
            {
                Console.WriteLine("Title : {0}.", item.Title);
                Console.WriteLine("Description : {0}.", item.Description);
                Console.WriteLine("SubDateTime : {0}.", item.SubDateTime);
                Console.WriteLine("OralMark : {0}.", item.OralMark);
                Console.WriteLine("TotalMark : {0}.", item.TotalMark);


            }
        }
    }
}
