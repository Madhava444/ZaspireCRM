using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class OpportunitiesCustomViewsIndex : DriverTestCase
    {
        [TestMethod]
        public void opportunitiescustomviewsindex()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var OpportunitiesCustomViewsIndexHelper = new OpportunitiesCustomViewsIndexHelper(GetWebDriver());
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Opportunities
            OpportunitiesCustomViewsIndexHelper.ClickElement("ClickOnOpportunities");
            OpportunitiesCustomViewsIndexHelper.WaitForWorkAround(10000);

            //Click on Opportunities Custom Views
            OpportunitiesCustomViewsIndexHelper.ClickElement("ClickOnCustomViews");
            OpportunitiesCustomViewsIndexHelper.WaitForWorkAround(10000);

            //Click on Add New
            OpportunitiesCustomViewsIndexHelper.ClickElement("ClickOnAddNew");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/opportunities/custom_views");
            OpportunitiesCustomViewsIndexHelper.WaitForWorkAround(7000);

            //Click on Delete
            OpportunitiesCustomViewsIndexHelper.ClickElement("ClickOnDelete");

            OpportunitiesCustomViewsIndexHelper.AcceptAlert();
            OpportunitiesCustomViewsIndexHelper.WaitForWorkAround(5000);

            //Click on Back
            OpportunitiesCustomViewsIndexHelper.ClickElement("ClickOnBack");

            //Click on Leads Custom Views
            OpportunitiesCustomViewsIndexHelper.ClickElement("ClickOnCustomViews");
            OpportunitiesCustomViewsIndexHelper.WaitForWorkAround(10000);

            //Enter Filter Search Box
            OpportunitiesCustomViewsIndexHelper.TypeText("EnterFilterSearchBox", "Opportunities Custom View");
            OpportunitiesCustomViewsIndexHelper.WaitForWorkAround(7000);

            //Click On Filter Reset Button
            OpportunitiesCustomViewsIndexHelper.ClickElement("ClickOnFilterReset");

            //Check Master Check Box
            OpportunitiesCustomViewsIndexHelper.ClickElement("CheckMasterCheckBox");

            //Uncheck Master Check Box
            OpportunitiesCustomViewsIndexHelper.ClickElement("CheckMasterCheckBox");

            //Click On Custom View
            OpportunitiesCustomViewsIndexHelper.ClickElement("ClickOnCustomView");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/opportunities/custom_views");
            OpportunitiesCustomViewsIndexHelper.WaitForWorkAround(7000);

            //Click On Custom View Edit
            OpportunitiesCustomViewsIndexHelper.ClickElement("ClickOnCustomViewEdit");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/opportunities/custom_views");
            OpportunitiesCustomViewsIndexHelper.WaitForWorkAround(7000);

            //Click On Custom View Delete
            OpportunitiesCustomViewsIndexHelper.ClickElement("ClickOnCustomViewDelete");

            OpportunitiesCustomViewsIndexHelper.AcceptAlert();
            OpportunitiesCustomViewsIndexHelper.WaitForWorkAround(7000);

            //Click On Custom View Permission
            OpportunitiesCustomViewsIndexHelper.ClickElement("ClickOnCustomViewPermission");

            //Click On Permission check
            OpportunitiesCustomViewsIndexHelper.ClickElement("CheckBox1");

            //Click On Permission check
            OpportunitiesCustomViewsIndexHelper.ClickElement("CheckBox2");

            //Click On Permission check
            OpportunitiesCustomViewsIndexHelper.ClickElement("CheckBox3");

            //Click On Custom View Permission Save
            OpportunitiesCustomViewsIndexHelper.ClickElement("ClickOnCustomViewPermissionSave");
            OpportunitiesCustomViewsIndexHelper.WaitForWorkAround(10000);



        }
    }
}