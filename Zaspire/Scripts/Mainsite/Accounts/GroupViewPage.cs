using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class GroupViewPage : DriverTestCase
    {
        [TestMethod]
        public void groupviewpage()
        {
            string[] username = null;
            string[] password = null;

            XMLParse oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            LoginHelper loginHelper = new LoginHelper(GetWebDriver());
            //ClientsHelper clientHelper = new ClientsHelper(GetWebDriver());
            AddAccountHelper AddAccountHelper = new AddAccountHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            AddAccountHelper.WaitForWorkAround(4000);

            //Click On Client Tab
            AddAccountHelper.ClickElement("ClickAccountsTab");
            AddAccountHelper.WaitForWorkAround(4000);

            //Click to open client info
            //AddAccountHelper.ClickElement("ClickOnGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/groups");
            AddAccountHelper.WaitForWorkAround(7000);

            // Group View Page

            //Click On Mouse Over
            AddAccountHelper.MouseOver12("locator");

            //Click On Quick Link
            AddAccountHelper.ClickElement("ClickOnQuickLink");

            //Click On View
            AddAccountHelper.ClickElement("ClickOnView");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/groups/view/11");
            AddAccountHelper.WaitForWorkAround(7000);

            //Click on Groups Add New
            AddAccountHelper.ClickElement("ClickOnGroupsAddNew");

            //################## Back Button Option ####################

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/groups");
            AddAccountHelper.WaitForWorkAround(7000);

            //Click On Mouse Over
            AddAccountHelper.MouseOver12("locator");

            //Click On Quick Link
            AddAccountHelper.ClickElement("ClickOnQuickLink");

            //Click On View
            AddAccountHelper.ClickElement("ClickOnView");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/groups/view/11");
            AddAccountHelper.WaitForWorkAround(7000);

            //Click on Back To Lead Groups Index page
            AddAccountHelper.ClickElement("ClickOnBackToAccountGroups");

            //################### Search Filter Box ################################

            //Click On Mouse Over
            AddAccountHelper.MouseOver12("locator");

            //Click On Quick Link
            AddAccountHelper.ClickElement("ClickOnQuickLink");

            //Click On View
            AddAccountHelper.ClickElement("ClickOnView");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/groups/view/11");
            AddAccountHelper.WaitForWorkAround(7000);
       
            //Enter Search Filter Box 
            AddAccountHelper.TypeText("EnterSearchFilterBox", "Test Group");
            AddAccountHelper.WaitForWorkAround(7000);

            //Click On Filter Reset Button
            AddAccountHelper.ClickElement("ClickOnFilterResetButton");
            AddAccountHelper.WaitForWorkAround(7000);

            //################### Edit Option ###############

            AddAccountHelper.ClickElement("ClickOnEditOption");

            //  ################### More Actions ##############

            //Click On Mouse Over
            AddAccountHelper.MouseOver13("locator");

            //Click On Quick Link
            AddAccountHelper.ClickElement("ClickOnQuickLinks");

            //Click On View
            AddAccountHelper.ClickElement("ClickOnDeleteOptions");

            AddAccountHelper.AcceptAlert();
            AddAccountHelper.WaitForWorkAround(7000);

            //##################### Bulk Actions #####################

            //Click On Client Tab
            AddAccountHelper.ClickElement("ClickAccountsTab");
            AddAccountHelper.WaitForWorkAround(4000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/groups");
            AddAccountHelper.WaitForWorkAround(7000);

            //Click On Mouse Over
            AddAccountHelper.MouseOver12("locator");

            //Click On Quick Link
            AddAccountHelper.ClickElement("ClickOnQuickLink");

            //Click On View
            AddAccountHelper.ClickElement("ClickOnView");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/groups/view/11");
            AddAccountHelper.WaitForWorkAround(7000);

            //$$$$$$$$$$$$$$$$$$$$$ Bulk Update $$$$$$$$$$

            //Enter Account in search field
            AddAccountHelper.TypeText("SearchStatus", "New");
            AddAccountHelper.WaitForWorkAround(10000);

            //Click on Account
            AddAccountHelper.ClickElement("SelectMasterCheckbox");

            //Click on Bulk Update Button
            AddAccountHelper.MouseOver("Locator");

            AddAccountHelper.ClickElement("ClickonBulkUpdate");

            //##################### Bulk Email ##################
            //Click on Bulk Update
            AddAccountHelper.TypeText("SearchStatus", "Existing Client");
            AddAccountHelper.WaitForWorkAround(10000);

            //Click on Bulk Update
            AddAccountHelper.ClickElement("SelectMasterCheckbox");

            //Click on Move over
            AddAccountHelper.MouseOver("Locator");


            //Click on Bulk Email
            AddAccountHelper.ClickElement("ClickOnBulkEmail");
            AddAccountHelper.WaitForWorkAround(4000);

            //Enter Email Cc Address
            AddAccountHelper.TypeText("EnterEmailCcAddress", "nthamishetty@chraterglobal.com");

            //Enter Email Bcc Address
            AddAccountHelper.TypeText("EnterEmailBccAddress", "nthamishetty@chraterglobal.com");

            //Enter Email Subject
            AddAccountHelper.TypeText("EnterEmailSubject", "Test Email");

            //Click On Priority
            AddAccountHelper.ClickElement("ClickOnPriority");

            //Click On Copy To CC Check Box
            AddAccountHelper.ClickElement("ClickOnCopyToCCCheckBox");

            //Select Copy To CC
            AddAccountHelper.Select("SelectCopyToCC", "owners");

            //Click On Copy To BCC Check Box
            AddAccountHelper.ClickElement("ClickOnCopyToBCCCheckBox");

            //Select Copy To BCC
            AddAccountHelper.Select("SelectCopyToBCC", "Managers");

            //Select Email Signature
            AddAccountHelper.Select("SelectEmailSignature", "");

            //Click On Send Button
            AddAccountHelper.ClickElement("ClickOnSendButton");
            AddAccountHelper.WaitForWorkAround(10000);


            //############## Delete from Groups ###############

            AddAccountHelper.ClickElement("ClickonAccountsTab");
            AddAccountHelper.WaitForWorkAround(4000);

            AddAccountHelper.TypeText("SearchStatus", "New");
            AddAccountHelper.WaitForWorkAround(10000);

            //Click on Bulk Update
            AddAccountHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Move over
            AddAccountHelper.MouseOver("Locator");


            //Click on Bulk Delete
            AddAccountHelper.ClickElement("ClickOnDeleteAccounts");
            AddAccountHelper.WaitForWorkAround(4000);


            AddAccountHelper.AcceptAlert();
            AddAccountHelper.WaitForWorkAround(10000);

            //############ Add to Accounts ########################

            AddAccountHelper.ClickElement("ClickOnAddAccounts");

            //Enter Account in search field
            AddAccountHelper.TypeText("SearchStatus", "New");
            AddAccountHelper.WaitForWorkAround(10000);

            //Click on Account
            AddAccountHelper.ClickElement("SelectMasterCheckbox");

            AddAccountHelper.ClickElement("ClickOnAddtoGroupOption");

            // ############## Select by using Custom View Link #########################
            AddAccountHelper.ClickElement("ClickOnCustomViewdropdown");

            AddAccountHelper.SelectDropDown("CustomViewDropdown", "custom1");

            //Enter Account in search field
            AddAccountHelper.TypeText("SearchStatus", "New");
            AddAccountHelper.WaitForWorkAround(10000);

            //Click on Account
            AddAccountHelper.ClickElement("SelectMasterCheckbox");

            AddAccountHelper.ClickElement("ClickOnAddtoGroupOption");

           


        }
    }
}