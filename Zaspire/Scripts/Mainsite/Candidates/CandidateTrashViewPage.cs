using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class CandidateTrashViewPage : DriverTestCase
    {
        [TestMethod]
        public void candidatetrashviewpage()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var candidateTrashViewPageHelper = new CandidateTrashViewPageHelper(GetWebDriver());
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            candidateTrashViewPageHelper.ClickElement("ClickOnLeads");
            candidateTrashViewPageHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //candidateTrashViewPageHelper.WaitForWorkAround(7000);


            //Click on Trash
            //candidateTrashViewPageHelper.ClickElement("ClickOnTrash");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/trash");
            candidateTrashViewPageHelper.WaitForWorkAround(10000);

            //Click On Lead View
            candidateTrashViewPageHelper.ClickElement("ClickOnLeadView");

            //Click On Back
            candidateTrashViewPageHelper.ClickElement("ClickOnBack");

            //Click On Lead View
            candidateTrashViewPageHelper.ClickElement("ClickOnLeadView");

            //Click On Restore
            candidateTrashViewPageHelper.ClickElement("ClickOnRestore");

            //Click On Delete
            candidateTrashViewPageHelper.ClickElement("ClickOnDelete");

            
        }
    }
}