using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class InterviewsExport : DriverTestCase
    {
        [TestMethod]
        public void Interviewsexport()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var InterviewIndexPageActionsHelper = new InterviewsindexpageHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on candidates
            InterviewIndexPageActionsHelper.ClickElement("ClickOnInterviewtab");
            InterviewIndexPageActionsHelper.WaitForWorkAround(10000);

            
            //Click on Export CSV
            InterviewIndexPageActionsHelper.ClickElement("CSVExport");
            InterviewIndexPageActionsHelper.WaitForWorkAround(3000);


            //Click on Export PDF
            InterviewIndexPageActionsHelper.ClickElement("PDFExport");
            InterviewIndexPageActionsHelper.WaitForWorkAround(3000);

            
        }
    }
}
