using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;
using OpenQA.Selenium.Interactions;

namespace Zaspire.Scripts
{
    [TestClass]
    public class SetTeamPermissions: DriverTestCase
    {
        [TestMethod]
        public void SetteamPermissions()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AdminTeamsHelper = new AdminTeamsHelper(GetWebDriver());
            var addcampaignHelper = new CampaignHelper(GetWebDriver());
            
            //Variable

            var Name = "Team" + RandomNumber(1, 99);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Mouse over on Profile
            AdminTeamsHelper.Mouseover("locator");

            //click on admin
            AdminTeamsHelper.ClickElement("ClickonAdmin");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin");

            //Click on teams
            AdminTeamsHelper.ClickElement("teams");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin/roles/team");


            //Click on View team
            AdminTeamsHelper.ClickElement("Teamview");
            
            //Click on Set permission
            AdminTeamsHelper.ClickElement("Setpermissions");

            //Click on Module radio button
            AdminTeamsHelper.ClickElement("Modulepermissions");

            //Click  on Account view team permissions
            AdminTeamsHelper.ClickElement("CampaignViewAssigneed");
            AdminTeamsHelper.ClickElement("CampaignViewEveryoneup");
            AdminTeamsHelper.ClickElement("CampaignViewEveryoneDown");
            AdminTeamsHelper.ClickElement("CampaignViewEveryoneElse");
            AdminTeamsHelper.ClickElement("CampaignViewAnyoneFrom");

            //Click on Account edit team permissions
            AdminTeamsHelper.ClickElement("CampaignEditAssigneed");
            AdminTeamsHelper.ClickElement("CampaignEditEveryoneup");
            AdminTeamsHelper.ClickElement("CampaignEditEveryoneDown");
            AdminTeamsHelper.ClickElement("CampaignEditEveryoneElse");
            AdminTeamsHelper.ClickElement("CampaignEditAnyoneFrom");


            //Click on Account Delete team permissions
            AdminTeamsHelper.ClickElement("CampaignDeleteAssigneed");
            AdminTeamsHelper.ClickElement("CampaignDeleteEveryoneup");
            AdminTeamsHelper.ClickElement("CampaignDeleteEveryoneDown");
            AdminTeamsHelper.ClickElement("CampaignDeleteEveryoneElse");
            AdminTeamsHelper.ClickElement("CampaignDeleteAnyoneFrom");

            //Click on Save button
            AdminTeamsHelper.ClickElement("SavePermissions");

            //Mouse over on Profile
            AdminTeamsHelper.Mouseover("locator");

            //click on admin
            AdminTeamsHelper.ClickElement("ClickonMainsite");

                 //Click on Dashboard in menu
            addcampaignHelper.ClickElement("ClickCampaignsTab");

            //Click on record
            addcampaignHelper.ClickElement("Clickonrecord");

            //Select Moreaction
            addcampaignHelper.MouseOver2("locator");

            //Select Add task
            addcampaignHelper.ClickElement("Deletecampaign");

            addcampaignHelper.AcceptAlert();
            addcampaignHelper.WaitForWorkAround(5000);


        }
    }
}