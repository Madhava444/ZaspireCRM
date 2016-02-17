using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;
using OpenQA.Selenium;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddCustomviewCampaigns : DriverTestCase
    {
        [TestMethod]
        public void AddcustomviewCampaigns()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var addcampaignHelper = new CampaignHelper(GetWebDriver());
            
            //Variable

            var Saveviewas = "custom" + RandomNumber(1, 99);
            
            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Dashboard in menu
            addcampaignHelper.ClickElement("Campaigns");


            //#########################Create Partner######################################

            //Click on custom view
            addcampaignHelper.ClickElement("customview");

            //Click On Create
            addcampaignHelper.ClickElement("Newbutton");

            //Enter text
            addcampaignHelper.TypeText("Saveviewas", Saveviewas);

            //Select dropdown list
            //addcampaignHelper.Select("Sortby", "Name");

            //Select import file
            addcampaignHelper.Select("Importfile", "");

            //Select dropdown list
            addcampaignHelper.Select("Owner1", "17");

            //Select dropdown list
            addcampaignHelper.Select("Manager1", "28");

            //Select sttus
            addcampaignHelper.Select("Status", "Active");

            //Select category
            addcampaignHelper.Select("Category", "Employee");

            //Select dropdown list
            addcampaignHelper.Select("Createdby", "Ranjith");

            //Select dropdown list
            addcampaignHelper.Select("Modifiedby", "Ranjith");

            //Select group
            addcampaignHelper.Select("Group", "1");

            //Select dropdown list
            addcampaignHelper.Select("Createdtype", "eq");

            //Enter text
            addcampaignHelper.TypeText("Createdtext", "Ranjith");

            //Select dropdown list
            addcampaignHelper.Select("Modifytype", "eq");

            //Enter text
            addcampaignHelper.TypeText("Modifytext", "Ranjith");

            //Enter text
            addcampaignHelper.TypeText("NameAdditioncretireia", "a.name:string");

            //Select dropdown list
            addcampaignHelper.TypeText("Nametype", "cn");

            //Enter text
            addcampaignHelper.Select("Nametext", "Ranjith");

            //Click on save
            addcampaignHelper.ClickElement("Save");

            
        }
    }
}


