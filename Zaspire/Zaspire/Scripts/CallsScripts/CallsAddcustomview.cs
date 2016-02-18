using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;
using OpenQA.Selenium;

namespace Zaspire.Scripts
{
    [TestClass]
    public class CallsAddCustomview : DriverTestCase
    {
        [TestMethod]
        public void AddcustomviewCalls()
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
            
            //Variable

            var Saveviewas = "custom" + RandomNumber(1, 99);
            
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

            //Click on custom view
            CallHelper.ClickElement("customview");

            //Click On Create
            CallHelper.ClickElement("Newbutton");

            //Enter text
            CallHelper.TypeText("Saveviewas", Saveviewas);

            //Select dropdown list
            CallHelper.Select("Sortby", "Owner");

            //Select dropdown list
            CallHelper.Select("Owner","Ranjith");

            //Select dropdown list
            CallHelper.Select("RelatedTo", "Accounts");
           
            //Select Category
            CallHelper.Select("Category", "Hold");

            //Select dropdown list
            CallHelper.Select("Createdby", "Ranjith");

            //Select dropdown list
            CallHelper.Select("Modifiedby", "Ranjith");

            //Select dropdown list
            //CallHelper.Select("Createdtype", "ne");

            //Enter text
            CallHelper.TypeText("Createdtext", "kavitha");

            //Select dropdown list
            //CallHelper.Select("Modifytype", "eq");

            //Enter text
            CallHelper.TypeText("Modifytext", "Ranjith");

            //Select dropdown list
            //CallHelper.Select("Calldatetype", "eq");

            //Enter text
            CallHelper.TypeText("Calldatetext", "Ranjith");



            //Enter text
            CallHelper.Select("Nemeadditioanal", "a.call_to_name:string");

            //Select dropdown list
            //CallHelper.Select("Nametype", "eq");

            //Enter text
            CallHelper.TypeText("Nametext", "Ranjith");

            //Click on save
            CallHelper.ClickElement("Save");

            
        }
    }
}


