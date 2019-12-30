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
        public Trainer(Subject subject)
        {

        }
        public List<Trainer> TrainerSyntheticData()
        {
            List<Trainer> TrainerSyntheticData = new List<Trainer>();

            Trainer t1 = new Trainer(Subject.CSharp);
            Trainer t2 = new Trainer(Subject.AngularJSReact);
            Trainer t3 = new Trainer(Subject.architecture);
            Trainer t4 = new Trainer(Subject.BootstrapFramework);
            Trainer t5 = new Trainer(Subject.CSharp);
            Trainer t6 = new Trainer(Subject.HTML_CSS);
            Trainer t7 = new Trainer(Subject.BootstrapFramework);
            Trainer t8 = new Trainer(Subject.Java);
            Trainer t9 = new Trainer(Subject.SQL);
            Trainer t10 = new Trainer(Subject.SQL);
            Trainer t11 = new Trainer(Subject.UiUXDesign);
            Trainer t12 = new Trainer(Subject.webServersApache);
            Trainer t13 = new Trainer(Subject.xUnit);
            Trainer t14 = new Trainer(Subject.JavaScript);
            Trainer t15 = new Trainer(Subject.UiUXDesign);
            Trainer t16 = new Trainer(Subject.UnixCommandLine);
            Trainer t17 = new Trainer(Subject.VersionControlGit);
            Trainer t18 = new Trainer(Subject.CloudBasedServices);
            Trainer t19 = new Trainer(Subject.HTML_CSS);
            Trainer t20 = new Trainer(Subject.CSharp);

            TrainerSyntheticData.Add(t1);
            TrainerSyntheticData.Add(t2);
            TrainerSyntheticData.Add(t3);
            TrainerSyntheticData.Add(t4);
            TrainerSyntheticData.Add(t5);
            TrainerSyntheticData.Add(t6);
            TrainerSyntheticData.Add(t7);
            TrainerSyntheticData.Add(t8);
            TrainerSyntheticData.Add(t9);
            TrainerSyntheticData.Add(t10);
            TrainerSyntheticData.Add(t11);
            TrainerSyntheticData.Add(t12);
            TrainerSyntheticData.Add(t13);
            TrainerSyntheticData.Add(t14);
            TrainerSyntheticData.Add(t15);
            TrainerSyntheticData.Add(t16);
            TrainerSyntheticData.Add(t17);
            TrainerSyntheticData.Add(t18);
            TrainerSyntheticData.Add(t19);
            TrainerSyntheticData.Add(t20);

            return TrainerSyntheticData;

        }

        public void PrintTrainerSyntheticData(List<Trainer> trainerList)
        {
            
            foreach (var item in trainerList)
            {
                Console.WriteLine("Subject : {0}.", item.Subject);
                
            }
        }

    }
}
