using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{/// <summary>
 /// Contains the fields, properties, the constructors and the methods of the child class Trainer
 /// </summary>
 /// 
    public enum Subject{ CSharp, Java, HTML_CSS, SQL, JavaScript, Bootstrap, AngularJSReact, VersionControlGit, architecture, Apache, xUnit, UnixCommandLine, UiUXDesign, CloudBasedServices}

    class Trainer : Person
    { 
        public List<Course> Courses { get; set; } = new List<Course>();
        public Subject Subject;

        public Trainer(){}
        public Trainer(string firstName, string lastName, Subject subject) 
        { 
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }
    }
}
