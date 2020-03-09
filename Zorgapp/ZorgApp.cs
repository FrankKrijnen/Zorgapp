using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zorgapp
{
    class ZorgApp
    {
        //fields and properties
        private Profile profile;
        private List<Medicine> medicineList;
        private List<WeightMeasurePoint> weightMeasurePointData;

        //constructor
        public ZorgApp() 
        {
            //initialize class object and lists
            profile = new Profile();
            medicineList = new List<Medicine>();
            weightMeasurePointData = new List<WeightMeasurePoint>();

            //call startup methods
            AddStartData();
            DisplayMenu();
        }

        

        //methods
        //ViewData: all data?
        public void ViewData() { }
        private void GetWeightGraph() 
        { 
            
        }

        //Add static data to ZorgApp
        private void AddStartData()
        {
            //Add Profile Data
            profile.SetFirstName("Kees");
            profile.SetLastName("Straaten");
            profile.SetAge(34);
            profile.SetWeight(68.5);
            profile.SetLength(1.81);

            //Add Medicine Data to list as an new object
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

            //Add WeightMeasurePoint Data to list as an new object
            weightMeasurePointData.Add(new WeightMeasurePoint("20-04-2010", "19:40", 65.55));
            weightMeasurePointData.Add(new WeightMeasurePoint("22-02-2011", "18:35", 63.10));
        }

        //Display menu with numbers to choose from
        private void DisplayMenu() 
        {
            //keep the menu running
            while (true)
            {
                //show options with assigned numbers
                Console.Clear();
                Console.WriteLine($"Datum: {DateTime.Now}\nWelkom in het menu");
                Console.WriteLine("\nKies een nummer: " +
                    "\n1) Profiel tonen." +
                    "\n2) Medicijn tonen." +
                    "\n3) Gewicht Grafiek tonen.");

                //call method depended on chosen number
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine(ShowProfile());
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine(ShowMedicine());
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Nummer nog niet werkent! Probeer het later nog een keer..");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Nummer niet herkent! Probeer nogmaals..");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private string ShowProfile() 
        {
            return 
                $"\nVoornaam: {profile.GetFirstName()}\n" +
                $"Achternaam: {profile.GetLastName()}\n" +
                $"Leeftijd: {profile.GetAge()}\n" +
                $"Gewicht: {profile.GetWeight()}\n" +
                $"Lengte: {profile.GetLength()}\n" +
                $"BMI: {profile.GetBmi()}";
        }

        private string ShowMedicine() 
        {
            string medicineListReturn = string.Empty;
            foreach (Medicine medicine in medicineList)
            {

                medicineListReturn += 
                    $"\nMedicijnnaam: {medicine.GetMedicineName()}\n" +
                    $"Beschrijving: {medicine.GetDescription()}\n" +
                    $"Soort: {medicine.GetSort()}\n" +
                    $"Dosering: {medicine.GetDosage()}\n";
            }
            
            return medicineListReturn;
        }
    }
}
