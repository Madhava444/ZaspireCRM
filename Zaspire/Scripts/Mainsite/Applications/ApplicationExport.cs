using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class ApplicationExport : DriverTestCase
    {
        [TestMethod]
        public void Applicationsexport()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var ApplicationIndexPageActionsHelper = new ApplicationsindexpageHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on candidates
            ApplicationIndexPageActionsHelper.ClickElement("ClickonApplications");
            ApplicationIndexPageActionsHelper.WaitForWorkAround(10000);

            
            //Click on Export CSV
            ApplicationIndexPageActionsHelper.ClickElement("CSVExport");
            ApplicationIndexPageActionsHelper.WaitForWorkAround(3000);


            //Click on Export PDF
            ApplicationIndexPageActionsHelper.ClickElement("PDFExport");
            ApplicationIndexPageActionsHelper.WaitForWorkAround(3000);

            
        }
    }
}
