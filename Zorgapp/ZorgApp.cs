using System;
using System.Collections.Generic;

namespace Zorgapp
{
    partial class ZorgApp
    {
        //fields and properties
        private Profile profile;
        private List<Medicine> medicineList;
        private List<WeightMeasurePoint> weightMeasurePointList;

        //constructor
        public ZorgApp()
        {
            //initialize class object and lists
            profile = new Profile();
            medicineList = new List<Medicine>();
            weightMeasurePointList = new List<WeightMeasurePoint>();

            //call startup methods
            AddStartData();
            DisplayMenu();
        }



        //methods
        //ViewData: all data?
        public void ViewData() { }



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
                "Het werkt rustgevend, spierontspannend, vermindert angstgevoelens en beïnvloedt de overdracht van elektrische prikkels in de hersenen.",
                "Oxazepam behoort tot de benzodiazepinen.",
                "50 mg per 24 uur."));
            medicineList.Add(new Medicine(
                "Diclofenac",
                "Het is te gebruiken bij pijn waarbij ook sprake is van een ontsteking, zoals bij gewrichtspijn, reumatoïde artritis (ontsteking van de gewrichten), ziekte van Bechterew en jicht (onsteking in uw gewricht).",
                "Dit soort (Diclofenac) pijnstillers wordt ook wel NSAID's genoemd.",
                "1 tablet per 6 uur."));

            //add WeightMeasurePoint data to list as a new initialized object
            weightMeasurePointList.Add(new WeightMeasurePoint("20-04-2010", "19:40", 65.55));
            weightMeasurePointList.Add(new WeightMeasurePoint("22-02-2011", "18:35", 63.11));
        }

        
        

        //show profile with field variable profile calls
        private string ShowProfile()
        {
            //return concatanated string
            return
                $"\n1) Voornaam: {profile.GetFirstName()}\n" +
                $"2) Achternaam: {profile.GetLastName()}\n" +
                $"3) Leeftijd: {profile.GetAge()}\n" +
                $"4) Gewicht: {profile.GetWeight()} Kg\n" +
                $"5) Lengte: {profile.GetLength()} M\n" +
                $"   BMI: {profile.GetBmi()}";
        }

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
            //initialize local int to count iterations
            int choice = 1;

            //initialize local string to concatanate to
            string medicineListAsString = string.Empty;

            //loop through field variable medicineList
            foreach (Medicine medicine in medicineList)
            {
                //concatanate to local string
                medicineListAsString +=
                    $"\nKeuzenummer: {choice}" +
                    $"\nMedicijnnaam: {medicine.GetMedicineName()}\n" +
                    $"Beschrijving: {medicine.GetDescription()}\n" +
                    $"Soort: {medicine.GetSort()}\n" +
                    $"Dosering: {medicine.GetDosage()}\n";

                //increment local int choice
                choice++;
            }
            //return local string
            return medicineListAsString;
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
        //todo convert string to readable string table
        private string ShowWeightMeasurePointList()
        {
            //initialize local string to concatanate to
            string weightMeasurePointAsString = string.Empty;

            //initialize local int to count iterations
            int choice = 1;
            //loop through field variable weightMeasurePointList
            foreach (WeightMeasurePoint weightMeasurePoint in weightMeasurePointList)
            {
                //concatanate to local string
                weightMeasurePointAsString +=
                    $"\nKeuzenummer: {choice}" +
                    $"\nDatum: {weightMeasurePoint.GetDate()}\n" +
                    $"Tijd: {weightMeasurePoint.GetTime()}\n" +
                    $"Gewicht: {weightMeasurePoint.GetWeight()} Kilogram\n";

                //increment local int choice
                choice++;
            }
            //return local string
            return weightMeasurePointAsString;
        }

        //edit profile
        //todo add comments
        private void EditProfile(Profile profile, int userInput) 
        {
            switch (userInput)
            {
                case 1:
                    profile.SetFirstName(Console.ReadLine());
                    break;
                case 2:
                    profile.SetLastName(Console.ReadLine());
                    break;
                case 3:
                    profile.SetAge(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 4:
                    profile.SetWeight(Convert.ToDouble(Console.ReadLine()));
                    break;
                case 5:
                    profile.SetLength(Convert.ToDouble(Console.ReadLine()));
                    break;
                default:
                    break;
            }
            return;
        }

        //edit medicine
        //todo add comments
        private void EditMedicine(Medicine medicine, int userInput) 
        {

            switch (userInput)
            {
                case 1:
                    medicine.SetMedicineName(Console.ReadLine());
                    break;
                case 2:
                    medicine.SetDescription(Console.ReadLine());
                    break;
                case 3:
                    medicine.SetSort(Console.ReadLine());
                    break;
                case 4:
                    medicine.SetDosage(Console.ReadLine());
                    break;
                default:
                    break;
            }
            return;
        }

        //edit weightmeasurepoint
        //todo add comments
        private void EditWeightMeasurePoint(WeightMeasurePoint weightMeasurePoint, int userInput) 
        {
            switch (userInput)
            {
                case 1:
                    weightMeasurePoint.SetDate(Console.ReadLine());
                    break;
                case 2:
                    weightMeasurePoint.SetTime(Console.ReadLine());
                    break;
                case 3:
                    weightMeasurePoint.SetWeight(Convert.ToDouble(Console.ReadLine()));
                    break;
                default:
                    break;
            }
            return;
        }

        //todo start alarm
        //todo add comments
        private void StartAlarm() { }

        //todo alarm to notify to take in medicine
        //todo add comments
        private void Alarm() { }
    }
}
