using System;
using System.Collections.Generic;

namespace Zorgapp
{
    partial class ZorgApp
    {

        private void EditProfileSwitch()
        {

            //initialize local bool for switch default check
            bool showProfileAfterEdit = true;

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
                    showProfileAfterEdit = false;
                    break;
            }

            //check for local bool if editing is done
            if (showProfileAfterEdit == true)
            {
                Console.Clear();
                Console.WriteLine("Bewerking is opgeslagen.\n\n");
                Console.WriteLine(ShowProfile());
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Bewerking is NIET opgeslagen.\n\n");
            }
            return;
        }

        private void EditMedicineSwitch(Medicine medicine)
        {
            //initialize local bool for switch default check
            bool showMedicineAfterEdit = true;

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
            else
            {
                Console.Clear();
                Console.WriteLine("Bewerking is NIET opgeslagen.\n\n");
            }
            return;
        }

        private void EditWeightSwitch(WeightMeasurePoint weightMeasurePoint)
        {
            //initialize local bool for switch default check
            bool showWeightAfterEdit = true;

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
            else
            {
                Console.Clear();
                Console.WriteLine("Bewerking is NIET opgeslagen.\n\n");
            }
            return;
        }

        private bool UserInputCheck<T>(string idString, List<T> list, out int id) 
        {
            id = 0;
            //check 1: check if userinput is empty
            if (string.IsNullOrEmpty(idString))
            {
                return false;
            }

            //check 2: check if userinput is a number
            if (Int32.TryParse(idString, out int result))
            {
                id = result;
            }
            else
            {
                return false;
            }

            //check 3: check if userinput is within index limits of list
            if (list.Count < id || id < 1)
            {
                return false;
            }

            //return true if all checks succeed
            return true;
        }

    }
}
