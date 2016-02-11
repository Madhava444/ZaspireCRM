using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite

    {
        [TestClass]
        public class Draft : DriverTestCase
        {
            [TestMethod]
            public void draft()
            {
                string[] username = null;
                string[] password = null;

                XMLParse oXMLData = new XMLParse();
                oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

                username = oXMLData.getData("settings/Credentials", "username");
                password = oXMLData.getData("settings/Credentials", "password");

                //Initializing the objects
                LoginHelper loginHelper = new LoginHelper(GetWebDriver());
                EmailHelper EmailHelper = new EmailHelper(GetWebDriver());

                //Login with valid username and password
                Login(username[0], password[0]);
                Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

                //Verify Page title
                VerifyTitle("Dashboard");
                Console.WriteLine("Redirected at Dashboard screen.");
                EmailHelper.WaitForWorkAround(4000);

                GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/mails");
                EmailHelper.WaitForWorkAround(7000);


                //################### To Address ########################

                //************** Employee Link *********************
                EmailHelper.TypeText("SearchByEmailIdFilter", "vipinp");

                EmailHelper.ClickElement("ClickOnSearchButton");

                EmailHelper.ClickElement("EnabletheCheckbox");

                EmailHelper.ClickElement("ClickOnAddButton");

                // ************ To Address Manually ***********

                EmailHelper.TypeText("EnterToAddress", "vipin.purushotam@infozeal.com");

                //Enter Email Subject
                EmailHelper.TypeText("EnterEmailSubject", "Test Email");

                //************** Subject *******************

                EmailHelper.TypeText("Description", "This is Sample mail");

                //****************** Draft *****************

                EmailHelper.ClickElement("ClickOnDraftButton");

                //###################### Draft Folder #####################

                GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/mails/draft");
                EmailHelper.WaitForWorkAround(7000);

                EmailHelper.ClickElement("ClickOnSendButton");


            }
        }
}