using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class EmailAccoutsIndexPageActions : DriverTestCase
    {
        [TestMethod]
        public void emailaccountindexpageactions()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username1");
            password = oXMLData.getData("settings/Credentials", "password1");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var EmailacccountsIndexPageActionsHelper = new EmailAcccountsIndexPageActionsHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Emils
            EmailacccountsIndexPageActionsHelper.ClickElement("ClickOnEmails");
            EmailacccountsIndexPageActionsHelper.WaitForWorkAround(5000);

            //Click on EmailAccounts
            EmailacccountsIndexPageActionsHelper.ClickElement("ClickOnEmailsaccounts");
            EmailacccountsIndexPageActionsHelper.WaitForWorkAround(5000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //EmailacccountsIndexPageActionsHelper.WaitForWorkAround(7000);


            //Click on resetfiltersearch

            EmailacccountsIndexPageActionsHelper.ClickElement("ClickNewButton");
            EmailacccountsIndexPageActionsHelper.WaitForWorkAround(2000);

            //Click on resetfiltersearch
            EmailacccountsIndexPageActionsHelper.ClickElement("ClickonCancelbutton");
            EmailacccountsIndexPageActionsHelper.WaitForWorkAround(2000);


            //Click on Filtersearch
            EmailacccountsIndexPageActionsHelper.TypeText("ClickOnFilterByEmailAccounts" , "NewEmails");
            EmailacccountsIndexPageActionsHelper.WaitForWorkAround(5000);

            //Click on resetfiltersearch
            EmailacccountsIndexPageActionsHelper.ClickElement("ResetFilter");

           //Click On MasterCheckbox
            EmailacccountsIndexPageActionsHelper.ClickElement("ClickonMasterCheckbox");

            //Click On removeMailAccount
            EmailacccountsIndexPageActionsHelper.ClickElement("ClickRemoveButton");
             
            //Dismiss Alert
            EmailacccountsIndexPageActionsHelper.DismissAlert();
            EmailacccountsIndexPageActionsHelper.WaitForWorkAround(2000);

            

          

           
           








        }
    }
}
