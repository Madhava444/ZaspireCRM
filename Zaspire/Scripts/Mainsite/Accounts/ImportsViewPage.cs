using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class ImportsViewPage : DriverTestCase
    {
        [TestMethod]
        public void importsviewpage()
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
            AddAccountHelper.ClickElement("ClickOnImport");

            AddAccountHelper.ClickElement("ClickOnFirstImport");

            AddAccountHelper.Select("RecordsPerPage", "20");

            AddAccountHelper.TypeText("FilterTextbox", "Woods");

            AddAccountHelper.ClickElement("ClickOnReset");

//############################# Back Option #########################

            AddAccountHelper.ClickElement("ClickOnBack");

 //########################### Bulk Actions @@@@@@@@@@@@@@@@@@@@@@@@@@@@

            AddAccountHelper.ClickElement("ClickAccountsTab");
            AddAccountHelper.WaitForWorkAround(4000);

            AddAccountHelper.ClickElement("ClickOnImport");

            AddAccountHelper.ClickElement("ClickOnFirstImport");

            AddAccountHelper.ClickElement("ClickOnCreateCustomerView");

// ######################### Bulk Actions ###############################
            AddAccountHelper.ClickElement("ClickAccountsTab");
            AddAccountHelper.WaitForWorkAround(4000);

            AddAccountHelper.ClickElement("ClickOnImport");

            AddAccountHelper.ClickElement("ClickOnFirstImport");

            AddAccountHelper.TypeText("SearchStatus", "Live");
            AddAccountHelper.WaitForWorkAround(10000);

            //Click on Account
            AddAccountHelper.ClickElement("SelectMasterCheckbox");


            //Click on Bulk Update Button
            AddAccountHelper.MouseOver("Locator");

            //$$$$$$$$$$$$$$$$ Bulk Update################

            AddAccountHelper.ClickElement("ClickonBulkUpdate");

            //Select Manager
            AddAccountHelper.Select("ClickOnManager", "51");
            AddAccountHelper.WaitForWorkAround(4000);

            AddAccountHelper.Select("ClickOnPartner", "6");
            AddAccountHelper.WaitForWorkAround(4000);

            AddAccountHelper.Select("ClickOnSource", "Campaign");
            AddAccountHelper.WaitForWorkAround(4000);

            AddAccountHelper.Select("ClickOnOwner", "51");
            AddAccountHelper.WaitForWorkAround(4000);

            AddAccountHelper.Select("ClickOnCategory", "20545");
            AddAccountHelper.WaitForWorkAround(4000);

            AddAccountHelper.Select("ClickOnStatus", "New");
            AddAccountHelper.WaitForWorkAround(4000);

            //Click on Upadte Button
            AddAccountHelper.ClickElement("ClickOnUpadte");
            AddAccountHelper.WaitForWorkAround(4000);

            //Accept Alert
            AddAccountHelper.AcceptAlert();
            AddAccountHelper.WaitForWorkAround(8000);

            //@@@@@@@@@@@@@@@@@@@@@@@ Bulk Email @@@@@@@@@@@@@@@@@@@@@@@@

            //Click on Bulk Update
            AddAccountHelper.TypeText("SearchCompany", "Woods");
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

            //Click On Prioroty
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

            //######################## Delete Account ############################

            //Click On Account Tab
            AddAccountHelper.ClickElement("ClickonAccountsTab");
            AddAccountHelper.WaitForWorkAround(4000);

            AddAccountHelper.TypeText("SearchCompany", "Woods");
            AddAccountHelper.WaitForWorkAround(10000);

            //Click on Bulk Update
            AddAccountHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Move over
            AddAccountHelper.MouseOver("Locator");


            //Click on Bulk Delete
            AddAccountHelper.ClickElement("ClickOnDeleteLeads");
            AddAccountHelper.WaitForWorkAround(4000);


            AddAccountHelper.AcceptAlert();
            AddAccountHelper.WaitForWorkAround(10000);

            //$$$$$$$$$$$$$$$$$$$$$$ Add to Group $$$$$$$$$$$$$$$$$$$$$$$$$$$$$

            AddAccountHelper.TypeText("SearchCompany", "Woods");
            AddAccountHelper.WaitForWorkAround(10000);

            //Click on Bulk Update
            AddAccountHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Move over
            AddAccountHelper.MouseOver("Locator");


            //Click on Bulk Update
            AddAccountHelper.ClickElement("ClickOnAddToGroup");
            AddAccountHelper.WaitForWorkAround(4000);

            //Enter Add New Lead Group Name
            AddAccountHelper.TypeText("EnterGroupName", "Test Group");

            //Click On Add Leads
            AddAccountHelper.ClickElement("ClickOnAddGroupUpdate");

            AddAccountHelper.AcceptAlert();
            AddAccountHelper.WaitForWorkAround(10000);












        }
    }
}