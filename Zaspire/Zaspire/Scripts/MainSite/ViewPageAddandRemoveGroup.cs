﻿using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class ViewPageAddandRemoveGroup : DriverTestCase
    {
        [TestMethod]
        public void viewpageaddandremovegroup()
        {
            string[] username = null;
            string[] password = null;

            XMLParse oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            var SaveViewas = "CustomView" + RandomNumber(20, 99);

            //Initializing the objects
            LoginHelper loginHelper = new LoginHelper(GetWebDriver());
            //ClientsHelper clientHelper = new ClientsHelper(GetWebDriver());
            AddAccountHelper AddAccountHelper = new AddAccountHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            AddAccountHelper.WaitForWorkAround(4000);

            //Click On Client Tab
            AddAccountHelper.ClickElement("ClickAccountsTab");
            AddAccountHelper.WaitForWorkAround(4000);

            AddAccountHelper.ClickElement("SelectAccount");
            AddAccountHelper.WaitForWorkAround(2000);

            AddAccountHelper.Select("SelectGroup", "5");

            AddAccountHelper.ClickElement("ClickOnSaveGroupButton");

            AddAccountHelper.ClickElement("ClickOnCloseOption");


            AddAccountHelper.Select("SelectGroup", "5");

            AddAccountHelper.ClickElement("ClickOnGroupDeleteButton");




        }
    }
}