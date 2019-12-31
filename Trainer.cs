using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{/// <summary>
/// Contains the fields, the constructors and the methods of the child class Trainer
/// </summary>
/// 
public enum Subject{ CSharp, Java, HTML_CSS, SQL, JavaScript, BootstrapFramework, AngularJSReact, VersionControlGit, architecture, webServersApache, xUnit, UnixCommandLine, UiUXDesign, CloudBasedServices
}

class Trainer : Person
    {
        public Subject Subject;

        public Trainer()
        {

        }
        public Trainer(string firstName, string lastName, Subject subject)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }
        public static List<Trainer> TrainerSyntheticData()
        {
            List<Trainer> TrainerListOfSyntheticData = new List<Trainer>();
            for (int i = 0; i < 10; i++)
            {
                Trainer t1 = new Trainer(SyntheticData.GetSyntheticPersonFirstName(), SyntheticData.GetSyntheticPersonLastName(), SyntheticData.GetSyntheticTrainerSubject());
                TrainerListOfSyntheticData.Add(t1);

            }

            return TrainerListOfSyntheticData;

        }

       

    }
}
