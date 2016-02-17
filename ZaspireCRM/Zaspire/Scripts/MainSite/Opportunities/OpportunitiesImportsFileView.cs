using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class OpportunitiesImportsFileView : DriverTestCase
    {
        [TestMethod]
        public void opportunitiesimportsfileview()
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

            //Click on First File Name
            OpportunitiesImportsHelper.ClickElement("ClickOnFirstFileName");


            //Click on First Record
            OpportunitiesImportsHelper.ClickElement("ClickOnFirstRecord");

            //Click on Back Button
            OpportunitiesImportsHelper.ClickElement("ClickOnBackButton");

            //Click on First File Name
            OpportunitiesImportsHelper.ClickElement("ClickOnFirstFileName");

            //Click on Create Custom View Button
            OpportunitiesImportsHelper.ClickElement("ClickOnCreateCustomView");

            //Enter Serach Box
            OpportunitiesImportsHelper.TypeText("EnterSerachBox", "Test");

            //Click on Reset Button
            OpportunitiesImportsHelper.ClickElement("ClickOnResetButton");

            //Click on Master Check Box
            OpportunitiesImportsHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Master Check Box
            OpportunitiesImportsHelper.ClickElement("ClickOnMasterCheckBox");

            //Select Pagination
            OpportunitiesImportsHelper.Select("SelectPagination", "20");

            //Click on Pagination Next
            OpportunitiesImportsHelper.ClickElement("ClickOnPaginationNext");

            //Click on Pagination Last
            OpportunitiesImportsHelper.ClickElement("ClickOnPaginationLast");

            //Click on Pagination Previous
            OpportunitiesImportsHelper.ClickElement("ClickOnPaginationPrev");

            //Click on Pagination First
            OpportunitiesImportsHelper.ClickElement("ClickOnPaginationFirst");

        }
    }
}
