using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddNotetoVendor : DriverTestCase
    {
        [TestMethod]
        public void NotetoVendor()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var VendorHelper = new VendorHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Dashboard in menu
            VendorHelper.ClickElement("Vendor");

            //################### ADD NOTE  #########################


            //Click on Add Note
            VendorHelper.ClickElement("ClickOnAddNote");

            //Enter Note Subject
            VendorHelper.TypeText("EnterNoteSubject", "Note for Subject");

            //Enter Note Description
            VendorHelper.TypeText("EnterNoteDescription", "This is Note Description");

            //Upload File 
            String filename = GetPath() + "C:\\Users\\Public\\Pictures\\Sample Pictures\\image\\Tulips.jpeg";
            VendorHelper.Upload("SelectNoteFile", filename);
            VendorHelper.WaitForWorkAround(10000);


            //Click On Save
            VendorHelper.ClickElement("ClickOnSaveNote");
            VendorHelper.WaitForWorkAround(7000);



        }
    }
}



