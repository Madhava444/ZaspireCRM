using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class JobsCustomViewsIndex : DriverTestCase
    {
        [TestMethod]
        public void jobscustomviewsindex()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username1");
            password = oXMLData.getData("settings/Credentials", "password1");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var JobsCustomViewsIndexHelper = new JobsCustomViewsIndexHelper(GetWebDriver());
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");


            //Click on Leads
            JobsCustomViewsIndexHelper.ClickElement("Clickonjobs3");
            JobsCustomViewsIndexHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //LeadsCustomViewsIndexHelper.WaitForWorkAround(7000);

            //Click on Leads Custom Views
            JobsCustomViewsIndexHelper.ClickElement("ClickOnCustomViews");
            JobsCustomViewsIndexHelper.WaitForWorkAround(10000);

            //Click on Add New
            JobsCustomViewsIndexHelper.ClickElement("ClickOnAddNew");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs/custom_views");
            JobsCustomViewsIndexHelper.WaitForWorkAround(7000);

            //Click on Delete
            JobsCustomViewsIndexHelper.ClickElement("ClickOnDelete");

            //Dismiss Alert
            JobsCustomViewsIndexHelper.DismissAlert();

           
            //Enter Filter Search Box
            JobsCustomViewsIndexHelper.TypeText("EnterFilterSearchBox", "Jobs Custom view");
            JobsCustomViewsIndexHelper.WaitForWorkAround(7000);

            //Click On Filter Reset Button
            JobsCustomViewsIndexHelper.ClickElement("ClickOnFilterReset");

            //Check Master Check Box
            JobsCustomViewsIndexHelper.ClickElement("CheckMasterCheckBox");

            //Uncheck Master Check Box
            JobsCustomViewsIndexHelper.ClickElement("CheckMasterCheckBox");

            //Click On Custom View
            JobsCustomViewsIndexHelper.ClickElement("ClickOnCustomView");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs/custom_views");
            JobsCustomViewsIndexHelper.WaitForWorkAround(7000);

            //Click On Custom View Edit
            JobsCustomViewsIndexHelper.ClickElement("ClickOnCustomViewEdit");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs/custom_views");
            JobsCustomViewsIndexHelper.WaitForWorkAround(7000);

            //Click On Custom View Delete
            JobsCustomViewsIndexHelper.ClickElement("ClickOnCustomViewDelete");

            JobsCustomViewsIndexHelper.DismissAlert();
            JobsCustomViewsIndexHelper.WaitForWorkAround(7000);

            //Click On Custom View Permission
            JobsCustomViewsIndexHelper.ClickElement("ClickOnCustomViewPermission");

            //Click On Permission check
            JobsCustomViewsIndexHelper.ClickElement("CheckBox1");

            //Click On Permission check
            JobsCustomViewsIndexHelper.ClickElement("CheckBox2");

            //Click On Permission check
            JobsCustomViewsIndexHelper.ClickElement("CheckBox3");

            //Click On Custom View Permission Save
            JobsCustomViewsIndexHelper.ClickElement("ClickOnCustomViewPermissionSave");
            JobsCustomViewsIndexHelper.WaitForWorkAround(3000);


            //Verity title
            VerifyTitle("Custom view saved successfully");


        }
    }
}
