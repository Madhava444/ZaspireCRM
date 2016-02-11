using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class BulkActionsForLeadsGroupView : DriverTestCase
    {
        [TestMethod]
        public void bulkactionsforleadsgroupview()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var LeadsGroupViewHelper = new LeadsGroupViewHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            LeadsGroupViewHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //LeadsGroupViewHelper.WaitForWorkAround(7000);


            //Click On Groups
            LeadsGroupViewHelper.ClickElement("ClickOnGroups");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads/groups");
            //LeadsGroupViewHelper.WaitForWorkAround(7000);

            //Open Group
            LeadsGroupViewHelper.ClickElement("FirstLeadGroupNameLink");


//################### BULK UPDATE FOR GROUPS VIEW PAGE  #########################



            //Clilk On Master Check Box
            LeadsGroupViewHelper.ClickElement("ClilkOnMasterCheckBox");
                        
            //Click On MouseOver
            LeadsGroupViewHelper.MouseOver("Locator");
            
            //Click on Add Bulk Update
            LeadsGroupViewHelper.ClickElement("ClilkOnBulkUpdate");

            //Select Status
            LeadsGroupViewHelper.Select("SelectStatus", "Qualified");

            //Select Source
            LeadsGroupViewHelper.Select("SelectSource", "Email");

            //Select Category
            LeadsGroupViewHelper.Select("SelectCategory", "12508");

            //Select Owner
            LeadsGroupViewHelper.Select("SelectOwner", "17");

            //Select Manager
            LeadsGroupViewHelper.Select("SelectManager", "17");

            //Select Partner
            LeadsGroupViewHelper.Select("SelectPartner", "4");
            
            //Click On Update
            LeadsGroupViewHelper.ClickElement("ClickOnUpdate");
            LeadsGroupViewHelper.WaitForWorkAround(10000);



//################### ADD TO CAMPAIGN FOR GROUPS VIEW PAGE  #########################



            //Clilk On Master Check Box
            LeadsGroupViewHelper.ClickElement("ClilkOnMasterCheckBox");

            //Click On MouseOver
            LeadsGroupViewHelper.MouseOver("Locator");

            //Click on Add To Campaign
            LeadsGroupViewHelper.ClickElement("ClilkOnAddToCampaign");

            //Click On Merge Button
            LeadsGroupViewHelper.ClickElement("ClickOnMergeButton");

            //Click On Campaign Name
            LeadsGroupViewHelper.ClickElement("ClickOnCampaignName");

            //Select Campaign Group
            //LeadsGroupViewHelper.Select("SelectCampaignGroup", "17");

            //Enter Campaign Group Name
            LeadsGroupViewHelper.TypeText("EnterCampaignGroupName", "Test Group");

            //Click On Add Opportunities
            LeadsGroupViewHelper.ClickElement("ClickOnAddLeads");



//###################  BULK EMAIL FOR GROUPS VIEW PAGE   #########################


                        
            //Click on Master Check Box
            LeadsGroupViewHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Move over
            LeadsGroupViewHelper.MouseOver("Locator");


            //Click on Bulk Email
            LeadsGroupViewHelper.ClickElement("ClickOnBulkEmail");
            LeadsGroupViewHelper.WaitForWorkAround(4000);

            //Enter Email Cc Address
            LeadsGroupViewHelper.TypeText("EnterEmailCcAddress", "");

            //Enter Email Bcc Address
            LeadsGroupViewHelper.TypeText("EnterEmailBccAddress", "");

            //Enter Email Subject
            LeadsGroupViewHelper.TypeText("EnterEmailSubject", "Test Email");

            //Click On Prioroty
            LeadsGroupViewHelper.ClickElement("ClickOnPriority");

            //Click On Copy To CC Check Box
            LeadsGroupViewHelper.ClickElement("ClickOnCopyToCCCheckBox");

            //Select Copy To CC
            LeadsGroupViewHelper.Select("SelectCopyToCC", "owners");

            //Click On Copy To BCC Check Box
            LeadsGroupViewHelper.ClickElement("ClickOnCopyToBCCCheckBox");

            //Select Copy To BCC
            LeadsGroupViewHelper.Select("SelectCopyToBCC", "Managers");

            //Select Email Signature
            LeadsGroupViewHelper.Select("SelectEmailSignature", "");

            //Click On Send Button
            LeadsGroupViewHelper.ClickElement("ClickOnSendButton");
            LeadsGroupViewHelper.WaitForWorkAround(10000);



//###################  BULK DELETE FOR GROUPS VIEW PAGE   #########################



            //Click on Master Check Box
            LeadsGroupViewHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Move over
            LeadsGroupViewHelper.MouseOver("Locator");


            //Click on Bulk Delete
            LeadsGroupViewHelper.ClickElement("ClickOnBulkDelete");

            LeadsGroupViewHelper.AcceptAlert();
            LeadsGroupViewHelper.WaitForWorkAround(4000);



        }
    }
}
