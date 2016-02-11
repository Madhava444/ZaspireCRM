using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;


namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class JobsCustomViewActions : DriverTestCase
    {
        [TestMethod]
        public void jobscustomviewactions()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username1");
            password = oXMLData.getData("settings/Credentials", "password1");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var jobsCustomViewActionsHelper = new JobsCustomViewActionsHelper(GetWebDriver());
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
           
            //Click on Candidates
            jobsCustomViewActionsHelper.ClickElement("ClickonJobs1");

            //Click on Leads
            jobsCustomViewActionsHelper.ClickElement("ClickonCustomViewlink");
            jobsCustomViewActionsHelper.WaitForWorkAround(10000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs");
            jobsCustomViewActionsHelper.WaitForWorkAround(3000);

            //Select Custom View
            jobsCustomViewActionsHelper.Select("SelectCustomView", "117");

            //Click On Set As Default Custom View
            jobsCustomViewActionsHelper.ClickElement("ClickOnSetAsDefault");
            jobsCustomViewActionsHelper.WaitForWorkAround(10000);

            //Click On Unset Default Custom View
            jobsCustomViewActionsHelper.ClickElement("ClickOnUnsetDefault");
            jobsCustomViewActionsHelper.WaitForWorkAround(10000);

            //Clock On Edit Custom View
            jobsCustomViewActionsHelper.ClickElement("ClickOnEdit");

            //Clock On Edit Custom View cancel button
            jobsCustomViewActionsHelper.ClickElement("ClickOnEditCancel");


            //Select Custom View
            jobsCustomViewActionsHelper.Select("SelectCustomView", "119");

            //Clock On New Custom View
            jobsCustomViewActionsHelper.ClickElement("ClickOnNew");

            //Clock On New Custom View cancel button
            jobsCustomViewActionsHelper.ClickElement("ClickOnNewCancel");

            //Select Custom View
            jobsCustomViewActionsHelper.Select("SelectCustomView", "119");

            //Clock On Delete Custom View
            jobsCustomViewActionsHelper.ClickElement("ClickOnDelete");


            jobsCustomViewActionsHelper.Dismissalert();
            jobsCustomViewActionsHelper.WaitForWorkAround(3000);


        }
    }
}
