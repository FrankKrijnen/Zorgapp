using System;

namespace Zorgapp
{
    public class Medicine
    {
        //fields and properties
        private string medicineName;
        private string description;
        private string sort;
        private DateTime dosage;

        //constructor with 1 overload
        public Medicine() 
        {
            SetMedicineName(null);
            SetDescription(null);
            SetSort(null);
            SetDosage(Convert.ToDateTime(null));
        }

        public Medicine(string medicineName, string description, string sort, DateTime dosage) 
        {
            SetMedicineName(medicineName);
            SetDescription(description);
            SetSort(sort);
            SetDosage(dosage);
        }

        //methods
        //setters
        public void SetMedicineName(string medicineName) => this.medicineName = medicineName; 
        public void SetDescription(string description) => this.description = description; 
        public void SetSort(string sort) => this.sort = sort; 
        public void SetDosage(DateTime dosage) => this.dosage = dosage; 

        //getters
        public string GetMedicineName()
        {
            return medicineName; 
        }
        public string GetDescription() 
        { 
            return description; 
        }
        public string GetSort() 
        {
            return sort; 
        }
        public DateTime GetDosage() 
        { 
            return dosage; 
        }
    }
}