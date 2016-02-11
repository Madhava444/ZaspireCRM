using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class ContactImportView : DriverTestCase
    {
        [TestMethod]
        public void contactimportview()
        {
            string[] username = null;
            string[] password = null;

            XMLParse oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            LoginHelper loginHelper = new LoginHelper(GetWebDriver());
            ContactImportHelper ContactImportHelper = new ContactImportHelper(GetWebDriver());
            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            ContactImportHelper.WaitForWorkAround(4000);

            //Click On Client Tab
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            ContactImportHelper.WaitForWorkAround(7000);


            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/imports");
            ContactImportHelper.WaitForWorkAround(7000);

            ContactImportHelper.ClickElement("ClickOnFirstImport");

//############################# Back Option #########################

            ContactImportHelper.ClickElement("ClickOnBack");

 //########################### Bulk Actions @@@@@@@@@@@@@@@@@@@@@@@@@@@@

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/imports");
            ContactImportHelper.WaitForWorkAround(7000);

            ContactImportHelper.ClickElement("ClickOnFirstImport");

            ContactImportHelper.ClickElement("ClickOnCreateCustomerView");

            ContactImportHelper.ClickElement("ClickOnCancelButtons");

// ######################### Bulk Actions ###############################
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/imports");
            ContactImportHelper.WaitForWorkAround(7000);


            ContactImportHelper.ClickElement("ClickOnFirstImport");

            ContactImportHelper.TypeText("SearchStatus", "Live");
            ContactImportHelper.WaitForWorkAround(10000);

            //Click on Account
            ContactImportHelper.ClickElement("SelectMasterCheckbox");


            //Click on Bulk Update Button
            ContactImportHelper.MouseOver17("Locator");

            //$$$$$$$$$$$$$$$$ Bulk Update################

            ContactImportHelper.ClickElement("ClickonBulkUpdate");

            ContactImportHelper.Select("ClickOnSource", "Email");
            ContactImportHelper.WaitForWorkAround(4000);

            ContactImportHelper.Select("ClickOnOwner", "17");
            ContactImportHelper.WaitForWorkAround(4000);

            ContactImportHelper.Select("ClickOnCategory", "12398");
            ContactImportHelper.WaitForWorkAround(4000);

            ContactImportHelper.Select("ClickOnStatus", "Active");
            ContactImportHelper.WaitForWorkAround(4000);

            //Click on Upadte Button
            ContactImportHelper.ClickElement("ClickOnUpadte");
            ContactImportHelper.WaitForWorkAround(4000);

            //Accept Alert
            ContactImportHelper.AcceptAlert();
            ContactImportHelper.WaitForWorkAround(8000);

            //@@@@@@@@@@@@@@@@@@@@@@@ Bulk Email @@@@@@@@@@@@@@@@@@@@@@@@

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/imports");
            ContactImportHelper.WaitForWorkAround(7000);

            
            ContactImportHelper.TypeText("SelectStatus", "Active");
            ContactImportHelper.WaitForWorkAround(10000);

            
            ContactImportHelper.ClickElement("SelectMasterCheckbox");

            //Click on Move over
            ContactImportHelper.MouseOver17("Locator");


            //Click on Bulk Email
            ContactImportHelper.ClickElement("ClickOnBulkEmail");
            ContactImportHelper.WaitForWorkAround(4000);


            //Enter Email Cc Address
            ContactImportHelper.TypeText("EnterEmailCcAddress", "nthamishetty@chraterglobal.com");

            //Enter Email Bcc Address
            ContactImportHelper.TypeText("EnterEmailBccAddress", "nthamishetty@chraterglobal.com");

            //Enter Email Subject
            ContactImportHelper.TypeText("EnterEmailSubject", "Test Email");

            //Click On Prioroty
            ContactImportHelper.ClickElement("ClickOnPriority");

            //Click On Copy To CC Check Box
            ContactImportHelper.ClickElement("ClickOnCopyToCCCheckBox");

            //Select Copy To CC
            ContactImportHelper.Select("SelectCopyToCC", "owners");

            //Click On Copy To BCC Check Box
            ContactImportHelper.ClickElement("ClickOnCopyToBCCCheckBox");

            //Select Copy To BCC
            ContactImportHelper.Select("SelectBlindCopyToBCC", "Managers");

            //Select Email Signature
            ContactImportHelper.Select("SelectEmailSignature", "Vipin");

            //Click On Send Button
            ContactImportHelper.ClickElement("ClickOnSendButton");
            ContactImportHelper.WaitForWorkAround(10000);

            //######################## Delete Contact ############################

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/imports");
            ContactImportHelper.WaitForWorkAround(7000);

            ContactImportHelper.TypeText("SearchCompany", "Lycos");
            ContactImportHelper.WaitForWorkAround(10000);

            //Click on Bulk Update
            ContactImportHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Move over
            ContactImportHelper.MouseOver17("Locator");


            //Click on Bulk Delete
            ContactImportHelper.ClickElement("ClickOnDeleteContacts");
            ContactImportHelper.WaitForWorkAround(4000);


            ContactImportHelper.AcceptAlert();
            ContactImportHelper.WaitForWorkAround(10000);

            //$$$$$$$$$$$$$$$$$$$$$$ Add to Group $$$$$$$$$$$$$$$$$$$$$$$$$$$$$

            ContactImportHelper.TypeText("SearchCompany", "Lycos");
            ContactImportHelper.WaitForWorkAround(10000);

            //Click on Bulk Update
            ContactImportHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Move over
            ContactImportHelper.MouseOver17("Locator");


            //Click on Bulk Update
            ContactImportHelper.ClickElement("ClickOnAddToGroup");
            ContactImportHelper.WaitForWorkAround(4000);

            //Enter Add New Lead Group Name
            ContactImportHelper.TypeText("EnterGroupName", "Test Group");

            //Click On Add Leads
            ContactImportHelper.ClickElement("ClickOnAddGroupUpdate");

            ContactImportHelper.AcceptAlert();
            ContactImportHelper.WaitForWorkAround(10000);


        //############################### Add to Campaign ###############################
            ContactImportHelper.TypeText("SearchCompany", "Lycos");
            ContactImportHelper.WaitForWorkAround(10000);

            //Click on Bulk Update
            ContactImportHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Move over
            ContactImportHelper.MouseOver17("Locator");


            //Click on Bulk Update
            ContactImportHelper.ClickElement("ClickOnAddToCampaign");
            ContactImportHelper.WaitForWorkAround(4000);

            ContactImportHelper.Select("CampaignList", "10594");

            ContactImportHelper.Select("Memberstatus", "Invite");

            ContactImportHelper.Select("MemberGroups", "10594");

            //Enter Add New Lead Group Name
            ContactImportHelper.TypeText("AddNewMemberGroup", "Test Group");

            //Click On Add Leads
            ContactImportHelper.ClickElement("ClickOnAddContactButton");

            ContactImportHelper.AcceptAlert();
            ContactImportHelper.WaitForWorkAround(10000);



        }
    }
}