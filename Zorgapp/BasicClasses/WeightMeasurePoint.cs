namespace Zorgapp.BasicClasses
{
    public class WeightMeasurePoint
    {
        //fields and properties
        private string date;
        private string time;
        private double weight;

        //constructor
        public WeightMeasurePoint(string date, string time, double weight) 
        {
            SetDate(date);
            SetTime(time);
            SetWeight(weight);
        }

        //methods
        //setters
        public void SetDate(string date) => this.date = date; 
        public void SetTime(string time) => this.time = time; 
        public void SetWeight(double weight) => this.weight = weight;

        //getters
        public string GetDate() 
        { 
            return date; 
        }
        public string GetTime() 
        { 
            return time; 
        }
        public double GetWeight()
        { 
            return weight; 
        }

    }
}