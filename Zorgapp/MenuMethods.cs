﻿using System;
using System.Collections.Generic;
using Zorgapp.BasicClasses;

namespace Zorgapp
{
    //partial class ZorgApp #3
    
    partial class ZorgApp
    {

        private void EditProfileSwitch(Profile profile, string choice)
        {

            switch (choice)
            {

                case "1":
                    Console.WriteLine(TransLang("Voer uw voornaam in") + ": ");
                    EditProfile(profile, 1, Console.ReadLine());
                    break;
                case "2":
                    Console.WriteLine(TransLang("Voer uw achternaam in") + ": ");
                    EditProfile(profile, 2, Console.ReadLine());
                    break;
                case "3":
                    Console.WriteLine(TransLang("Voer uw leeftijd in") + ": ");
                    EditProfile(profile, 3, Console.ReadLine());
                    break;
                case "4":
                    Console.WriteLine(TransLang("Voer uw gewicht in met een comma") + ": ");
                    EditProfile(profile, 4, Console.ReadLine());
                    break;
                case "5":
                    Console.WriteLine(TransLang("Voer uw lengte in met een comma") + ": ");
                    EditProfile(profile, 5, Console.ReadLine());
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine(TransLang("Bewerking is NIET opgeslagen") + ".\n\n");
                    return;
            }

            Console.Clear();
            Console.WriteLine(TransLang("Bewerking is opgeslagen")+ ".\n\n");
            Console.WriteLine(ShowProfile(profile));
        }

        private void EditMedicineSwitch(Medicine medicine, string choice)
        {

            switch (choice)
            {
                case "1":
                    Console.WriteLine(TransLang("Voer de medicijnnaam in") + ": ");
                    EditMedicine(medicine, 1, Console.ReadLine());
                    break;
                case "2":
                    Console.WriteLine(TransLang("Voer de beschrijving in") + ": ");
                    EditMedicine(medicine, 2, Console.ReadLine());
                    break;
                case "3":
                    Console.WriteLine(TransLang("Voer de soort in") + ": ");
                    EditMedicine(medicine, 3, Console.ReadLine());
                    break;
                case "4":
                    Console.WriteLine(TransLang("Voer de dosering in" ) + ": ");
                    EditMedicine(medicine, 4, Console.ReadLine());
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine(TransLang("Bewerking is NIET opgeslagen") + ".\n\n");
                    return;
            }

            Console.Clear();
            Console.WriteLine(TransLang("Bewerking is opgeslagen") + ".\n\n");
            Console.WriteLine(ShowMedicine(medicine));
        }

        private void EditWeightSwitch(WeightMeasurePoint weightMeasurePoint, string choice)
        {

            //edit weightMeasurePoint with userinput based on number
            switch (choice)
            {
                case "1":
                    Console.WriteLine(TransLang("Voer de datum in") + ": ");
                    EditWeightMeasurePoint(weightMeasurePoint, 1, Console.ReadLine());
                    break;
                case "2":
                    Console.WriteLine(TransLang("Voer de tijd in") + ": ");
                    EditWeightMeasurePoint(weightMeasurePoint, 2, Console.ReadLine());
                    break;
                case "3":
                    Console.WriteLine(TransLang("Voer uw gewicht in met een comma") + ": ");
                    EditWeightMeasurePoint(weightMeasurePoint, 3, Console.ReadLine());
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine(TransLang("Bewerking is NIET opgeslagen") + ".\n\n");
                    return;
            }

            Console.Clear();
            Console.WriteLine(TransLang("Bewerking is opgeslagen") + ".\n\n");
            Console.WriteLine(ShowWeightMeasurePoint(weightMeasurePoint));
        }

        private bool ChoiceCheck<T>(string idString, List<T> list, out int id) 
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
