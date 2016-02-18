using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class CallIndex : DriverTestCase
    {
        [TestMethod]
        public void CallHome()
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

            //#########################Create Partner######################################

            //Select default view
            CallHelper.Select("CallDefaultview", "Recently Added");

            //Select Custom view
           /* CallHelper.Select("CallCustomview", "");


            //Enter text in filter
            CallHelper.TypeText("CallFilter", "Meeting");

            //Click on PartnerFilter Reset
            CallHelper.ClickElement("CallReset");

            //check master checkbox
            CallHelper.ClickElement("CallMasterCheckbox");

            // Select result per page options
           CallHelper.MouseHover("locator1");

             // Select result per page options
             CallHelper.ClickElement("CallBulkupdate");

            //Select Owner
            CallHelper.Select("BulkupdateOwner", "17");

            //Select Category
            CallHelper.Select("BulkupdateCategory", "12403");

             

             //Click on Update
             CallHelper.ClickElement("BulkupdateButton");

             //Click on PartnerFilter Reset
             CallHelper.ClickElement("CallReset");
  
            //######################Bulk Delete######################
          

             //Enter text in filter
             CallHelper.TypeText("CallFilter", "Appointment");

             //check master checkbox
             CallHelper.ClickElement("CallMasterCheckbox");

           // Moves over on bulk actions
             CallHelper.MouseHover("locator1");

             // Select result per page options
             CallHelper.ClickElement("CallDelete");
             CallHelper.AcceptAlert(); */

             //Click On Quick Look Mouse Over
             CallHelper.Mouseover("locator");
            CallHelper.WaitForWorkAround(10000);

            //Click On Quick Look
            CallHelper.ClickElement("ToolActioncall");

            //Click On Quick Look View
            CallHelper.ClickElement("ToolViewCall");
            CallHelper.WaitForWorkAround(1000);

            //Click on Back to Calls
            CallHelper.ClickElement("CallBack");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/calls");
            CallHelper.WaitForWorkAround(1000);

            //Click On Quick Look Mouse Over
            CallHelper.Mouseover("locator");
            CallHelper.WaitForWorkAround(1000);

            //Click On Quick Look
            CallHelper.ClickElement("ToolActioncall");

            //Click On Quick Look Edit
            CallHelper.ClickElement("ToolEditCall");
            CallHelper.WaitForWorkAround(1000);

            //Click on Cancel to Calls
            CallHelper.ClickElement("SelectCancel");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/calls");

            //Click On Quick Look Mouse Over
            CallHelper.Mouseover("locator");

            //Click On Quick Look
            CallHelper.ClickElement("ToolActioncall");

            //Clicok On Quick Look Delete
            CallHelper.ClickElement("ToolDeleteCall");

            CallHelper.AcceptAlert();
            CallHelper.WaitForWorkAround(10000);


             // Click on record
            CallHelper.ClickElement("Callview");


        }
    }
}

