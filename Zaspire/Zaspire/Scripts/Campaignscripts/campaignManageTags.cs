using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class campaignManageTags : DriverTestCase
    {
        [TestMethod]
        public void campaignmanagetags()
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

            
            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            addcampaignHelper.ClickElement("ClickCampaignsTab");


            //Open Lead
            addcampaignHelper.ClickElement("Clickonrecord");


            //################### MANAGE TAGS  #########################


            //Click on Manage Tags
            addcampaignHelper.ClickElement("Managetag");


            //################### YOUR TAGS  #########################


            //Enter Your Tag Name
            addcampaignHelper.TypeText("yourtags", "Test");

            //Click on Save
            addcampaignHelper.ClickElement("Saveyourtags");
            addcampaignHelper.WaitForWorkAround(10000);


            //################### MANAGE TAGS SYSTEM GENERATED TAGS #########################


            //Click on Manage Tags
            addcampaignHelper.ClickElement("Managetag");

            //Click on System Generated Tags
            addcampaignHelper.ClickElement("Systemgenaratetags");

            //Click on System Generated Tags Edit
            addcampaignHelper.ClickElement("Systemedit");


            //Uncheck Department
            addcampaignHelper.ClickElement("Checkanduncheck");

            //Click On Recreate button
            addcampaignHelper.ClickElement("Recreate");
            addcampaignHelper.WaitForWorkAround(10000);


            //################### MANAGE TAGS DELETE  #########################


            //Click on Manage Tags
            addcampaignHelper.ClickElement("Managetag");

            //Click on System Generated Tags
            addcampaignHelper.ClickElement("Systemgenaratetags");

            //Click on System Generated Tags Delete
            addcampaignHelper.ClickElement("Systemdelete");
            addcampaignHelper.WaitForWorkAround(10000);


            //################### TAGS SEARCH  #########################


            //Click on Tag Name
            addcampaignHelper.ClickElement("Nametag");
            addcampaignHelper.WaitForWorkAround(10000);



        }
    }
}