using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zorgapp
{
    class Profile
    {
        //fields and properties
        private string firstName;
        private string lastName;
        private int age;
        private double weight;
        private double length;

        //constructor with 2 overloads
        public Profile() { }
        public Profile(string firstName, string lastName) 
        {
            SetFirstName(firstName);
            SetLastName(lastName);
        }
        public Profile(string firstName, string lastName, int age, double weight, double length) 
        {
            SetFirstName(firstName);
            SetLastName(lastName);
            SetAge(age);
            SetWeight(weight);
            SetLength(length);
        }

        //methods
        //setters
        public void SetFirstName(string firstName) { this.firstName = firstName; }
        public void SetLastName(string lastName) { this.lastName = lastName; }
        public void SetAge(int age) { this.age = age; }
        public void SetWeight(double weight) { this.weight = weight; }
        public void SetLength(double length) { this.length = length; }

        //getters
        public string GetFirstName() { return firstName; }
        public string GetLastName() { return lastName; }
        public int GetAge() { return age; }
        public double GetWeight() { return weight; }
        public double GetLength() { return length; }
        public string GetBmi() { return string.Empty; }
    }
}
