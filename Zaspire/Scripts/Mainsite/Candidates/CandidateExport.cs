using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class CandidateExport : DriverTestCase
    {
        [TestMethod]
        public void candidateexport()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var candidateIndexPageActionsHelper = new CandidateIndexPageActionsHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on candidates
            candidateIndexPageActionsHelper.ClickElement("ClickonCandidate");
            candidateIndexPageActionsHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //LeadsIndexPageActionsHelper.WaitForWorkAround(7000);


            //Click on Export CSV
            candidateIndexPageActionsHelper.ClickElement("CSVExport");
            candidateIndexPageActionsHelper.WaitForWorkAround(3000);


            //Click on Export PDF
            candidateIndexPageActionsHelper.ClickElement("PDFExport");
            candidateIndexPageActionsHelper.WaitForWorkAround(3000);

            
        }
    }
}
