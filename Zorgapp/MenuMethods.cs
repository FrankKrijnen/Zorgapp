using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            return;
        }

        private bool UserInputCheck(string idString, out int id) 
        {
            //check 1: check if userinput is empty
            if (string.IsNullOrEmpty(idString))
            {
                id = 0;
                return false;
            }

            //check 2: check if userinput is a number
            if (Int32.TryParse(idString, out int result))
            {
                id = result;
            }
            else
            {
                id = 0;
                return false;
            }

            //check 3: check if userinput is within index limits of medicineList
            if (medicineList.Count < id || id < 1)
            {
                id = 0;
                return false;
            }
            return true;
        }

    }
}
