using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zorgapp
{
    partial class ZorgApp
    {
        private Dictionary<string, string> languageDictionary;
        private string language = "NL";

        private void FillLanguageDictionary()
        {
            //section display menu words
            languageDictionary.Add("Profielen", "Profiles");
            languageDictionary.Add("Medicijnen", "Medicines");
            languageDictionary.Add("Gewichttabel", "Weight table");

            //section display menu sentences
            languageDictionary.Add("Welkom in het menu", "Welcome to the menu");
            languageDictionary.Add("Kies een nummer", "Choose a number");
            languageDictionary.Add("Profiellijst tonen", "Show profile list");
            languageDictionary.Add("Profiel bewerken", "Edit profile");
            languageDictionary.Add("Medicijnlijst tonen", "Show medicine list");
            languageDictionary.Add("Medicijn bewerken", "Edit medicine");
            languageDictionary.Add("Gewicht tabel tonen", "Show weight table");
            languageDictionary.Add("Gewicht tabel bewerken", "Edit weight table");
            languageDictionary.Add("Alle gegevens tonen", "Show all data");
            languageDictionary.Add("Switch to English", "Verander naar Nederlands");

            //section other menu sentences
            languageDictionary.Add("Taal is veranderd naar Nederlands", "Language has been changed to Dutch");
            languageDictionary.Add("Taal is veranderd naar Engels", "Language has been changed to English");
            languageDictionary.Add("Druk op enter om terug naar het menu te gaan", "Press enter to return to the menu");
            languageDictionary.Add("Bewerking is opgeslagen", "Edit has been saved");
            languageDictionary.Add("Bewerking is NIET opgeslagen", "Edit has NOT been saved");
            languageDictionary.Add("Details na keuze", "Details after choice");
            languageDictionary.Add("Nummer niet herkent! Probeer nogmaals", "Number not valid! Please try again");
            languageDictionary.Add("Maak een keuze om te bewerken", "Pick a choice to edit");
            languageDictionary.Add("Kies een nummer om te bewerken", "Pick a number to edit");

            //section profile words
            languageDictionary.Add("Voornaam", "Firstname");
            languageDictionary.Add("Achternaam", "Lastname");
            languageDictionary.Add("Leeftijd", "Age");
            languageDictionary.Add("Gewicht", "Weight");
            languageDictionary.Add("Lengte", "Length");

            //section profile sentences
            languageDictionary.Add("Voer uw voornaam in", "Fill in your firstname");
            languageDictionary.Add("Voer uw achternaam in", "Fill in your lastname");
            languageDictionary.Add("Voer uw leeftijd in", "Fill in your age");
            languageDictionary.Add("Voer uw gewicht in met een comma", "Fill in your weight with a comma");
            languageDictionary.Add("Voer uw lengte in met een comma", "Fill in your length with a comma");

            //section medicine words
            languageDictionary.Add("Medicijn", "Medicine");
            languageDictionary.Add("Beschrijving", "Description");
            languageDictionary.Add("Soort", "Sort");
            languageDictionary.Add("Dosering", "Dosage");

            //section medicine sentences
            languageDictionary.Add("Voer de medicijnnaam in", "Fill in medicine name");
            languageDictionary.Add("Voer de beschrijving in", "Fill in description");
            languageDictionary.Add("Voer de soort in", "Fill in sort");
            languageDictionary.Add("Voer de dosering in", "Fill in dosage");

            //section weightmeasurepoint words
            languageDictionary.Add("Datum", "Date");
            languageDictionary.Add("Tijd", "Time");

            //section weightmeasurepoint sentences
            languageDictionary.Add("Voer de datum in", "Fill in date");
            languageDictionary.Add("Voer de tijd in", "Fill in time");
        }
    }
}
