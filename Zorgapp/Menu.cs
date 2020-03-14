using System;

namespace Zorgapp 
{
    partial class ZorgApp
    {
        /*todo extract nested switches and cases to new methods
        method name as: SwitchOneCaseOne*/
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
                    //case 1: get readable string of profile with ShowProfile and print to console
                    case "1":

                        //show profile
                        Console.WriteLine(ShowProfile());

                        //return to menu on keypress
                        Console.WriteLine("\nDruk op enter om terug naar het menu te gaan.");
                        Console.ReadKey();
                        break;

                    //case 2: edit profile attribute based on number of choices
                    case "2":

                        //present user with number choices
                        Console.WriteLine(ShowProfile());
                        Console.WriteLine("\nKies een nummer om te bewerken: (1, 2, 3, 4, 5)");

                        //edit profile with userinput based on number
                        EditProfileSwitch();

                        //return to menu on keypress
                        Console.WriteLine("\nDruk op enter om terug naar het menu te gaan.");
                        Console.ReadKey();
                        break;

                    //case 3: get readable string of medicineList with ShowMedicineList and print to console
                    case "3":

                        //show medicine list
                        Console.WriteLine(ShowMedicineList());

                        //return to menu on keypress
                        Console.WriteLine("\nDruk op enter om terug naar het menu te gaan.");
                        Console.ReadKey();
                        break;

                    //case 4: edit medicine attribute in medicineList based on number of choices
                    case "4":

                        //show weight table with numbers to choose from
                        Console.WriteLine(ShowMedicineList());
                        Console.WriteLine("\nMaak een keuze om te bewerken: ");

                        //checks on userinput
                        string medicineIdString = Console.ReadLine();

                        if (!UserInputCheck(medicineIdString, out int id))
                        {
                            break;
                        }

                        //get medicine from list
                        Medicine medicine = medicineList[id - 1];

                        //initialize local bool for switch default check
                        bool showMedicineAfterEdit = true;

                        //present user with number choices
                        Console.Clear();
                        Console.WriteLine(ShowMedicine(medicine));
                        Console.WriteLine("\nKies een nummer om te bewerken: (1, 2, 3, 4)");

                        //edit medcine with userinput based on number
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine("Voer de medicijnnaam in: ");
                                EditMedicine(medicine, 1);
                                break;
                            case "2":
                                Console.WriteLine("Voer de beschrijving in: ");
                                EditMedicine(medicine, 2);
                                break;
                            case "3":
                                Console.WriteLine("Voer de soort in: ");
                                EditMedicine(medicine, 3);
                                break;
                            case "4":
                                Console.WriteLine("Voer de dosering in: ");
                                EditMedicine(medicine, 4);
                                break;
                            default:
                                showMedicineAfterEdit = false;
                                break;
                        }

                        //check for local bool if editing is done
                        if (showMedicineAfterEdit == true)
                        {
                            Console.Clear();
                            Console.WriteLine("Bewerking is opgeslagen.\n\n");
                            Console.WriteLine(ShowMedicine(medicine));
                        }

                        //return to menu on keypress
                        Console.WriteLine("\nDruk op enter om terug naar het menu te gaan.");
                        Console.ReadKey();
                        break;

                    //case 5: get readable string of weightMeasurePointList with GetWeightGraph and print to console
                    case "5":

                        //show weight table
                        Console.WriteLine(ShowWeightMeasurePointList());

                        //return to menu on keypress
                        Console.WriteLine("\nDruk op enter om terug naar het menu te gaan.");
                        Console.ReadKey();
                        break;

                    //case 6: edit weightMeasurePoint attribute in weightMeasurePointList based on number of choices
                    case "6":

                        //show weight table with numbers to choose from
                        Console.WriteLine(ShowWeightMeasurePointList());
                        Console.WriteLine("\nMaak een keuze om te bewerken: ");

                        //checks on userinput
                        string weightIdString = Console.ReadLine();

                        //check 1: check if userinput is empty
                        if (string.IsNullOrEmpty(weightIdString))
                        {
                            break;
                        }

                        //check 2: check if userinput is a number
                        int weightId;
                        if (Int32.TryParse(weightIdString, out int result1))
                        {
                            weightId = result1;
                        }
                        else
                        {
                            break;
                        }

                        //check 3: check if userinput is within index limits of weightMeasurePointList
                        if (weightMeasurePointList.Count < weightId || weightId < 1)
                        {
                            break;
                        }

                        //initialize local bool for switch default check
                        bool showWeightAfterEdit = true;

                        //get weightMeasurePoint from list
                        WeightMeasurePoint weightMeasurePoint = weightMeasurePointList[weightId - 1];

                        //present user with number choices
                        Console.Clear();
                        Console.WriteLine(ShowWeightMeasurePoint(weightMeasurePoint));
                        Console.WriteLine("\nKies een nummer om te bewerken: (1, 2, 3)");

                        //edit weightMeasurePoint with userinput based on number
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
                                showWeightAfterEdit = false;
                                break;
                        }

                        //check for local bool if editing is done
                        if (showWeightAfterEdit == true)
                        {
                            Console.Clear();
                            Console.WriteLine("Bewerking is opgeslagen.\n\n");
                            Console.WriteLine(ShowWeightMeasurePoint(weightMeasurePoint));
                        }

                        //return to menu on keypress
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

        
    }
}
