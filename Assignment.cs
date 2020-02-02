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
        public int id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? SubDateTime { get; set; }
        public double? OralMark { get; set; } // παραδοχη max  oral mark: 50.0
        public double? TotalMark { get; set; } //παραδοχη max  total mark: 100.0

        public List<Student> Students = new List<Student>();
        public List<Course> Courses { get; set; } = new List<Course>();

        public Assignment()
        {

        }
        public Assignment(string title, string description, DateTime subDateTime, double oralMark, double totalMark)
        {
            Title = title;
            Description = description;
            SubDateTime = subDateTime;
            OralMark = oralMark;
            TotalMark = totalMark;
        }
    }
}
