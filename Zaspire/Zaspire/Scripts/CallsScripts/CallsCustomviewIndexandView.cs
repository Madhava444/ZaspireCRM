using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class CallsCustomviewIndexandView : DriverTestCase
    {
        [TestMethod]
        public void callsCustomviewIndexandView()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var CallHelper = new CallHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);
   
            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Dashboard in menu
            CallHelper.ClickElement("ClickonActivities");

            //Click on Calls
            CallHelper.ClickElement("ClickOnCalls");

            //--------------------Customview index and view-------------

            //Click on Index
            CallHelper.ClickElement("customview");


            //Click on new button
            CallHelper.ClickElement("Newbutton");


            //Enter text in save view as
            CallHelper.TypeText("saveviewas", "new");

            //Click on Save button
            CallHelper.ClickElement("CancelCustomview");

            //Select dropdown list
            CallHelper.Select("Owner", "Ranjith");

            //Click on back button
            CallHelper.ClickElement("Save");

            //Click on view
            CallHelper.ClickElement("CustomviewView");

            //Click on edit
            CallHelper.ClickElement("CustomviewEdit");

            //Clcik on cancel
            CallHelper.ClickElement("CancelCustomview");

            //select in dropdown
            CallHelper.Select("Selectdropdown", "133");


            //Clcik on Set as default
            CallHelper.ClickElement("CustomviewSetasdefault");

            //Clcik on Unset as default
            CallHelper.ClickElement("CustomviewUnsetdefault");


            //Clcik on Delete
            CallHelper.ClickElement("CustomviewDelete");

            CallHelper.AcceptAlert();
            CallHelper.WaitForWorkAround(2000);


            //Click on Index
            CallHelper.ClickElement("customview");

            //Enter in filter
            CallHelper.TypeText("Filtercustomview", "custom");

            //Click on Reset
            CallHelper.ClickElement("Resetcustomview");


            

        }
    }
}
