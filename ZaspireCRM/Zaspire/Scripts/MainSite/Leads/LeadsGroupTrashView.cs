﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class LeadsGroupTrashView : DriverTestCase
    {
        [TestMethod]
        public void leadsgrouptrashview()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var LeadsTrashViewPageHelper = new LeadsTrashViewPageHelper(GetWebDriver());
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            LeadsTrashViewPageHelper.ClickElement("ClickOnLeads");
            LeadsTrashViewPageHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //LeadsTrashViewPageHelper.WaitForWorkAround(7000);


            //Click On Leads Trash
            LeadsTrashViewPageHelper.ClickElement("ClickOnLeadsTrash");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/trash");
            //LeadsTrashViewPageHelper.WaitForWorkAround(10000);

            //Click On Leads Trash
            LeadsTrashViewPageHelper.ClickElement("ClickOnGroupTarsh");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/groups/trash");
            //LeadsTrashViewPageHelper.WaitForWorkAround(10000);

            //Click On Lead Group View
            LeadsTrashViewPageHelper.ClickElement("ClickOnGroupView");

            //Click On Back
            LeadsTrashViewPageHelper.ClickElement("ClickOnBack");

            //Click On Lead Group View
            LeadsTrashViewPageHelper.ClickElement("ClickOnGroupView");

            //Click On Restore
            LeadsTrashViewPageHelper.ClickElement("ClickOnRestore");

            //Click On Delete
            LeadsTrashViewPageHelper.ClickElement("ClickOnDelete");

            
        }
    }
}