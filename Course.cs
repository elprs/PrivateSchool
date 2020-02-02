using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    /// <summary>
    /// Contains the properties, the constructors and the methods of the class Course
    /// </summary>
    class Course
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime? StartDate { get; set; } = new DateTime();
        public DateTime? EndDate { get; set; } = new DateTime();

        public List<Student> Students = new List<Student>();
        public List<Trainer> Trainers = new List<Trainer>();
        public List<Assignment> Assignments = new List<Assignment>();
        

        public Course() { }
        public Course(string title, string stream, string type, DateTime startDate, DateTime endDate)
        {
            Title = title;
            Stream = stream;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
