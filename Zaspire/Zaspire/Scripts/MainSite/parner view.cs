﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class ParntnerView : DriverTestCase
    {
        [TestMethod]
        public void AddNewPartner()
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

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Dashboard in menu
            addpartnerHelper.ClickElement("partners");


            //#########################Create Partner######################################


            // Click on record
            addpartnerHelper.ClickElement("PartnerView");

            //Clcik on activity tab
            addpartnerHelper.ClickElement("Activitiestab");

            //Click on Timline
            //addpartnerHelper.ClickElement("Timelinetab");


            //Click on contact
            addpartnerHelper.ClickElement("Contacttab");

            //Click on leads
            addpartnerHelper.ClickElement("Relatedleadstab");

            // Click on accounts
            addpartnerHelper.ClickElement("Relatedaccounts");

            // Click on back button
            addpartnerHelper.ClickElement("Backtopartners");

            // Click on edit button
            addpartnerHelper.ClickElement("Editpartners");
            
            // Click on new button
            addpartnerHelper.ClickElement("ParnerAddNew");
        }

    }
}