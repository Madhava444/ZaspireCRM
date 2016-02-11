using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class Candidatedeletefromviewpage : DriverTestCase
    {
        [TestMethod]
        public void candidatedeletefromviewpage()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AddEventsForCandidateHelper = new AddEventsForCandidateHelper(GetWebDriver());

            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            AddEventsForCandidateHelper.ClickElement("ClickonCandidate");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //AddEventsForCandidateHelper.WaitForWorkAround(7000);


            //Open Lead
            AddEventsForCandidateHelper.ClickElement("ClickonCandiaterecord");

            //Click on Move over
            AddEventsForCandidateHelper.MouseOver("locator");
            AddEventsForCandidateHelper.WaitForWorkAround(10000);


            


//#################### Candidate DELETE  #####################################


            //Click on Delete
            AddEventsForCandidateHelper.ClickElement("CandidateDelete");
            AddEventsForCandidateHelper.WaitForWorkAround(5000);

            AddEventsForCandidateHelper.AcceptAlert();
            AddEventsForCandidateHelper.WaitForWorkAround(5000);

            


        }
    }
}