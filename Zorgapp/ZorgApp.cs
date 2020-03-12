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
                    "\n2) Profiel bewerken" +
                    "\n3) Medicijnlijst tonen." +
                    "\n4) Medicijn bewerken." +
                    "\n5) Gewicht tabel tonen." +
                    "\n6) Gewicht tabel bewerken.");


                //call method depended on chosen number
                switch (Console.ReadLine())
                {
                    //1: get readable string of profile with ShowProfile and print to console
                    case "1":
                        Console.WriteLine(ShowProfile());
                        Console.WriteLine("\nDruk op enter om terug naar het menu te gaan.");
                        Console.ReadKey();
                        break;

                    //todo case "2"
                    case "2":
                        Console.WriteLine(ShowProfile());
                        Console.WriteLine("\nKies een nummer om te bewerken: (1, 2, 3, 4, 5)");
                        bool showProfileAfterEdit = false;
                        switch (Console.ReadLine())
                        {

                            case "1":
                                Console.WriteLine("Voer uw voornaam in: ");
                                EditProfile(profile, 1);
                                break;
                            case "2":
                                Console.WriteLine("Voer uw achternaam in: ");
                                EditProfile(profile, 2);
                                break;
                            case "3":
                                Console.WriteLine("Voer uw leeftijd in: ");
                                EditProfile(profile, 3);
                                break;
                            case "4":
                                Console.WriteLine("Voer uw gewicht in met een comma: ");
                                EditProfile(profile, 4);
                                break;
                            case "5":
                                Console.WriteLine("Voer uw lengte in met een comma: ");
                                EditProfile(profile, 5);
                                break;
                            default:
                                showProfileAfterEdit = true;
                                break;
                        }
                        if (showProfileAfterEdit == false)
                        {
                            Console.WriteLine(ShowProfile());
                        }
                        Console.WriteLine("\nDruk op enter om terug naar het menu te gaan.");
                        Console.ReadKey();
                        break;

                    //3: get readable string of medicineList with ShowMedicineList and print to console
                    case "3":
                        Console.WriteLine(ShowMedicineList());
                        Console.WriteLine("\nDruk op enter om terug naar het menu te gaan.");
                        Console.ReadKey();
                        break;

                    //todo case "4"
                    case "4":
                        Console.WriteLine(ShowMedicineList());
                        Console.WriteLine("\nMaak een keuze om te bewerken: ");

                        string medicineIdString = Console.ReadLine();
                        if (string.IsNullOrEmpty(medicineIdString))
                        {
                            break;
                        }

                        int medicineId = 0;
                        if (Int32.TryParse(medicineIdString, out int result))
                        {
                            medicineId = result;
                        }
                        else 
                        {
                            break;
                        }
                        if (medicineList.Count < medicineId || medicineId < 1)
                        {
                            break;
                        }
                        Medicine medicine = medicineList[medicineId - 1];
                        bool showMedicineAfterEdit = false;
                        Console.WriteLine(ShowMedicine(medicine));
                        Console.WriteLine("\nKies een nummer om te bewerken: (1, 2, 3, 4)");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                EditMedicine(medicine, 1);
                                break;
                            case "2":
                                EditMedicine(medicine, 2);
                                break;
                            case "3":
                                EditMedicine(medicine, 3);
                                break;
                            case "4":
                                EditMedicine(medicine, 4);
                                break;
                            default:
                                showMedicineAfterEdit = true;
                                break;
                        }
                        if (showMedicineAfterEdit == false)
                        {
                            Console.WriteLine(ShowMedicine(medicine));
                        }
                        Console.WriteLine("\nDruk op enter om terug naar het menu te gaan.");
                        Console.ReadKey();
                        break;

                    //5: get readable string of weightMeasurePointList with GetWeightGraph and print to console
                    case "5":
                        Console.WriteLine(GetWeightTable());
                        Console.WriteLine("\nDruk op enter om terug naar het menu te gaan.");
                        Console.ReadKey();
                        break;

                    case "6":
                        Console.WriteLine(GetWeightTable());
                        Console.WriteLine("\nMaak een keuze om te bewerken: ");

                        string weightIdString = Console.ReadLine();
                        if (string.IsNullOrEmpty(weightIdString))
                        {
                            break;
                        }
                        int weightId = 0;
                        if (Int32.TryParse(weightIdString, out int result1))
                        {
                            weightId = result1;
                        }
                        else
                        {
                            break;
                        }
                        if (weightMeasurePointList.Count < weightId || weightId < 1)
                        {
                            break;
                        }

                        bool showWeightAfterEdit = false;
                        WeightMeasurePoint weightMeasurePoint = weightMeasurePointList[weightId - 1];
                        Console.WriteLine(ShowWeightMeasurePoint(weightMeasurePoint));
                        Console.WriteLine("\nKies een nummer om te bewerken: (1, 2, 3)");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine("Voer de datum in: ");
                                EditWeightMeasurePoint(weightMeasurePoint, 1);
                                break;
                            case "2":
                                Console.WriteLine("Voer de tijd in: ");
                                EditWeightMeasurePoint(weightMeasurePoint, 2);
                                break;
                            case "3":
                                Console.WriteLine("Voer uw gewicht in met een comma: ");
                                EditWeightMeasurePoint(weightMeasurePoint, 3);
                                break;
                            default:
                                showWeightAfterEdit = true;
                                break;
                        }
                        if (showWeightAfterEdit == false)
                        {
                            Console.WriteLine(ShowWeightMeasurePoint(weightMeasurePoint));
                        }
                        Console.WriteLine("\nDruk op enter om terug naar het menu te gaan.");
                        Console.ReadKey();
                        break;

                    //else: print error message to console and return to main menu
                    default:
                        Console.WriteLine("Nummer niet herkent! Probeer nogmaals..");
                        Console.WriteLine("\nDruk op enter om terug naar het menu te gaan.");
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

        //??
        private string ShowWeightMeasurePoint(WeightMeasurePoint weightMeasurePointList)
        {
            return
                    "\n1)Datum: " + weightMeasurePointList.GetDate() +
                    "\n2)Tijd: " + weightMeasurePointList.GetTime() +
                    "\n3)Gewicht: " + weightMeasurePointList.GetWeight();
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
        //todo convert string to readable string table
        private string GetWeightTable ()
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

        //todo edit profile
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

        //todo edit medicine
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

        //todo edit weightmeasurepoint
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
        private void StartAlarm() { }

        //todo alarm to notify to take in medicine
        private void Alarm() { }
    }
}
