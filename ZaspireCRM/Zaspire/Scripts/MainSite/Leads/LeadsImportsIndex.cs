using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class LeadsImportsIndex : DriverTestCase
    {
        [TestMethod]
        public void leadsimportsindex()
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

            //Click on Import New
            LeadsImportsHelper.ClickElement("ClickOnImportNew");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/import");
           //LeadsImportsHelper.WaitForWorkAround(7000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/imports");
            LeadsImportsHelper.WaitForWorkAround(7000);

            //Enter Search Box
            LeadsImportsHelper.TypeText("EnterSearchBox", "Test File");
            LeadsImportsHelper.WaitForWorkAround(7000);

            //Click on Reset button
            LeadsImportsHelper.ClickElement("ClickOnReset");

            //Click on First File Name
            LeadsImportsHelper.ClickElement("ClickOnFirstFileName");

            //Click on Back button
            LeadsImportsHelper.ClickElement("ClickOnBack");

            //Click On Attachment Icon
            LeadsImportsHelper.ClickElement("ClickOnAttachmentIcon");

            //Click on Delete Icon
            LeadsImportsHelper.ClickElement("ClickOnDeleteIcon");

            LeadsImportsHelper.AcceptAlert();
            LeadsImportsHelper.WaitForWorkAround(10000);




        }
    }
}