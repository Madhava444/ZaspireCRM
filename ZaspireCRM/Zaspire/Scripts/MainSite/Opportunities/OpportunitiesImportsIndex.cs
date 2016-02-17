using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class OpportunitiesImportsIndex : DriverTestCase
    {
        [TestMethod]
        public void opportunitiesimportsindex()
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

            //Enter Search Box
            OpportunitiesImportsHelper.TypeText("EnterSearchBox", "Test File");
            OpportunitiesImportsHelper.WaitForWorkAround(7000);

            //Click on Reset button
            OpportunitiesImportsHelper.ClickElement("ClickOnReset");

            //Click on First File Name
            OpportunitiesImportsHelper.ClickElement("ClickOnFirstFileName");

            //Click on Back button
            OpportunitiesImportsHelper.ClickElement("ClickOnBack");

            //Click On Attachment Icon
            OpportunitiesImportsHelper.ClickElement("ClickOnAttachmentIcon");

            //Click on Delete Icon
            OpportunitiesImportsHelper.ClickElement("ClickOnDeleteIcon");

            OpportunitiesImportsHelper.AcceptAlert();
            OpportunitiesImportsHelper.WaitForWorkAround(10000);




        }
    }
}
