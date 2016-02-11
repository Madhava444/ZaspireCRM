using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class LeadsImportsFileView : DriverTestCase
    {
        [TestMethod]
        public void leadsimportsfileview()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var LeadsImportsHelper = new LeadsImportsHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            LeadsImportsHelper.ClickElement("ClickOnLeads");
            LeadsImportsHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //LeadsImportsHelper.WaitForWorkAround(7000);

            //Click on Leads Imports
            LeadsImportsHelper.ClickElement("ClickOnImports");
            LeadsImportsHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/imports");
            //LeadsImportsHelper.WaitForWorkAround(7000);
            
            //Click on First File Name
            LeadsImportsHelper.ClickElement("ClickOnFirstFileName");


            //Click on First Record
            LeadsImportsHelper.ClickElement("ClickOnFirstRecord");

            //Click on Back Button
            LeadsImportsHelper.ClickElement("ClickOnBackButton");

            //Click on First File Name
            LeadsImportsHelper.ClickElement("ClickOnFirstFileName");

            //Click on Create Custom View Button
            LeadsImportsHelper.ClickElement("ClickOnCreateCustomView");

            //Enter Serach Box
            LeadsImportsHelper.TypeText("EnterSerachBox", "Test");

            //Click on Reset Button
            LeadsImportsHelper.ClickElement("ClickOnResetButton");

            //Click on Master Check Box
            LeadsImportsHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Master Check Box
            LeadsImportsHelper.ClickElement("ClickOnMasterCheckBox");

            //Select Pagination
            LeadsImportsHelper.Select("SelectPagination", "20");

            //Click on Pagination Next
            LeadsImportsHelper.ClickElement("ClickOnPaginationNext");

            //Click on Pagination Last
            LeadsImportsHelper.ClickElement("ClickOnPaginationLast");

            //Click on Pagination Previous
            LeadsImportsHelper.ClickElement("ClickOnPaginationPrev");

            //Click on Pagination First
            LeadsImportsHelper.ClickElement("ClickOnPaginationFirst");

        }
    }
}