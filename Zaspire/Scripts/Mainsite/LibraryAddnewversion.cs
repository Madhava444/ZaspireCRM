﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class Libraryviewpage : DriverTestCase
    {
        [TestMethod]
        public void Libraryaddnewversion()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var LibraryviewpageHelper = new LibraryViewPageHelper(GetWebDriver());
            var AddNewLibraryHelper = new AddNewLibraryHelper(GetWebDriver());

            //Variable

            var DocumentName = "Test Library" + RandomNumber(1, 99);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Events
            LibraryviewpageHelper.ClickElement("ClickOnlibrary");
            LibraryviewpageHelper.WaitForWorkAround(3000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/libraries");
            //AddNewLibraryHelper.WaitForWorkAround(7000);


            //#################### CREATE A LIBRARY   #####################################

            //Create on Library
            AddNewLibraryHelper.ClickElement("ClickOnAddNew");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/libraries/addnew");



            //################### CLASSIFICATIONS & OWNERSHIP  #########################


            //Select Library Category
            AddNewLibraryHelper.Select("LibraryCategory", "12181");

            //Select Library Owner  
            AddNewLibraryHelper.Select("SelectLibraryOwner", "13");

            //Enter Document Name
            AddNewLibraryHelper.TypeText("EnterDocumentName", DocumentName);

            //Select Document Type
            AddNewLibraryHelper.Select("SelectDocumentType", "Invoice");

            //Enter Library Version
            AddNewLibraryHelper.TypeText("EnterLibraryVersion", "1");


            //Click On Save
            AddNewLibraryHelper.ClickElement("ClickOnSave");
            AddNewLibraryHelper.WaitForWorkAround(7000);


            //Go to library indexpage
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/libraries");

         
            //Click on Library
            LibraryviewpageHelper.ClickElement("ClickLibraryrecord");
            AddNewLibraryHelper.WaitForWorkAround(7000);

            //Click on Versionlink
            LibraryviewpageHelper.ClickElement("Addnewversionlink");

            //Select file
            LibraryviewpageHelper.ClickElement("Selectfile");

            //Type comment
            LibraryviewpageHelper.TypeText("librarcomment" , "NewsStyleUriParser");

            //Click on Save
            LibraryviewpageHelper.ClickElement("Versionsave");
            LibraryviewpageHelper.WaitForWorkAround(3000);


            //Delete new version
            LibraryviewpageHelper.ClickElement("VersionDelete");

            //Accept Alert
            LibraryviewpageHelper.AcceptAlert();
            LibraryviewpageHelper.WaitForWorkAround(3000);


           

            
       }
    }
}