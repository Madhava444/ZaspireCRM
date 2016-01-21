using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;
using OpenQA.Selenium;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddCustomviewParntners : DriverTestCase
    {
        [TestMethod]
        public void AddcustomviewPartner()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var addpartnerHelper = new PartnerHelper(GetWebDriver());
            
            //Variable

            var Saveviewas = "custom" + RandomNumber(1, 99);
            
            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Dashboard in menu
            addpartnerHelper.ClickElement("partners");
            

            //#########################Create Partner######################################

            //Click on custom view
            addpartnerHelper.ClickElement("customview");

            //Click On Create
            addpartnerHelper.ClickElement("Newbutton");

            //Enter text
            addpartnerHelper.TypeText("Saveviewas", Saveviewas);

            //Select dropdown list
            //addpartnerHelper.Select("Sortby", "Name");

            //Select dropdown list
            addpartnerHelper.Select("Owner", "Kavitha");

            //Select dropdown list
            addpartnerHelper.Select("Manager", "Shravani");

            //Select dropdown list
            addpartnerHelper.Select("Createdby", "Kavitha");

            //Select dropdown list
            addpartnerHelper.Select("Modifiedby", "Kavitha");

            //Select dropdown list
            addpartnerHelper.Select("Createdtype", "eq");

            //Enter text
            addpartnerHelper.TypeText("Createdtext", "kavitha");

            //Select dropdown list
            addpartnerHelper.Select("Modifytype", "eq");

            //Enter text
            addpartnerHelper.TypeText("Modifytext", "kavitha");

            //Enter text
            addpartnerHelper.TypeText("Nemeadditioanal", "a.name:string");

            //Select dropdown list
            addpartnerHelper.TypeText("Nametype", "eq");

            //Enter text
            addpartnerHelper.Select("Nametext", "Kavitha");

            //Click on save
            addpartnerHelper.ClickElement("Save");

            
        }
    }
}


