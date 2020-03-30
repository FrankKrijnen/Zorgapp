using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zorgapp;
using Zorgapp.BasicClasses;

namespace Zorgapp.Tests
{
    [TestClass()]
    public class ZorgAppTests
    {

        /// <summary>
        /// 
        /// [Naming convention for Test Methods.]
        /// 
        /// Consist of 3 parts:
        /// 
        /// 1. Name of the used method, in act section.
        /// 2. Name of what is asserted on, in assert section.
        /// 3. Name of result of action, in act section.
        /// 
        /// Example:
        /// 
        /// "EditProfile_ProfileData_ProfileEdited()"
        /// 
        /// </summary>

        private const string editProfile = "EditProfile";
        private const string editMedicine = "EditMedicine";
        private const string editWeightMeasurePoint = "EditWeightMeasurePoint";

        private const int firstNameChoice = 1, medicineNameChoice = 1, dateChoice = 1;


        [TestMethod()]
        public void EditProfile_ProfileData_ProfileEdited()
        {

            //arrange
            ZorgApp zorgApp = new ZorgApp(true);
            string firstName = "TestVoornaam";

            //use public getter to get private field
            Profile profile = zorgApp.GetProfile(0);
            int choice = firstNameChoice;

            //act
            //use PrivateObject class from UnitTesting to invoke private methods for testing
            PrivateObject obj = new PrivateObject(zorgApp);
            obj.Invoke(editProfile, profile, choice, firstName);

            //assert
            string actual = profile.GetFirstName();
            Assert.AreEqual(firstName, actual);

        }

        [TestMethod()]
        public void EditMedicine_MedicineData_MedicineEdited()
        {

            //arrange
            ZorgApp zorgApp = new ZorgApp(true);
            string medicineName = "TestMedicijnnaam";

            //use public getter to get private field
            Medicine medicine = zorgApp.GetMedicine(0);
            int choice = medicineNameChoice;

            //act
            //use PrivateObject class from UnitTesting to invoke private methods for testing
            PrivateObject obj = new PrivateObject(zorgApp);
            obj.Invoke(editMedicine, medicine, choice, medicineName);

            //assert
            string actual = medicine.GetMedicineName();
            Assert.AreEqual(medicineName, actual);

        }

        [TestMethod()]
        public void EditWeightMeasurePoint_WeightMeasurePointData_WeightMeasurePointEdited()
        {

            //arrange
            ZorgApp zorgApp = new ZorgApp(true);
            string date = "TestDate";

            //use public getter to get private field
            WeightMeasurePoint weightMeasurePoint = zorgApp.GetWeightMeasurePoint(0);
            int choice = dateChoice;

            //act
            //use PrivateObject class from UnitTesting to invoke private methods for testing
            PrivateObject obj = new PrivateObject(zorgApp);
            obj.Invoke(editWeightMeasurePoint, weightMeasurePoint, choice, date);

            //assert
            string actual = weightMeasurePoint.GetDate();
            Assert.AreEqual(date, actual);

        }
    }
}