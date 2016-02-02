using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class Jobsdeletefromviewpage : DriverTestCase
    {
        [TestMethod]
        public void jobsdeletefromviewpage()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AddEventsForJobsHelper = new AddEventsForJobsHelper(GetWebDriver());

            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            AddEventsForJobsHelper.ClickElement("ClickonCandidate");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //AddEventsForJobsHelper.WaitForWorkAround(7000);


            //Open Lead
            AddEventsForJobsHelper.ClickElement("ClickonCandiaterecord");

            //Click on Move over
            AddEventsForJobsHelper.MouseOver("locator");
            AddEventsForJobsHelper.WaitForWorkAround(10000);





            //#################### Candidate DELETE  #####################################


            //Click on Delete
            AddEventsForJobsHelper.ClickElement("CandidateDelete");
            AddEventsForJobsHelper.WaitForWorkAround(5000);

            AddEventsForJobsHelper.AcceptAlert();
            AddEventsForJobsHelper.WaitForWorkAround(5000);




        }
    }
}
