using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{/// <summary>
/// Contains the fields, the constructors and the methods of the child class Trainer
/// </summary>
    class Trainer : Person
    {
        private enum Subject { CSharp, Java, HTML_CSS, SQL, JavaScript, BootstrapFramework, AngularJSReact, VersionControlGit, architecture, webServersApache, xUnit, UnixCommandLine, UiUXDesign, CloudBasedServices}

        public Trainer()
        {

        }
        public override void FillPersonProperty()
        {
            FirstName = "Giorgos";
            LastName = "Kotopoulos";
            Subject subj = Subject.CSharp;
        }

    }
}
