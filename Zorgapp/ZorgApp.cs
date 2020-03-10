using System;
using System.Collections.Generic;

namespace Zorgapp
{
    class ZorgApp
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

        //display menu with numbers to choose from
        private void DisplayMenu() 
        {
            //keep the menu running
            while (true)
            {
                //clear the console screen and show options with assigned numbers
                Console.Clear();
                Console.WriteLine($"Datum: {DateTime.Now}\nWelkom in het menu");
                Console.WriteLine("\nKies een nummer: " +
                    "\n1) Profiel tonen." +
                    "\n2) Medicijn tonen." +
                    "\n3) Gewicht Grafiek tonen.");

                //call method depended on chosen number
                switch (Console.ReadLine())
                {
                    //1: get readable string of profile with ShowProfile and print to console
                    case "1":
                        Console.WriteLine(ShowProfile());
                        Console.ReadKey();
                        break;

                    //2: get readable string of medicineList with ShowMedicineList and print to console
                    case "2":
                        Console.WriteLine(ShowMedicineList());
                        Console.ReadKey();
                        break;

                    //3: get readable string of weightMeasurePointList with GetWeightGraph and print to console
                    case "3":
                        Console.WriteLine(GetWeightGraph());
                        Console.ReadKey();
                        break;

                    //else: print error message to console and return to main menu
                    default:
                        Console.WriteLine("Nummer niet herkent! Probeer nogmaals..");
                        Console.ReadKey();
                        break;
                }
            }
        }

        //show profile with field variable profile calls
        private string ShowProfile() 
        {
            //return concatanated string
            return 
                $"\nVoornaam: {profile.GetFirstName()}\n" +
                $"Achternaam: {profile.GetLastName()}\n" +
                $"Leeftijd: {profile.GetAge()}\n" +
                $"Gewicht: {profile.GetWeight()}\n" +
                $"Lengte: {profile.GetLength()}\n" +
                $"BMI: {profile.GetBmi()}";
        }

        //show medicine list with loop variable medicine calls in foreachloop
        private string ShowMedicineList() 
        {
            //initialize local string to concatanate to
            string medicineListAsString = string.Empty;
            //loop through field variable medicineList
            foreach (Medicine medicine in medicineList)
            {
                //concatanate to local string
                medicineListAsString += 
                    $"\nMedicijnnaam: {medicine.GetMedicineName()}\n" +
                    $"Beschrijving: {medicine.GetDescription()}\n" +
                    $"Soort: {medicine.GetSort()}\n" +
                    $"Dosering: {medicine.GetDosage()}\n";
            }
            //return local string
            return medicineListAsString;
        }

        //show data table with loop variable weightMeasurePoint calls in foreachloop
        private string GetWeightGraph()
        {
            //initialize local string to concatanate to
            string weightMeasurePointAsString = string.Empty;
            //loop through field variable weightMeasurePointList
            foreach (WeightMeasurePoint weightMeasurePoint in weightMeasurePointList)
            {
                //concatanate to local string
                weightMeasurePointAsString +=
                    $"\nDatum: {weightMeasurePoint.GetDate()}\n" +
                    $"Tijd: {weightMeasurePoint.GetTime()}\n" +
                    $"Gewicht: {weightMeasurePoint.GetWeight()} Kilogram\n";
            }
            //return local string
            return weightMeasurePointAsString;
        }
    }
}
