using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class JobsTrashIndexPage : DriverTestCase
    {
        [TestMethod]
        public void jobstrashindexpage()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username1");
            password = oXMLData.getData("settings/Credentials", "password1");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var jobsTrashIndexPageHelper = new JobsTrashIndexPageHelper(GetWebDriver());
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            jobsTrashIndexPageHelper.ClickElement("ClickonJobs");
            jobsTrashIndexPageHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //jobsTrashIndexPageHelper.WaitForWorkAround(7000);


            //Click on Trash
            jobsTrashIndexPageHelper.ClickElement("ClickOnTrash");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/trash");
            jobsTrashIndexPageHelper.WaitForWorkAround(3000);

            //Click On Back Button
            jobsTrashIndexPageHelper.ClickElement("ClickOnBack");

            //Click On Back To LeadsTrash
            //jobsTrashIndexPageHelper.ClickElement("ClickOnBackToLeadsTrash");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdo/candidates/trash");

            //Click on Trash
            jobsTrashIndexPageHelper.ClickElement("ClickOnTrash");
            jobsTrashIndexPageHelper.WaitForWorkAround(3000);

            //Click On Group Trash Button
            jobsTrashIndexPageHelper.ClickElement("ClickOnGroupTrash");

            jobsTrashIndexPageHelper.ClickElement("ClickOnGroupTrashback");

            //Click On Back To LeadsTrash
            //jobsTrashIndexPageHelper.ClickElement("ClickOnBackToLeadsTrash");

           // GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates/trash");

            //Click On Lead View
            jobsTrashIndexPageHelper.ClickElement("ClickOnjobView1");

            //Click on Back
            jobsTrashIndexPageHelper.ClickElement("trashjobView1back");


            //Click on Trash
            jobsTrashIndexPageHelper.ClickElement("ClickOnTrash");
            jobsTrashIndexPageHelper.WaitForWorkAround(3000);


            //Click On Back To LeadsTrash
            //LeadsTrashIndexPageHelper.ClickElement("ClickOnBackToLeadsTrash");

          

            //Enter Filter Search
            jobsTrashIndexPageHelper.TypeText("trashFilterSearch", "job");
            jobsTrashIndexPageHelper.WaitForWorkAround(10000);

            //Click On Reset Button
            jobsTrashIndexPageHelper.ClickElement("ClickOnReset11");
           
            //Click On Master Check Box
            jobsTrashIndexPageHelper.ClickElement("Trashmastercheckbox");


            //Click On MouseHover
            jobsTrashIndexPageHelper.MouseHover("locator");

            //Click On Delete Forever
            jobsTrashIndexPageHelper.ClickElement("ClickOnDeleteForever");

            jobsTrashIndexPageHelper.DismissAlert();
            jobsTrashIndexPageHelper.WaitForWorkAround(3000);


            //Refresh page
            RefreshPage();

            //Click On Master Check Box
            jobsTrashIndexPageHelper.ClickElement("Trashmastercheckbox");

            //Click On MouseHover
            jobsTrashIndexPageHelper.MouseHover("locator");

            //Click On Restore Leads
            jobsTrashIndexPageHelper.ClickElement("ClickOnRestoreJobs");

            jobsTrashIndexPageHelper.DismissAlert();
            jobsTrashIndexPageHelper.WaitForWorkAround(3000);

            //Refresh page
            RefreshPage();


            
            //Click On Mouseover
            jobsTrashIndexPageHelper.MouseOver("locator");

            //Click On Quick Link
            jobsTrashIndexPageHelper.ClickElement("ClickOnQuickLink1");

            //Click On Delete
            jobsTrashIndexPageHelper.ClickElement("ClickOnDelete1");

            jobsTrashIndexPageHelper.DismissAlert();
            jobsTrashIndexPageHelper.WaitForWorkAround(3000);

            //Click On Mouseover
            jobsTrashIndexPageHelper.MouseOver("locator");

            //Click On Quick Link
            jobsTrashIndexPageHelper.ClickElement("ClickOnQuickLink1");

            //Click On Restore
            jobsTrashIndexPageHelper.ClickElement("ClickOnRestore1");

            



        }
    }
}

