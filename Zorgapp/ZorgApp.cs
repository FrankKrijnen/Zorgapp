using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Zorgapp
{
    //partial class ZorgApp #1 
    public partial class ZorgApp
    {
        //fields and properties
        private Profile profile;
        private List<Medicine> medicineList;
        private List<WeightMeasurePoint> weightMeasurePointList;
        private List<string> medicineListOfToday;

        //constructor
        public ZorgApp(bool testing = false)
        {
            //initialize class object and lists
            //todo profile to list of profile objects
            profile = new Profile();
            medicineList = new List<Medicine>();
            weightMeasurePointList = new List<WeightMeasurePoint>();
            medicineListOfToday = new List<string>();

            //call startup methods
            AddStartData();
            //StartAlarm();

            //todo change output from show methods to ConsoleTable's
            if (testing)
            {
                return;
            }
            DisplayMenu();
        }

        //methods
        /*all methods get called in displaymenu method
        except for the ones in the constructor*/


        //getters
        public Profile GetProfile() 
        {
            return this.profile;
        }

        //add static data to ZorgApp
        private void AddStartData()
        {
            //add Profile data through profile setters
            profile.SetFirstName("Kees");
            profile.SetLastName("Straaten");
            profile.SetAge(34);
            profile.SetWeight(68.5);
            profile.SetLength(1.81);

            //add Medicine data to list as a new initialized object
            medicineList.Add(new Medicine(
                "Oxazepam",
                "Het werkt rustgevend.",
                "Benzodiazepinen.",
                DateTime.Today.AddHours(20).AddMinutes(19)));

            medicineList.Add(new Medicine(
                "Diclofenac",
                "Te gebruiken bij een ontsteking.",
                "NSAID",
                DateTime.Today.AddHours(9).AddMinutes(10)));

            //add WeightMeasurePoint data to list as a new initialized object
            weightMeasurePointList.Add(new WeightMeasurePoint("20-04-2010", "19:40", 65.55));
            weightMeasurePointList.Add(new WeightMeasurePoint("22-02-2011", "18:35", 63.11));
        }

        //show profile with field variable profile calls
        private string ShowProfile()
        {
            //initialize local ConsoleTable to add column names
            ConsoleTable table = new ConsoleTable("Voornaam(1)", "Achternaam(2)", "Leeftijd(3)", "Gewicht(4)", "Lengte(5)", "BMI");

            //initialize local int to count iterations
            int choice = 1;
            table.Options.EnableCount = false;

            table.AddRow(
                    //choice,
                    profile.GetFirstName(),
                    profile.GetLastName(),
                    profile.GetAge(),
                    profile.GetWeight(),
                    profile.GetLength(),
                    profile.GetBmi());
            /*$"\n1) Voornaam: {profile.GetFirstName()}\n" +
                $"2) Achternaam: {profile.GetLastName()}\n" +
                $"3) Leeftijd: {profile.GetAge()}\n" +
                $"4) Gewicht: {profile.GetWeight()} Kg\n" +
                $"5) Lengte: {profile.GetLength()} M\n" +
                $"   BMI: {profile.GetBmi()}";*/

            //return local ConsoleTable as string
            return table.ToString();
        }

        //show medicine with parameter medicine calls
        private string ShowMedicine(Medicine medicine)
        {
            return
                 "\n\n" +
                 "\n1)Medicijn: " + medicine.GetMedicineName() +
                 "\n2)Beschrijving: " + medicine.GetDescription() +
                 "\n3)Soort: " + medicine.GetSort() +
                 "\n4)Dosering: " + medicine.GetDosage();

        }

        //show medicine list with loop variable medicine calls in foreachloop
        private string ShowMedicineList()
        {
            //initialize local ConsoleTable to add column names
            ConsoleTable table = new ConsoleTable("#", "Naam", "Beschrijving", "Soort", "Dosering");

            //initialize local int to count iterations
            int choice = 1;

            //initialize local string to concatanate to
            table.Options.EnableCount = false;

            //loop through field variable medicineList
            foreach (Medicine medicine in medicineList)
            {
                //add row to table
                table.AddRow(
                    choice,
                    medicine.GetMedicineName(),
                    "Details na keuze",
                    medicine.GetSort(),
                    medicine.GetDosage());

                //increment local int choice
                choice++;
            }

            //return local ConsoleTable as string
            return table.ToString();
        }

        //show weightMeasurePoint from list
        private string ShowWeightMeasurePoint(WeightMeasurePoint weightMeasurePointList)
        {
            return
                    "\n1)Datum: " + weightMeasurePointList.GetDate() +
                    "\n2)Tijd: " + weightMeasurePointList.GetTime() +
                    "\n3)Gewicht: " + weightMeasurePointList.GetWeight();
        }

        //show data table with loop variable weightMeasurePoint calls in foreachloop
        private string ShowWeightMeasurePointList()
        {
            //initialize local ConsoleTable to add column names
            ConsoleTable table = new ConsoleTable("Keuze", "Datum", "Tijd", "Gewicht");
            
            //initialize local int to count iterations
            int choice = 1;
            table.Options.EnableCount = false;

            //loop through field variable weightMeasurePointList
            foreach (WeightMeasurePoint weightMeasurePoint in weightMeasurePointList)
            {
                //add row to table
                table.AddRow(
                    choice,
                    weightMeasurePoint.GetDate(), 
                    weightMeasurePoint.GetTime(), 
                    weightMeasurePoint.GetWeight()+" Kg");

                //increment local int choice
                choice++;
            }
            //return local ConsoleTable as string
            return table.ToString();
        }

        //edit profile
        //todo add comments
        private void EditProfile(Profile profile, int choice, string editValue = "") 
        {
            switch (choice)
            {
                case 1:
                    profile.SetFirstName(editValue);
                    break;
                case 2:
                    profile.SetLastName(editValue);
                    break;
                case 3:
                    profile.SetAge(Convert.ToInt32(editValue));
                    break;
                case 4:
                    profile.SetWeight(Convert.ToDouble(editValue));
                    break;
                case 5:
                    profile.SetLength(Convert.ToDouble(editValue));
                    break;
                default:
                    break;
            }
            return;
        }

        //edit medicine
        //todo add comments
        private void EditMedicine(Medicine medicine, int choice, string EditValue = "") 
        {

            switch (choice)
            {
                case 1:
                    medicine.SetMedicineName(EditValue);
                    break;
                case 2:
                    medicine.SetDescription(EditValue);
                    break;
                case 3:
                    medicine.SetSort(EditValue);
                    break;
                case 4:
                    //medicine.SetDosage(Console.ReadLine());
                    break;
                default:
                    break;
            }
            return;
        }

        //edit weightmeasurepoint
        //todo add comments
        private void EditWeightMeasurePoint(WeightMeasurePoint weightMeasurePoint, int choice, string EditValue = "") 
        {
            switch (choice)
            {
                case 1:
                    weightMeasurePoint.SetDate(EditValue);
                    break;
                case 2:
                    weightMeasurePoint.SetTime(EditValue);
                    break;
                case 3:
                    weightMeasurePoint.SetWeight(Convert.ToDouble(EditValue));
                    break;
                default:
                    break;
            }
            return;
        }

        //start alarm with timercallback, handling calls from new timer object
        private void StartAlarm() 
        {
            //initialize new timer object with timercallback calling alarm method
            Timer timer = new Timer(new TimerCallback(Alarm));

            //change timer properties: 10 seconds initial delay. 5 seconds between each call
            timer.Change(10000, 5000);
        }

        //alarm to notify to take in medicine
        private void Alarm(object state) 
        {
            //object state is timer object from StartAlarm: not yet used.

            foreach (Medicine medicine in medicineList)
            {
                //compare datetime from medicine intake with current datetime
                if (medicine.GetDosage().CompareTo(DateTime.Now) < 1)
                {
                    //check in medicineListOfToday for medicine name
                    if (!medicineListOfToday.Contains(medicine.GetMedicineName()))
                    {
                        //add medicine name to medicineListOfToday
                        medicineListOfToday.Add(medicine.GetMedicineName());
                        Console.WriteLine(medicine.GetMedicineName());
                    }
                }
            }
        }

        //show all data
        //todo add comments
        private string ShowAllData() 
        {
            return
                $"\nProfiel:\n{ShowProfile()}\n" +
                $"\nMedicijnen:\n{ShowMedicineList()}" +
                $"\nGewichttabel:\n{ShowWeightMeasurePointList()}";
        }
    }
}
