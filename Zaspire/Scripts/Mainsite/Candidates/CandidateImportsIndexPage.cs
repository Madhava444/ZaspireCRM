using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class CandidateImportsIndexPage : DriverTestCase
    {
        [TestMethod]
        public void candidateimportsindexpage()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var CandidateImportsHelper = new CandidateImportsHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            CandidateImportsHelper.ClickElement("ClickOnLeads");
            CandidateImportsHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //CandidateImportsHelper.WaitForWorkAround(7000);

            //Click on Leads Imports
            //CandidateImportsHelper.ClickElement("ClickOnImports");
            //CandidateImportsHelper.WaitForWorkAround(10000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/imports");
            CandidateImportsHelper.WaitForWorkAround(7000);

            //Click on Import New
            //LeadsImportsHelper.ClickElement("ClickOnImportNew");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/import");
            CandidateImportsHelper.WaitForWorkAround(7000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/imports");
            CandidateImportsHelper.WaitForWorkAround(7000);

            //Enter Search Box
            CandidateImportsHelper.TypeText("EnterSearchBox", "Test File");
            CandidateImportsHelper.WaitForWorkAround(7000);

            //Click on Reset button
            CandidateImportsHelper.ClickElement("ClickOnReset");

            //Click on First File Name
            CandidateImportsHelper.ClickElement("ClickOnFirstFileName");

            //Click on Back button
            CandidateImportsHelper.ClickElement("ClickOnBack");

            //Click On Attachment Icon
            CandidateImportsHelper.ClickElement("ClickOnAttachmentIcon");

            //Click on Delete Icon
            CandidateImportsHelper.ClickElement("ClickOnDeleteIcon");

            CandidateImportsHelper.AcceptAlert();
            CandidateImportsHelper.WaitForWorkAround(10000);




        }
    }
}