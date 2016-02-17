using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class CandidateCustomViewActions : DriverTestCase
    {
        [TestMethod]
        public void candidatecustomviewactions()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var candidateCustomViewActionsHelper = new CandidateCustomViewActionsHelper(GetWebDriver());
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
           
            //Click on Candidates
            candidateCustomViewActionsHelper.ClickElement("ClickOnCandidates");


            //Click on Leads
            candidateCustomViewActionsHelper.ClickElement("SelectCustomView");
            candidateCustomViewActionsHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //candidateCustomViewActionsHelper.WaitForWorkAround(7000);

            //Select Custom View
            candidateCustomViewActionsHelper.Select("SelectCustomView", "96");

            //Click On Set As Default Custom View
            candidateCustomViewActionsHelper.ClickElement("ClickOnSetAsDefault");
            candidateCustomViewActionsHelper.WaitForWorkAround(10000);

            //Click On Unset Default Custom View
            candidateCustomViewActionsHelper.ClickElement("ClickOnUnsetDefault");
            candidateCustomViewActionsHelper.WaitForWorkAround(10000);

            //Clock On Edit Custom View
            candidateCustomViewActionsHelper.ClickElement("ClickOnEdit");

            //Clock On Edit Custom View cancel button
            candidateCustomViewActionsHelper.ClickElement("ClickOnEditCancel");


            //Select Custom View
            candidateCustomViewActionsHelper.Select("SelectCustomView", "96");

            //Clock On New Custom View
            candidateCustomViewActionsHelper.ClickElement("ClickOnNew");

            //Clock On New Custom View cancel button
            candidateCustomViewActionsHelper.ClickElement("ClickOnNewCancel");

            //Select Custom View
            candidateCustomViewActionsHelper.Select("SelectCustomView", "96");

            //Clock On Delete Custom View
            candidateCustomViewActionsHelper.ClickElement("ClickOnDelete");


            candidateCustomViewActionsHelper.AcceptAlert();
            candidateCustomViewActionsHelper.WaitForWorkAround(10000);


        }
    }
}