using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zorgapp
{
    class ZorgApp
    {
        //fields and properties
        private Profile profile;
        private List<Medicine> medicineList;
        private List<WeightMeasurePoint> weightMeasurePointData;

        //constructor
        public ZorgApp() 
        {
            profile = new Profile();
            medicineList = new List<Medicine>();
            weightMeasurePointData = new List<WeightMeasurePoint>();

            DisplayMenu();
        }

        //methods
        public void ViewData() { }
        private void GetWeightGraph() { }
        private void DisplayMenu() 
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{DateTime.Now}\nWelkom in het menu");
                Console.ReadLine();
            }
        }
    }
}
