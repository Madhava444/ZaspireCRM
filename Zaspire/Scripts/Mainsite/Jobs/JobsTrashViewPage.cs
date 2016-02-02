using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class JobsTrashViewPage : DriverTestCase
    {
        [TestMethod]
        public void jobstrashviewpage()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username1");
            password = oXMLData.getData("settings/Credentials", "password1");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var jobsTrashViewPageHelper = new JobsTrashViewPageHelper(GetWebDriver());
            var JobsBulkActionsHelper = new JobsBulkActionsHelper(GetWebDriver());
            var AddNewjobsHelper = new AddNewjobsHelper(GetWebDriver());
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            AddNewjobsHelper.ClickElement("ClickonJobs");


            //################### BULK DELETE LEADS  #########################


            //Click on Bulk Update
            JobsBulkActionsHelper.TypeText("Searchjob", "Job");
            JobsBulkActionsHelper.WaitForWorkAround(10000);

            //Click on Bulk Update
            JobsBulkActionsHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Move over
            JobsBulkActionsHelper.MouseOver("locator");


            //Click on Bulk Delete
            JobsBulkActionsHelper.ClickElement("ClickOnDeletejobs");
            JobsBulkActionsHelper.WaitForWorkAround(4000);


            JobsBulkActionsHelper.AcceptAlert();
            JobsBulkActionsHelper.WaitForWorkAround(5000);

            
            //Click on Trash
            jobsTrashViewPageHelper.ClickElement("ClickOnTrash");
            jobsTrashViewPageHelper.WaitForWorkAround(5000);

            //Click On job View
            jobsTrashViewPageHelper.ClickElement("ClickOnjobView1");
            jobsTrashViewPageHelper.WaitForWorkAround(3000);

            //Click on Details tab
            jobsTrashViewPageHelper.ClickElement("ClickOnDetailstab");
            jobsTrashViewPageHelper.WaitForWorkAround(2000);

            //Click on App tab
            jobsTrashViewPageHelper.ClickElement("ClickOnapptab");
            jobsTrashViewPageHelper.WaitForWorkAround(2000);

            //Click on Activity tab
            jobsTrashViewPageHelper.ClickElement("ClickOnactivitytab");
            jobsTrashViewPageHelper.WaitForWorkAround(2000);

            //Click on Description tab
            jobsTrashViewPageHelper.ClickElement("ClickOndestab");
            jobsTrashViewPageHelper.WaitForWorkAround(2000);

            //Click on timeline tab
            jobsTrashViewPageHelper.ClickElement("ClickOntimelinetab");
            jobsTrashViewPageHelper.WaitForWorkAround(2000);

            //Click on Restore
            jobsTrashViewPageHelper.ClickElement("trashviewrestore");
            jobsTrashViewPageHelper.WaitForWorkAround(2000);

  //################################ Delete job from view page ##################

            AddNewjobsHelper.ClickElement("ClickonJobs");
            AddNewjobsHelper.WaitForWorkAround(3000);

            //################### BULK DELETE LEADS  #########################


            //Click on Bulk Update
            JobsBulkActionsHelper.TypeText("Searchjob", "Job");
            JobsBulkActionsHelper.WaitForWorkAround(10000);

            //Click on Bulk Update
            JobsBulkActionsHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Move over
            JobsBulkActionsHelper.MouseOver("locator");


            //Click on Bulk Delete
            JobsBulkActionsHelper.ClickElement("ClickOnDeletejobs");
            JobsBulkActionsHelper.WaitForWorkAround(4000);


            JobsBulkActionsHelper.AcceptAlert();
            JobsBulkActionsHelper.WaitForWorkAround(5000);

            //Click on Trash
            jobsTrashViewPageHelper.ClickElement("ClickOnTrash");
            jobsTrashViewPageHelper.WaitForWorkAround(5000);

            //Click On job View
            jobsTrashViewPageHelper.ClickElement("ClickOnjobView1");
            jobsTrashViewPageHelper.WaitForWorkAround(3000);

            //Click on Delete
            jobsTrashViewPageHelper.ClickElement("trashviewDelete");
            jobsTrashViewPageHelper.WaitForWorkAround(3000);





        }
    }
}
