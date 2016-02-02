using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;
using OpenQA.Selenium.Interactions;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class JobsGroupView : DriverTestCase
    {
        [TestMethod]
        public void jobsGroupView()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username1");
            password = oXMLData.getData("settings/Credentials", "password1");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var JobsgroupViewHelper = new JobsGroupViewHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            //Click on Leads
            JobsgroupViewHelper.ClickElement("Clickonjobs4");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs");
            //JobsgroupViewHelper.WaitForWorkAround(7000);


            //Click On Groups
            //JobsgroupViewHelper.ClickElement("ClickOnGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs/groups");
            JobsgroupViewHelper.WaitForWorkAround(7000);

            //Open Group
            JobsgroupViewHelper.ClickElement("ClickOnFirstGroupName");


            //################### GROUPS VIEW PAGE ACTIONS  #########################

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs/groups/addjobs/17");
       
            //Click on Add New
            //JobsgroupViewHelper.ClickElement("ClickonAddJobs");

            //Mousehover
            JobsgroupViewHelper.ClickElement("SelectMasterCheckBox");

            //Click On Add New To Groups
            JobsgroupViewHelper.ClickElement("ClickOnAddToGroup");
            JobsgroupViewHelper.WaitForWorkAround(3000);


            //Type tex in search box
            JobsgroupViewHelper.TypeText("EnterjobsSearchBox", "Test Title73");


            //Reset Search
            JobsgroupViewHelper.ClickElement("ClickOnJobsReset");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/jobs/groups");
            //JobsgroupViewHelper.WaitForWorkAround(7000);

            //Click on Edit
            JobsgroupViewHelper.ClickElement("ClickOnEdit");

            //Click on Cancel
            JobsgroupViewHelper.ClickElement("ClickOnCancelongroupedit");
            JobsgroupViewHelper.WaitForWorkAround(3000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs/groups/17");




            //Click on Candidatebulkaction view page
            JobsgroupViewHelper.ClickElement("Mastercheckbox1");

            //Mousehover on bulkactions
            JobsgroupViewHelper.MouseHover("locator");

            //Click on Candidatebulkaction view page
            JobsgroupViewHelper.ClickElement("Bulkemail1");

            //Click on BUlkemail Cancel
            JobsgroupViewHelper.ClickElement("Bulkemail1Cancel");
            JobsgroupViewHelper.WaitForWorkAround(3000);

            //Click on Candidatebulkaction view page
            JobsgroupViewHelper.ClickElement("Mastercheckbox1");

           
           //Click On Deletejob from  Groups
            JobsgroupViewHelper.MouseHover("locator");

            //Click on Delete Groups
            JobsgroupViewHelper.ClickElement("Deletejobfromgroup");

            //Dismiss alert
            JobsgroupViewHelper.DismissAlert();

            //Accept alert
           // JobsgroupViewHelper.AcceptAlert();

            //Mouse over on More actions
            JobsgroupViewHelper.MouseOver("locator");

            //Click on Delete
            JobsgroupViewHelper.ClickElement("Deletegroup");

            //Dismiss alert
            JobsgroupViewHelper.DismissAlert();



            //Remain broser
            Console.ReadKey();

            







        }
    }
}

