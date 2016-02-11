using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class Librarytrashviewpage : DriverTestCase
    {
        [TestMethod]
        public void Librarytrashviewpages()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AddNewLibraryHelper = new AddNewLibraryHelper(GetWebDriver());

            //Variable

            var DocumentName = "Test Library" + RandomNumber(1, 99);
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Libraries
            AddNewLibraryHelper.ClickElement("ClickOnLibraries");
            AddNewLibraryHelper.WaitForWorkAround(7000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/libraries");
            //AddNewLibraryHelper.WaitForWorkAround(7000);




            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/libraries/trash");
            AddNewLibraryHelper.WaitForWorkAround(7000);
            


            //################### CLASSIFICATIONS & OWNERSHIP  #########################

            //Click on Record
            AddNewLibraryHelper.ClickElement("Selecttrashrecord");
            AddNewLibraryHelper.WaitForWorkAround(7000);

            //Click on Restore button
            AddNewLibraryHelper.ClickElement("ViewRestore");
            AddNewLibraryHelper.WaitForWorkAround(10000);

            AddNewLibraryHelper.AcceptAlert();
            AddNewLibraryHelper.WaitForWorkAround(10000);


            //Click on Record
            AddNewLibraryHelper.ClickElement("Selecttrashrecord");
            AddNewLibraryHelper.WaitForWorkAround(7000);

            //Click on Delete button
            AddNewLibraryHelper.ClickElement("ViewDelete");
            AddNewLibraryHelper.WaitForWorkAround(10000);

            AddNewLibraryHelper.AcceptAlert();
            AddNewLibraryHelper.WaitForWorkAround(10000);



           }
    }
}