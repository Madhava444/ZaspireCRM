using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Zaspire.Locators;
using Zaspire.PageHelpers.Com;
using Zaspire.PageHelpers;
using OpenQA.Selenium.Interactions;

namespace Zaspire.Scripts
{
    [TestClass]
   public class DataDriven : DriverTestCase
    {
    

    [TestMethod]

        public void Datadrivenforlogin()
        {
            string[] username = null;
            string[] password = null;
        
;
            var oXmaldata = new XMLParse();

        oXmaldata.LoadXML("../../Config/OrganizationSetting.xml");
        username = oXmaldata.getData("settings/Credentials", "username1");
        password = oXmaldata.getData("settings/Credentials",  "password1");

        //Initializing the objects
        var loginHelper = new LoginHelper(GetWebDriver());

       GetDataFromEXL("filepath", "Usertype", "Column");



        }

    }
}
