using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class BulkActionsForOpportunityGroupView : DriverTestCase
    {
        [TestMethod]
        public void bulkactionsforopportunitygroupview()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var OpportunitiesGroupViewHelper = new OpportunitiesGroupViewHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Opportunities
            OpportunitiesGroupViewHelper.ClickElement("ClickOnOpportunities");
            OpportunitiesGroupViewHelper.WaitForWorkAround(7000);
            
            //Click On Groups
            OpportunitiesGroupViewHelper.ClickElement("ClickOnGroups");
            OpportunitiesGroupViewHelper.WaitForWorkAround(7000);

            //Open Group
            OpportunitiesGroupViewHelper.ClickElement("FirstOpportunityGroupNameLink");


//################### BULK UPDATE FOR GROUPS VIEW PAGE  #########################



            //Clilk On Master Check Box
            OpportunitiesGroupViewHelper.ClickElement("ClilkOnMasterCheckBox");
                        
            //Click On MouseOver
            OpportunitiesGroupViewHelper.MouseOver1("locator1");
            
            //Click on Add Bulk Update
            OpportunitiesGroupViewHelper.ClickElement("ClilkOnBulkUpdate");

            //Select Status
            OpportunitiesGroupViewHelper.Select("SelectStatus", "Prospecting");

            //Select Source
            OpportunitiesGroupViewHelper.Select("SelectSource", "Email");

            //Select Category
            OpportunitiesGroupViewHelper.Select("SelectCategory", "12525");

            //Select Owner
            OpportunitiesGroupViewHelper.Select("SelectOwner", "17");

            //Select Manager
            OpportunitiesGroupViewHelper.Select("SelectManager", "17");

            
            
            //Click On Update
            OpportunitiesGroupViewHelper.ClickElement("ClickOnUpdate");
            OpportunitiesGroupViewHelper.WaitForWorkAround(10000);



//################### ADD TO CAMPAIGN FOR GROUPS VIEW PAGE  #########################



            //Clilk On Master Check Box
            OpportunitiesGroupViewHelper.ClickElement("ClilkOnMasterCheckBox");

            //Click On MouseOver
            OpportunitiesGroupViewHelper.MouseOver1("locator1");

            //Click on Add To Campaign
            OpportunitiesGroupViewHelper.ClickElement("ClilkOnAddToCampaign");

            //Click On Merge Button
            OpportunitiesGroupViewHelper.ClickElement("ClickOnMergeButton");

            //Click On Campaign Name
            OpportunitiesGroupViewHelper.ClickElement("ClickOnCampaignName");

            //Select Campaign Group
            //OpportunitiesGroupViewHelper.Select("SelectCampaignGroup", "17");

            //Enter Campaign Group Name
            OpportunitiesGroupViewHelper.TypeText("EnterCampaignGroupName", "Test Group");

            //Click On Add Opportunities
            OpportunitiesGroupViewHelper.ClickElement("ClickOnAddOpportunities");



//###################  BULK EMAIL FOR GROUPS VIEW PAGE   #########################


                        
            //Click on Master Check Box
            OpportunitiesGroupViewHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Move over
            OpportunitiesGroupViewHelper.MouseOver1("locator1");


            //Click on Bulk Email
            OpportunitiesGroupViewHelper.ClickElement("ClickOnBulkEmail");
            OpportunitiesGroupViewHelper.WaitForWorkAround(4000);

            //Enter Email Cc Address
            OpportunitiesGroupViewHelper.TypeText("EnterEmailCcAddress", "");

            //Enter Email Bcc Address
            OpportunitiesGroupViewHelper.TypeText("EnterEmailBccAddress", "");

            //Enter Email Subject
            OpportunitiesGroupViewHelper.TypeText("EnterEmailSubject", "Test Email");

            //Click On Prioroty
            OpportunitiesGroupViewHelper.ClickElement("ClickOnPriority");

            //Click On Copy To CC Check Box
            OpportunitiesGroupViewHelper.ClickElement("ClickOnCopyToCCCheckBox");

            //Select Copy To CC
            OpportunitiesGroupViewHelper.Select("SelectCopyToCC", "owners");

            //Click On Copy To BCC Check Box
            OpportunitiesGroupViewHelper.ClickElement("ClickOnCopyToBCCCheckBox");

            //Select Copy To BCC
            OpportunitiesGroupViewHelper.Select("SelectCopyToBCC", "Managers");

            //Select Email Signature
            OpportunitiesGroupViewHelper.Select("SelectEmailSignature", "");

            //Click On Send Button
            OpportunitiesGroupViewHelper.ClickElement("ClickOnSendButton");
            OpportunitiesGroupViewHelper.WaitForWorkAround(10000);



//###################  BULK DELETE FOR GROUPS VIEW PAGE   #########################



            //Click on Master Check Box
            OpportunitiesGroupViewHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Move over
            OpportunitiesGroupViewHelper.MouseOver1("locator1");


            //Click on Bulk Delete
            OpportunitiesGroupViewHelper.ClickElement("ClickOnBulkDelete");

            OpportunitiesGroupViewHelper.AcceptAlert();
            OpportunitiesGroupViewHelper.WaitForWorkAround(4000);



        }
    }
}