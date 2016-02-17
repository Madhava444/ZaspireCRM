using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class OpportunitiesImportsNew : DriverTestCase
    {
        [TestMethod]
        public void opportunitiesimportsnew()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var OpportunitiesImportsHelper = new OpportunitiesImportsHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Opportunities
            OpportunitiesImportsHelper.ClickElement("ClickOnOpportunities");
            OpportunitiesImportsHelper.WaitForWorkAround(10000);

            //Click on Opportunities Imports
            OpportunitiesImportsHelper.ClickElement("ClickOnImports");
            OpportunitiesImportsHelper.WaitForWorkAround(10000);

            //Click on Import New
            OpportunitiesImportsHelper.ClickElement("ClickOnImportNew");
            OpportunitiesImportsHelper.WaitForWorkAround(7000);

            //Click on Select File
            OpportunitiesImportsHelper.ClickElement("ClickOnDownloadLink");

            //Click on First File Name
            OpportunitiesImportsHelper.ClickElement("ClickOnSelectFile");

            //Click on Import button
            OpportunitiesImportsHelper.ClickElement("ClickOnImportButton");
            OpportunitiesImportsHelper.WaitForWorkAround(10000);
            

        }
    }
}
