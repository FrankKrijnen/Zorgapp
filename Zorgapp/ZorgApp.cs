using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Threading;
using Zorgapp.BasicClasses;

namespace Zorgapp
{
    //partial class ZorgApp #1 
    public partial class ZorgApp
    {
        //fields and properties
        private List<Profile> profileList;
        private List<Medicine> medicineList;
        private List<WeightMeasurePoint> weightMeasurePointList;
        private List<string> medicineListOfToday;

        //todo also put sentences in dictionary for english language
        

        //constructor
        public ZorgApp(bool testing = false)
        {
            //initialize class object and lists
            profileList = new List<Profile>();
            medicineList = new List<Medicine>();
            weightMeasurePointList = new List<WeightMeasurePoint>();
            medicineListOfToday = new List<string>();
            languageDictionary = new Dictionary<string, string>();

            //call startup methods
            AddStartData();
            //StartAlarm();

            if (testing)
            {
                return;
            }
            DisplayMenu();
        }

        //methods
        /*all methods get called in displaymenu method
        except for the ones in the constructor*/

        //todo add comments
        //getters
        public Profile GetProfile(int index) 
        {
            return profileList[0];
        }
        public Medicine GetMedicine(int index)
        {
            return medicineList[index];
        }
        public WeightMeasurePoint GetWeightMeasurePoint(int index)
        {
            return weightMeasurePointList[index];
        }

        //add static data to ZorgApp
        private void AddStartData()
        {
            //add language data to dictionary as new initialized object
            FillLanguageDictionary();

            //add Profile data to list as new initialized object
            profileList.Add(new Profile(
                "Kees",
                "Straaten",
                34,
                68.52,
                1.81));

            profileList.Add(new Profile(
                "Pieter",
                "Post",
                24,
                75.36,
                2.05));

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

        //returns translated word or sentence
        private string TransLang(string word)
        {
            if (language == "EN")
            {
                if (languageDictionary.TryGetValue(word, out string value))
                {
                    return value;
                }
            }
            return word;
        }

        //show profile with field variable profile calls
        private string ShowProfile(Profile profile)
        {
            return
                $"\n1) {TransLang("Voornaam")}: {profile.GetFirstName()}\n" +
                $"2) {TransLang("Achternaam")}: {profile.GetLastName()}\n" +
                $"3) {TransLang("Leeftijd")}: {profile.GetAge()}\n" +
                $"4) {TransLang("Gewicht")}: {profile.GetWeight()} Kg\n" +
                $"5) {TransLang("Lengte")}: {profile.GetLength()} M\n" +
                $"   BMI: {profile.GetBmi()}";

        }

        //show profile list with loop variable profile calls in foreachloop
        private string ShowProfileList()
        {
            //initialize local ConsoleTable to add column names
            ConsoleTable table = new ConsoleTable("#", 
                TransLang("Voornaam"), 
                TransLang("Achternaam"), 
                TransLang("Leeftijd"), 
                TransLang("Gewicht"), 
                TransLang("Lengte"),
                "BMI");

            //initialize local int to count iterations
            int choice = 1;

            table.Options.EnableCount = false;
            foreach (Profile profile in profileList)
            {
                table.AddRow(
                    choice,
                    profile.GetFirstName(),
                    profile.GetLastName(),
                    profile.GetAge(),
                    profile.GetWeight(),
                    profile.GetLength(),
                    profile.GetBmi());

                //increment local int choice
                choice++;
            }
            

            //return local ConsoleTable as string
            return table.ToString();
        }
        //show medicine with parameter medicine calls
        private string ShowMedicine(Medicine medicine)
        {
            return
                 "\n\n" +
                 $"\n1){TransLang("Medicijn")}: " + medicine.GetMedicineName() +
                 $"\n2){TransLang("Beschrijving")}: " + medicine.GetDescription() +
                 $"\n3){TransLang("Soort")}: " + medicine.GetSort() +
                 $"\n4){TransLang("Dosering")}: " + medicine.GetDosage();

        }

        //show medicine list with loop variable medicine calls in foreachloop
        private string ShowMedicineList()
        {
            //initialize local ConsoleTable to add column names
            ConsoleTable table = new ConsoleTable("#",
                TransLang("Medicijn"),
                TransLang("Beschrijving"),
                TransLang("Soort"),
                TransLang("Dosering"));

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
                    TransLang("Details na keuze"),
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
                    $"\n1){TransLang("")}Datum: " + weightMeasurePointList.GetDate() +
                    $"\n2){TransLang("Tijd")}: " + weightMeasurePointList.GetTime() +
                    $"\n3){TransLang("Gewicht")}: " + weightMeasurePointList.GetWeight();
        }

        //show data table with loop variable weightMeasurePoint calls in foreachloop
        private string ShowWeightMeasurePointList()
        {
            //initialize local ConsoleTable to add column names
            ConsoleTable table = new ConsoleTable("#",
                TransLang("Datum"),
                TransLang("Tijd"),
                TransLang("Gewicht"));
            
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
                if (medicine.GetDosage().CompareTo(DateTime.Now) < 1 && !medicineListOfToday.Contains(medicine.GetMedicineName()))
                {
                    //check in medicineListOfToday for medicine name
                    //add medicine name to medicineListOfToday
                    medicineListOfToday.Add(medicine.GetMedicineName());
                    Console.WriteLine(medicine.GetMedicineName());
                }
            }
        }

        //show all data
        //todo add comments
        private string ShowAllData() 
        {
            return
                $"\n{TransLang("Profielen")}:\n{ShowProfileList()}\n" +
                $"\n{TransLang("Medicijnen")}:\n{ShowMedicineList()}" +
                $"\n{TransLang("Gewichttabel")}:\n{ShowWeightMeasurePointList()}";
        }
    }
}
