﻿namespace Zorgapp
{
    class Medicine
    {
        //fields and properties
        private string medicineName;
        private string description;
        private string sort;
        private string dosage;

        //constructor
        public Medicine() { }

        //methods
        //setters
        public void SetMedicineName(string medicineName) { this.medicineName = medicineName; }
        public void SetDescription(string description) { this.description = description; }
        public void SetSort(string sort) { this.sort = sort; }
        public void SetDosage(string dosage) { this.dosage = dosage; }

        //getters
        public string GetMedicineName() { return medicineName; }
        public string GetDescription() { return description; }
        public string GetSort() { return sort; }
        public string GetDosage() { return dosage; }
    }
}