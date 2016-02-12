﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;


namespace Zaspire.Scripts
{
    [TestClass]
    public class ViewTeam : DriverTestCase
    {
        [TestMethod]
        public void ViewTeams()
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

            //AdminTeamsHelper.DragAndDrop("locater");
            //AdminTeamsHelper.WaitForWorkAround(10000);

            //Click on back
            AdminTeamsHelper.ClickElement("Back");

            //Click on View team
            AdminTeamsHelper.ClickElement("Teamview");

            //Click on Set permission
            AdminTeamsHelper.ClickElement("Setpermissions");

            
            //GetWebDriver().Navigate().Back();
           


           




        }
    }
}