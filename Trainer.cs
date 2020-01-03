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
public enum Subject{ CSharp, Java, HTML_CSS, SQL, JavaScript, BootstrapFramework, AngularJSReact, VersionControlGit, architecture, webServersApache, xUnit, UnixCommandLine, UiUXDesign, CloudBasedServices}

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
                Console.WriteLine("The trainer is added to the list.");


            }

            return TrainerListOfSyntheticData;

        }

        public static List<Trainer> AddTrainerManually()
        {
            List<Trainer> TrainerListOfManualData = new List<Trainer>();
            PrivateSchool privateSchool = new PrivateSchool();
            bool addMore = true;
            bool isInputValid;
            string input = "y";

            do
            {
                Trainer t1 = new Trainer();

                Console.WriteLine("Trainer's first name:");
                t1.FirstName = Console.ReadLine();
                Console.WriteLine("Trainer's last name:");
                t1.LastName = Console.ReadLine();
                
                do
                {
                    try
                    {
                        Console.WriteLine("Please insert the trainer's subject. Type an option as shown in the following list: CSharp, Java, HTML_CSS, SQL, JavaScript, BootstrapFramework, AngularJSReact, VersionControlGit, architecture, webServersApache, xUnit, UnixCommandLine, UiUXDesign, CloudBasedServices");
                        t1.Subject = (Subject)Enum.Parse(typeof(Subject), Console.ReadLine());
                        isInputValid = true;

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Your input was invalid, please type the correct subject exactly as shown in the list.");
                        Console.WriteLine();
                        isInputValid = false;
                    }
                } while (isInputValid == false);

                
                TrainerListOfManualData.Add(t1);
                Console.WriteLine("The trainer is added to the Trainer list.");


                //Let the user choose to add more Trainers

                do
                {
                    try
                    {

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine();
                        Console.WriteLine("If you would you like to add another Trainer, please type the key 'y' followed by 'enter'.");
                        Console.ForegroundColor = ConsoleColor.White;
                        input = Console.ReadLine();



                        if (input.ToLower() == "y")
                        {
                            addMore = true;
                        }
                        else
                        {
                            addMore = false;
                            privateSchool.ExecuteMenuSelection(PrivateSchool.GetMenuSelection());

                        }

                        isInputValid = true;

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Your input was invalid.");
                        Console.WriteLine();
                        isInputValid = false;
                    }
                } while (isInputValid == false);

            }
            while (addMore);



            return TrainerListOfManualData;

        }



    }
}
