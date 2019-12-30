using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    class SyntheticData
    {
        public static string GetSyntheticCourseTitle()
        {
            List<string> CourseTitles = new List<string>() 
            { 
                "CB8", 
             "CB7", 
             "CB6", 
             "CB5", 
             "CB4", 
             "CB3", 
             "CB2", 
             "CB1",
             "CJ1"
            };
            Random ran = new Random();
            return CourseTitles[ran.Next(0, CourseTitles.Count)];
        }

        public static string GetSyntheticCourseStream()
        {
            List<string> CourseStream = new List<string>()
            {
                "Java", 
                "C#"
            };
            Random ran = new Random();
            return CourseStream[ran.Next(0, CourseStream.Count)];
        }
    }
}
