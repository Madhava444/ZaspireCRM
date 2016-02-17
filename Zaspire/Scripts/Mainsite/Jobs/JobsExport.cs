using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class JobsExport : DriverTestCase
    {
        [TestMethod]
        public void jobseexport()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username1");
            password = oXMLData.getData("settings/Credentials", "password1");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var jobsIndexPageActionsHelper = new JobsIndexPageActionsHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");


            //Click on candidates
            jobsIndexPageActionsHelper.ClickElement("ClickonJobs");
            jobsIndexPageActionsHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/jobs");
            //LeadsIndexPageActionsHelper.WaitForWorkAround(7000);


            //Click on Export CSV
            jobsIndexPageActionsHelper.ClickElement("CSVExport");
            jobsIndexPageActionsHelper.WaitForWorkAround(3000);


            //Click on Export PDF
            jobsIndexPageActionsHelper.ClickElement("PDFExport");
            jobsIndexPageActionsHelper.WaitForWorkAround(3000);


        }
    }
}

