using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class LeadsCustomViewActions : DriverTestCase
    {
        [TestMethod]
        public void leadscustomviewactions()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var LeadsCustomViewActionsHelper = new LeadsCustomViewActionsHelper(GetWebDriver());
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            LeadsCustomViewActionsHelper.ClickElement("ClickOnLeads");
            LeadsCustomViewActionsHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //LeadsCustomViewActionsHelper.WaitForWorkAround(7000);

            //Select Custom View
            LeadsCustomViewActionsHelper.Select("SelectCustomView", "59");

            //Click On Set As Default Custom View
            LeadsCustomViewActionsHelper.ClickElement("ClickOnSetAsDefault");
            LeadsCustomViewActionsHelper.WaitForWorkAround(10000);

            //Click On Unset Default Custom View
            LeadsCustomViewActionsHelper.ClickElement("ClickOnUnsetDefault");
            LeadsCustomViewActionsHelper.WaitForWorkAround(10000);

            //Clock On Edit Custom View
            LeadsCustomViewActionsHelper.ClickElement("ClickOnEdit");

            //Clock On Edit Custom View cancel button
            LeadsCustomViewActionsHelper.ClickElement("ClickOnEditCancel");


            //Select Custom View
            LeadsCustomViewActionsHelper.Select("SelectCustomView", "59");

            //Clock On New Custom View
            LeadsCustomViewActionsHelper.ClickElement("ClickOnNew");

            //Clock On New Custom View cancel button
            LeadsCustomViewActionsHelper.ClickElement("ClickOnNewCancel");

            //Select Custom View
            LeadsCustomViewActionsHelper.Select("SelectCustomView", "59");

            //Clock On Delete Custom View
            LeadsCustomViewActionsHelper.ClickElement("ClickOnDelete");
            

            LeadsCustomViewActionsHelper.AcceptAlert();
            LeadsCustomViewActionsHelper.WaitForWorkAround(10000);


        }
    }
}