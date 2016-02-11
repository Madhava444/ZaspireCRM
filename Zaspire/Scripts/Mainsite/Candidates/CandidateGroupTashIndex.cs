using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class CandidateGroupTashIndex : DriverTestCase
    {
        [TestMethod]
        public void candidategrouptrashindex()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var candidateGroupTrashIndexHelper = new CandidateGroupTrashIndexHelper(GetWebDriver());
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            candidateGroupTrashIndexHelper.ClickElement("ClickOnLeads");
            candidateGroupTrashIndexHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //candidateGroupTrashIndexHelper.WaitForWorkAround(7000);


            //Click on Trash
            //candidateGroupTrashIndexHelper.ClickElement("ClickOnTrash");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/trash");
            candidateGroupTrashIndexHelper.WaitForWorkAround(10000);

            //Click on Group Trash
            //candidateGroupTrashIndexHelper.ClickElement("ClickOnGroupTrash");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/groups/trash");
            candidateGroupTrashIndexHelper.WaitForWorkAround(10000);

            //Click On Back Button
            candidateGroupTrashIndexHelper.ClickElement("ClickOnBack");

            //Click On Back To LeadsTrash
            //candidateGroupTrashIndexHelper.ClickElement("ClickOnBackToLeadsGroupTrash");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/groups/trash");
            candidateGroupTrashIndexHelper.WaitForWorkAround(10000);

            //Click On Lead View
            candidateGroupTrashIndexHelper.ClickElement("ClickOnLeadView");

            //Click On Back To LeadsTrash
            //candidateGroupTrashIndexHelper.ClickElement("ClickOnBackToLeadsGroupTrash");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/groups/trash");

            //Enter Filter Search
            candidateGroupTrashIndexHelper.TypeText("EnterFilterSearch", "Test");
            candidateGroupTrashIndexHelper.WaitForWorkAround(7000);

            //Click On Reset Button
            candidateGroupTrashIndexHelper.ClickElement("ClickOnReset");

            //Click On MouseHover
            candidateGroupTrashIndexHelper.MouseHover("locator");

            //Click On Delete Forever
            candidateGroupTrashIndexHelper.ClickElement("ClickOnDeleteForever");

            candidateGroupTrashIndexHelper.AcceptAlert();
            candidateGroupTrashIndexHelper.WaitForWorkAround(5000);

            //Click On MouseHover
            candidateGroupTrashIndexHelper.MouseHover("locator");

            //Click On Restore Leads
            candidateGroupTrashIndexHelper.ClickElement("ClickOnRestoreLeads");

            candidateGroupTrashIndexHelper.AcceptAlert();
            candidateGroupTrashIndexHelper.WaitForWorkAround(5000);

            //Click On Master Check Box
            candidateGroupTrashIndexHelper.ClickElement("ClickOnMasterCheckBox");

            //Click On Master Uncheck Box
            candidateGroupTrashIndexHelper.ClickElement("ClickOnMasterCheckBox");

            //Click On Mouseover
            candidateGroupTrashIndexHelper.MouseOver("locator");

            //Click On Quick Link
            candidateGroupTrashIndexHelper.ClickElement("ClickOnQuickLink");

            //Click On Delete
            candidateGroupTrashIndexHelper.ClickElement("ClickOnDelete");

            candidateGroupTrashIndexHelper.AcceptAlert();
            candidateGroupTrashIndexHelper.WaitForWorkAround(10000);

            //Click On Mouseover
            candidateGroupTrashIndexHelper.MouseOver("locator");

            //Click On Quick Link
            candidateGroupTrashIndexHelper.ClickElement("ClickOnQuickLink");

            //Click On Restore
            candidateGroupTrashIndexHelper.ClickElement("ClickOnRestore");

            candidateGroupTrashIndexHelper.AcceptAlert();
            candidateGroupTrashIndexHelper.WaitForWorkAround(10000);

            
            
        }
    }
}
