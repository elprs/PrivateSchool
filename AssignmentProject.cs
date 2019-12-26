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
        private string Title { get; set; }
        private string Description { get; set; }
        private DateTime SubDateTime { get; set; }
        private float OralMark { get; set; }
        private float TotalMark { get; set; }

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

        public void FillAssignmentProjectProperty()
        {
            Title = "Assignment A";
            Description = "Individual";
            SubDateTime = DateTime.Now;
            OralMark = 100.0f;
            TotalMark = 100.0f;
            Console.WriteLine("The assignment/project details are filled automatically");

        }
    }
}
