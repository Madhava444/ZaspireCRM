using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class JobsImportsIndexPage : DriverTestCase
    {
        [TestMethod]
        public void jobsimportsindexpage()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username1");
            password = oXMLData.getData("settings/Credentials", "password1");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var JobsimportsHelper = new JobsImportsHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            JobsimportsHelper.ClickElement("ClickonJobs");
            JobsimportsHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/jobs");
            //JobsimportsHelper.WaitForWorkAround(7000);

            //Click on Leads Imports
            //JobsimportsHelper.ClickElement("ClickOnImports");
            //JobsimportsHelper.WaitForWorkAround(10000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs/imports");
            JobsimportsHelper.WaitForWorkAround(3000);

            //Click on Import New
            //JobsimportsHelper.ClickElement("ClickOnImportNew");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs/import");
            JobsimportsHelper.WaitForWorkAround(3000);

            //Click on Cancel
            JobsimportsHelper.ClickElement("ClickOnImportNewCancel");
            JobsimportsHelper.WaitForWorkAround(3000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs/imports");
            JobsimportsHelper.WaitForWorkAround(3000);

           //Enter Search Box
            JobsimportsHelper.TypeText("EnterSearchBox", "jobs (2).csv");
            JobsimportsHelper.WaitForWorkAround(7000);

            //Click on Reset button
            JobsimportsHelper.ClickElement("ClickOnReset");

            //Click on First File Name
            JobsimportsHelper.ClickElement("ClickOnFirstFileName");

            //Click on Back button
            JobsimportsHelper.ClickElement("ClickOnBack");

            //Click On Attachment Icon
            JobsimportsHelper.ClickElement("ClickOnAttachmentIcon");

            //Click on Delete Icon
            JobsimportsHelper.ClickElement("ClickOnDeleteIcon");

            //JobsimportsHelper.AcceptAlert();
            //JobsimportsHelper.WaitForWorkAround(10000);




        }
    }
}
