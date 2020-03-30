using System;
using Zorgapp.BasicClasses;

namespace Zorgapp 
{
    //partial class ZorgApp #2
    partial class ZorgApp
    {
 
        //display menu with numbers to choose from
        private void DisplayMenu()
        {
            //keep the menu running
            while (true)
            {
                //{TransLang("")}
                //clear the console screen and show options with assigned numbers
                Console.Clear();
                Console.WriteLine($"{TransLang("Datum")}: {DateTime.Now}\n{TransLang("Welkom in het menu")}");
                Console.WriteLine($"\n{TransLang("Kies een nummer")}:\n " +
                    $"\n1) {TransLang("Profiellijst tonen")}." +
                    $"\n2) {TransLang("Profiel bewerken")}." +
                    $"\n3) {TransLang("Medicijnlijst tonen")}." +
                    $"\n4) {TransLang("Medicijn bewerken")}." +
                    $"\n5) {TransLang("Gewicht tabel tonen")}." +
                    $"\n6) {TransLang("Gewicht tabel bewerken")}." +
                    $"\n7) {TransLang("Alle gegevens tonen")}." +
                    $"\n8) {TransLang("Switch to English")}.");


                //call method depended on chosen number
                
                switch (Console.ReadLine())
                {
                    //case 1: get readable string of profileList with ShowProfile and print to console
                    case "1":
                        #region
                        //show profilelist
                        Console.WriteLine(ShowProfileList());

                        //return to menu on keypress
                        Console.WriteLine($"\n{TransLang("Druk op enter om terug naar het menu te gaan")}.");
                        Console.ReadKey();
                        break;
                    #endregion

                    //case 2: edit profile attribute based on number of choices
                    case "2":
                        #region
                        //show profile table with numbers to choose from
                        Console.WriteLine(ShowProfileList());
                        Console.WriteLine($"\n{TransLang("Maak een keuze om te bewerken")}: ");

                        //checks on userinput
                        string profileIdString = Console.ReadLine();

                        //break if checks fail
                        if (!ChoiceCheck(profileIdString, profileList, out int profileId))
                        {
                            break;
                        }

                        //get profile from list
                        Profile profile = profileList[profileId - 1];

                        //present user with number choices
                        Console.Clear();
                        Console.WriteLine(ShowProfile(profile));
                        Console.WriteLine($"\n{TransLang("Kies een nummer om te bewerken")}: (1, 2, 3, 4, 5)");

                        //edit profile with userinput based on number
                        EditProfileSwitch(profile, Console.ReadLine());

                        //return to menu on keypress
                        Console.WriteLine($"\n{TransLang("Druk op enter om terug naar het menu te gaan")}.");
                        Console.ReadKey();
                        break;
                    #endregion

                    //case 3: get readable string of medicineList with ShowMedicineList and print to console
                    case "3":
                        #region
                        //show medicine list
                        Console.WriteLine(ShowMedicineList());

                        //return to menu on keypress
                        Console.WriteLine($"\n{TransLang("Druk op enter om terug naar het menu te gaan")}.");
                        Console.ReadKey();
                        break;
                    #endregion

                    //case 4: edit medicine attribute in medicineList based on number of choices
                    case "4":
                        #region
                        //show medicine table with numbers to choose from
                        Console.WriteLine(ShowMedicineList());
                        Console.WriteLine($"\n{TransLang("Maak een keuze om te bewerken")}: ");

                        //checks on userinput
                        string medicineIdString = Console.ReadLine();

                        //break if checks fail
                        if (!ChoiceCheck(medicineIdString, medicineList, out int medicineId))
                        {
                            break;
                        }

                        //get medicine from list
                        Medicine medicine = medicineList[medicineId - 1];

                        //present user with number choices
                        Console.Clear();
                        Console.WriteLine(ShowMedicine(medicine));
                        Console.WriteLine($"\n{TransLang("Kies een nummer om te bewerken")}: (1, 2, 3, 4, 5)");

                        //edit medicine with userinput based on number
                        EditMedicineSwitch(medicine, Console.ReadLine());

                        //return to menu on keypress
                        Console.WriteLine($"\n{TransLang("Druk op enter om terug naar het menu te gaan")}.");
                        Console.ReadKey();
                        break;
                    #endregion

                    //case 5: get readable string of weightMeasurePointList with GetWeightGraph and print to console
                    case "5":
                        #region
                        //show weight table
                        Console.WriteLine(ShowWeightMeasurePointList());

                        //return to menu on keypress
                        Console.WriteLine($"\n{TransLang("Druk op enter om terug naar het menu te gaan")}.");
                        Console.ReadKey();
                        break;
                    #endregion

                    //case 6: edit weightMeasurePoint attribute in weightMeasurePointList based on number of choices
                    case "6":
                        #region
                        //show weight table with numbers to choose from
                        Console.WriteLine(ShowWeightMeasurePointList());
                        Console.WriteLine($"\n{TransLang("Maak een keuze om te bewerken")}: ");

                        //checks on userinput
                        string weightIdString = Console.ReadLine();

                        //break if checks fail
                        if (!ChoiceCheck(weightIdString, weightMeasurePointList, out int weightId))
                        {
                            break;
                        }

                        //get weightMeasurePoint from list
                        WeightMeasurePoint weightMeasurePoint = weightMeasurePointList[weightId - 1];

                        //present user with number choices
                        Console.Clear();
                        Console.WriteLine(ShowWeightMeasurePoint(weightMeasurePoint));
                        Console.WriteLine($"\n{TransLang("Kies een nummer om te bewerken")}: (1, 2, 3)");

                        //edit weightMeasurePoint with userinput based on number
                        EditWeightSwitch(weightMeasurePoint, Console.ReadLine());

                        //return to menu on keypress
                        Console.WriteLine($"\n{TransLang("Druk op enter om terug naar het menu te gaan")}.");
                        Console.ReadKey();
                        break;
                    #endregion

                    //case 7: show and print all data from lists and profile to console
                    case "7":
                        #region
                        //show and print all data to console
                        Console.Clear();
                        Console.WriteLine(ShowAllData());

                        //return to menu on keypress
                        Console.WriteLine($"\n{TransLang("Druk op enter om terug naar het menu te gaan")}.");
                        Console.ReadKey();
                        break;
                    #endregion

                    //case 8: change language to English or Dutch and return to menu
                    case "8":
                        #region
                        Console.Clear();
                        if (language == "EN")
                        {
                            language = "NL";
                            Console.WriteLine($"{TransLang("Taal is veranderd naar Nederlands")}.\n\n");
                        }
                        else
                        {
                            language = "EN";
                            Console.WriteLine($"{TransLang("Taal is veranderd naar Engels")}.\n\n");
                        }

                        //return to menu on keypress
                        Console.WriteLine($"\n{TransLang("Druk op enter om terug naar het menu te gaan")}.");
                        Console.ReadKey();
                        break;
                    #endregion

                    //else: print error message to console and return to main menu on key press
                    default:
                        Console.WriteLine(TransLang("Nummer niet herkent! Probeer nogmaals"));
                        Console.WriteLine($"\n{TransLang("Druk op enter om terug naar het menu te gaan")}.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        



    }
}
