using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class CandidateCustomViewsIndex : DriverTestCase
    {
        [TestMethod]
        public void candidatecustomviewsindex()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var CandidateCustomViewsIndexHelper = new CandidateCustomViewsIndexHelper(GetWebDriver());
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            CandidateCustomViewsIndexHelper.ClickElement("ClickOnLeads");
            CandidateCustomViewsIndexHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //LeadsCustomViewsIndexHelper.WaitForWorkAround(7000);

            //Click on Leads Custom Views
            CandidateCustomViewsIndexHelper.ClickElement("ClickOnCustomViews");
            CandidateCustomViewsIndexHelper.WaitForWorkAround(10000);

            //Click on Add New
            CandidateCustomViewsIndexHelper.ClickElement("ClickOnAddNew");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/custom_views");
            CandidateCustomViewsIndexHelper.WaitForWorkAround(7000);

            //Click on Delete
            CandidateCustomViewsIndexHelper.ClickElement("ClickOnDelete");

            //Click on Back
            CandidateCustomViewsIndexHelper.ClickElement("ClickOnBack");

            //Click on Leads Custom Views
            CandidateCustomViewsIndexHelper.ClickElement("ClickOnCustomViews");
            CandidateCustomViewsIndexHelper.WaitForWorkAround(10000);

            //Enter Filter Search Box
            CandidateCustomViewsIndexHelper.TypeText("EnterFilterSearchBox", "Lead Custom View");
            CandidateCustomViewsIndexHelper.WaitForWorkAround(7000);

            //Click On Filter Reset Button
            CandidateCustomViewsIndexHelper.ClickElement("ClickOnFilterReset");

            //Check Master Check Box
            CandidateCustomViewsIndexHelper.ClickElement("CheckMasterCheckBox");

            //Uncheck Master Check Box
            CandidateCustomViewsIndexHelper.ClickElement("CheckMasterCheckBox");

            //Click On Custom View
            CandidateCustomViewsIndexHelper.ClickElement("ClickOnCustomView");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/custom_views");
            CandidateCustomViewsIndexHelper.WaitForWorkAround(7000);

            //Click On Custom View Edit
            CandidateCustomViewsIndexHelper.ClickElement("ClickOnCustomViewEdit");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/custom_views");
            CandidateCustomViewsIndexHelper.WaitForWorkAround(7000);

            //Click On Custom View Delete
            CandidateCustomViewsIndexHelper.ClickElement("ClickOnCustomViewDelete");

            CandidateCustomViewsIndexHelper.AcceptAlert();
            CandidateCustomViewsIndexHelper.WaitForWorkAround(7000);

            //Click On Custom View Permission
            CandidateCustomViewsIndexHelper.ClickElement("ClickOnCustomViewPermission");

            //Click On Permission check
            CandidateCustomViewsIndexHelper.ClickElement("CheckBox1");

            //Click On Permission check
            CandidateCustomViewsIndexHelper.ClickElement("CheckBox2");

            //Click On Permission check
            CandidateCustomViewsIndexHelper.ClickElement("CheckBox3");

            //Click On Custom View Permission Save
            CandidateCustomViewsIndexHelper.ClickElement("ClickOnCustomViewPermissionSave");
            CandidateCustomViewsIndexHelper.WaitForWorkAround(10000);



        }
    }
}