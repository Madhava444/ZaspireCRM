using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class BulkActionsForLeadsImports : DriverTestCase
    {
        [TestMethod]
        public void bulkactionsforleadsimports()
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

            
            
//################### LEADS BULK UPDATE  #########################


            //Click on Master Check Box
            LeadsImportsHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Move over
            LeadsImportsHelper.MouseOver1("Locator1");


            //Click on Bulk Update
            LeadsImportsHelper.ClickElement("ClickOnBulkUpdate");
            LeadsImportsHelper.WaitForWorkAround(4000);

            //Select Status
            LeadsImportsHelper.Select("SelectStatus", "In Process");

            //Select Source
            LeadsImportsHelper.Select("SelectSource", "Email");

            //Select Category
            LeadsImportsHelper.Select("SelectCategory", "9247");

            //Select Owner
            LeadsImportsHelper.Select("SelectOwner", "57");

            //Select Manager
            LeadsImportsHelper.Select("SelectManager", "58");

            //Select Partner
            LeadsImportsHelper.Select("SelectPartner", "");


            //Click on Update
            LeadsImportsHelper.ClickElement("ClickOnUpdate");
            LeadsImportsHelper.WaitForWorkAround(4000);

            LeadsImportsHelper.AcceptAlert();
            LeadsImportsHelper.WaitForWorkAround(10000);




//###################  LEADS ADD TO CAMPAIGN   #########################


            //Click on Master Check Box
            LeadsImportsHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Move over
            LeadsImportsHelper.MouseOver("Locator");


            //Click on Bulk Update
            LeadsImportsHelper.ClickElement("ClickOnAddToCampaign");
            LeadsImportsHelper.WaitForWorkAround(4000);

            //Click on Merge Button
            LeadsImportsHelper.ClickElement("ClickOnMergeButton");

            //Click On Campaign Name
            LeadsImportsHelper.ClickElement("ClickOnCampaignName");

            //Select Campaign Group
            //LeadsImportsHelper.Select("SelectCampaignGroup", "10");

            //Enter Add New Campaign Group Name
            LeadsImportsHelper.TypeText("EnterCampaignGroupName", "Test Group");

            //Click On Add Leads
            LeadsImportsHelper.ClickElement("ClickOnAddLeads");

            LeadsImportsHelper.AcceptAlert();
            LeadsImportsHelper.WaitForWorkAround(10000);


            
//###################  LEADS ADD TO GROUP   #########################


            //Click on Master Check Box
            LeadsImportsHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Move over
            LeadsImportsHelper.MouseOver("Locator");


            //Click on Add To Group
            LeadsImportsHelper.ClickElement("ClickOnAddToGroup");
            LeadsImportsHelper.WaitForWorkAround(4000);


            //Select Lead Group
            //LeadsImportsHelper.Select("SelectLeadGroup", "10");

            //Enter Add New Lead Group Name
            LeadsImportsHelper.TypeText("EnterLaedGroupName", "Test Group");

            //Click On Add Leads
            LeadsImportsHelper.ClickElement("ClickOnAddGroupUpdate");

            LeadsImportsHelper.AcceptAlert();
            LeadsImportsHelper.WaitForWorkAround(10000);



//###################  LEADS BULK EMAIL   #########################


            //Click on Master Check Box
            LeadsImportsHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Move over
            LeadsImportsHelper.MouseOver("Locator");


            //Click on Bulk Email
            LeadsImportsHelper.ClickElement("ClickOnBulkEmail");
            LeadsImportsHelper.WaitForWorkAround(4000);

            //Enter Email Cc Address
            LeadsImportsHelper.TypeText("EnterEmailCcAddress", "");

            //Enter Email Bcc Address
            LeadsImportsHelper.TypeText("EnterEmailBccAddress", "");

            //Enter Email Subject
            LeadsImportsHelper.TypeText("EnterEmailSubject", "Test Email");

            //Click On Prioroty
            LeadsImportsHelper.ClickElement("ClickOnPriority");

            //Click On Copy To CC Check Box
            LeadsImportsHelper.ClickElement("ClickOnCopyToCCCheckBox");

            //Select Copy To CC
            LeadsImportsHelper.Select("SelectCopyToCC", "owners");

            //Click On Copy To BCC Check Box
            LeadsImportsHelper.ClickElement("ClickOnCopyToBCCCheckBox");

            //Select Copy To BCC
            LeadsImportsHelper.Select("SelectCopyToBCC", "Managers");

            //Select Email Signature
            LeadsImportsHelper.Select("SelectEmailSignature", "");

            //Click On Send Button
            LeadsImportsHelper.ClickElement("ClickOnSendButton");
            LeadsImportsHelper.WaitForWorkAround(10000);



//################### BULK DELETE LEADS  #########################


            //Click on Master Check Box
            LeadsImportsHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Move over
            LeadsImportsHelper.MouseOver("Locator");


            //Click on Bulk Delete
            LeadsImportsHelper.ClickElement("ClickOnDeleteLeads");
            LeadsImportsHelper.WaitForWorkAround(4000);


            LeadsImportsHelper.AcceptAlert();
            LeadsImportsHelper.WaitForWorkAround(10000);

        }
    }
}