using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zorgapp;

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

        [TestMethod()]
        public void EditProfile_ProfileData_ProfileEdited()
        {
            
            //arrange
            ZorgApp zorgApp = new ZorgApp(true);
            string firstName = "TestVoornaam";
            Profile profile = zorgApp.profile;
            int choice = 1;

            //act
            zorgApp.EditProfile(profile, choice, firstName);

            //assert
            string actual = profile.GetFirstName();
            Assert.AreEqual(firstName, actual);
            
        }
    }
}