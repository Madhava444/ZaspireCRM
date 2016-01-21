﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class addfileParntner : DriverTestCase
    {
        [TestMethod]
        public void AddfilePartner()
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


            //############################ Add File ##########################################



            //Click On record
            addpartnerHelper.ClickElement("Partnerview");

            //Click on Moreaction
            addpartnerHelper.MouseOver("Moreactions");

            //Select Add File
            addpartnerHelper.ClickElement("From");

            //Enter Name
            addpartnerHelper.TypeText("To", "new1");

            //Select Category
            addpartnerHelper.Select("Subject", "mail for  partner");

            //Upload File 
            String filename = GetPath() + "C:\\Users\\Public\\Pictures\\Sample Pictures\\image\\Tulips.jpeg";
            addpartnerHelper.Upload("SelectFile", filename);
            addpartnerHelper.WaitForWorkAround(10000);


            //Enter description
            addpartnerHelper.TypeText("Description", "This is a file to Partner ");

            //Click on Save button
            addpartnerHelper.ClickElement("Save");

        }
    }
}

