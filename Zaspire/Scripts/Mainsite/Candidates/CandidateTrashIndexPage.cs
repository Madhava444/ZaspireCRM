using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class CandidateTrashIndexPage : DriverTestCase
    {
        [TestMethod]
        public void candidatetrashindexpage()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var candidateTrashIndexPageHelper = new CandidateTrashIndexPageHelper(GetWebDriver());
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            candidateTrashIndexPageHelper.ClickElement("ClickOnLeads");
            candidateTrashIndexPageHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //candidateTrashIndexPageHelper.WaitForWorkAround(7000);


            //Click on Trash
            //candidateTrashIndexPageHelper.ClickElement("ClickOnTrash");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/trash");
            candidateTrashIndexPageHelper.WaitForWorkAround(10000);

            //Click On Back Button
            candidateTrashIndexPageHelper.ClickElement("ClickOnBack");

            //Click On Back To LeadsTrash
            //candidateTrashIndexPageHelper.ClickElement("ClickOnBackToLeadsTrash");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/trash");

            //Click On Group Trash Button
            candidateTrashIndexPageHelper.ClickElement("ClickOnGroupTrash");

            //Click On Back To LeadsTrash
            //candidateTrashIndexPageHelper.ClickElement("ClickOnBackToLeadsTrash");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/trash");

            //Click On Lead View
            candidateTrashIndexPageHelper.ClickElement("ClickOnLeadView");

            //Click On Back To LeadsTrash
            //LeadsTrashIndexPageHelper.ClickElement("ClickOnBackToLeadsTrash");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/trash");

            //Enter Filter Search
            candidateTrashIndexPageHelper.TypeText("EnterFilterSearch", "Test");
            candidateTrashIndexPageHelper.WaitForWorkAround(7000);

            //Click On Reset Button
            candidateTrashIndexPageHelper.ClickElement("ClickOnReset");

            //Click On MouseHover
            candidateTrashIndexPageHelper.MouseHover("locator");

            //Click On Delete Forever
            candidateTrashIndexPageHelper.ClickElement("ClickOnDeleteForever");

            candidateTrashIndexPageHelper.AcceptAlert();
            candidateTrashIndexPageHelper.WaitForWorkAround(5000);

            //Click On MouseHover
            candidateTrashIndexPageHelper.MouseHover("locator");

            //Click On Restore Leads
            candidateTrashIndexPageHelper.ClickElement("ClickOnRestoreLeads");

            candidateTrashIndexPageHelper.AcceptAlert();
            candidateTrashIndexPageHelper.WaitForWorkAround(5000);

            //Click On Master Check Box
            candidateTrashIndexPageHelper.ClickElement("ClickOnMasterCheckBox");

            //Click On Master Uncheck Box
            candidateTrashIndexPageHelper.ClickElement("ClickOnMasterCheckBox");

            //Click On Mouseover
            candidateTrashIndexPageHelper.MouseOver("locator");

            //Click On Quick Link
            candidateTrashIndexPageHelper.ClickElement("ClickOnQuickLink");

            //Click On Delete
            candidateTrashIndexPageHelper.ClickElement("ClickOnDelete");

            candidateTrashIndexPageHelper.AcceptAlert();
            candidateTrashIndexPageHelper.WaitForWorkAround(10000);

            //Click On Mouseover
            candidateTrashIndexPageHelper.MouseOver("locator");

            //Click On Quick Link
            candidateTrashIndexPageHelper.ClickElement("ClickOnQuickLink");

            //Click On Restore
            candidateTrashIndexPageHelper.ClickElement("ClickOnRestore");

            candidateTrashIndexPageHelper.AcceptAlert();
            candidateTrashIndexPageHelper.WaitForWorkAround(10000);

            
            
        }
    }
}
