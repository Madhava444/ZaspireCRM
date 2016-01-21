using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class sendemailtoPartner : DriverTestCase
    {
        [TestMethod]
        public void SendemailtoPartner()
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


            //############################ Send Email ##########################################



            //Click On record
            addpartnerHelper.ClickElement("Clickonrecord");

            //Click on Moreaction
            addpartnerHelper.MouseOver("Locater1");


            //Click on Send Email
            addpartnerHelper.ClickElement("ClickOnSendEmail");

            //Click On Employees Link
            addpartnerHelper.ClickElement("ClickOnEmployeesLink");

            //Click On To Address Check Box
            addpartnerHelper.ClickElement("ToAddressCheckBox");

            //Click On CC Address Check Box
            addpartnerHelper.ClickElement("CCAddressCheckBox");

            //Click On BCC Address Check Box
            addpartnerHelper.ClickElement("BCCAddressCheckBox");

            //Click On Add Email Address Button
            addpartnerHelper.ClickElement("ClickOnAddEmailAddress");

            //Click on Send Email Button
            addpartnerHelper.ClickElement("ClickOnSendEmailButton");
            addpartnerHelper.WaitForWorkAround(10000);


        }
    }
}

