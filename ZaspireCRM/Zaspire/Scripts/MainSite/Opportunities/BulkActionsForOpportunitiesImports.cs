using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class BulkActionsForOpportunitiesImports : DriverTestCase
    {
        [TestMethod]
        public void bulkactionsforopportunitiesimports()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var OpportunitiesImportsHelper = new OpportunitiesImportsHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Opportunities
            OpportunitiesImportsHelper.ClickElement("ClickOnOpportunities");
            OpportunitiesImportsHelper.WaitForWorkAround(10000);

            //Click on Opportunities Imports
            OpportunitiesImportsHelper.ClickElement("ClickOnImports");
            OpportunitiesImportsHelper.WaitForWorkAround(10000);

            //Click on First File Name
            OpportunitiesImportsHelper.ClickElement("ClickOnFirstFileName");




//################### OPPORTUNITIES BULK UPDATE  #########################



            //Click on Master Check Box
            OpportunitiesImportsHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Move over
            OpportunitiesImportsHelper.MouseOver("Locator");


            //Click on Bulk Update
            OpportunitiesImportsHelper.ClickElement("ClickOnBulkUpdate");
            OpportunitiesImportsHelper.WaitForWorkAround(4000);

            //Select Status
            OpportunitiesImportsHelper.Select("SelectStatus", "Prospecting");

            //Select Source
            OpportunitiesImportsHelper.Select("SelectSource", "Email");

            //Select Category
            OpportunitiesImportsHelper.Select("SelectCategory", "12525");

            //Select Owner
            OpportunitiesImportsHelper.Select("SelectOwner", "20");

            //Select Manager
            OpportunitiesImportsHelper.Select("SelectManager", "20");

            //Click on Update
            OpportunitiesImportsHelper.ClickElement("ClickOnUpdate");
            OpportunitiesImportsHelper.WaitForWorkAround(4000);

            OpportunitiesImportsHelper.AcceptAlert();
            OpportunitiesImportsHelper.WaitForWorkAround(10000);




//###################  OPPORTUNITIES ADD TO CAMPAIGN   #########################


            
            //Click on Master Check Box
            OpportunitiesImportsHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Move over
            OpportunitiesImportsHelper.MouseOver("Locator");


            //Click on Bulk Add To Campaign
            OpportunitiesImportsHelper.ClickElement("ClickOnAddToCampaign");
            OpportunitiesImportsHelper.WaitForWorkAround(4000);

            //Click on Merge Button
            OpportunitiesImportsHelper.ClickElement("ClickOnMergeButton");

            //Click On Campaign Name
            OpportunitiesImportsHelper.ClickElement("ClickOnCampaignName");

            //Select Campaign Group
            //OpportunitiesImportsHelper.Select("SelectCampaignGroup", "10");

            //Enter Add New Campaign Group Name
            OpportunitiesImportsHelper.TypeText("EnterCampaignGroupName", "Test Group");

            //Click On Add Opportunities
            OpportunitiesImportsHelper.ClickElement("ClickOnAddOpportunities");

            OpportunitiesImportsHelper.AcceptAlert();
            OpportunitiesImportsHelper.WaitForWorkAround(10000);




//###################  OPPORTUNITIES BULK EMAIL   #########################


            
            //Click on Master Check Box
            OpportunitiesImportsHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Move over
            OpportunitiesImportsHelper.MouseOver("Locator");


            //Click on Bulk Email
            OpportunitiesImportsHelper.ClickElement("ClickOnBulkEmail");
            OpportunitiesImportsHelper.WaitForWorkAround(4000);

            //Enter Email Cc Address
            OpportunitiesImportsHelper.TypeText("EnterEmailCcAddress", "");

            //Enter Email Bcc Address
            OpportunitiesImportsHelper.TypeText("EnterEmailBccAddress", "");

            //Enter Email Subject
            OpportunitiesImportsHelper.TypeText("EnterEmailSubject", "Test Email");

            //Click On Prioroty
            OpportunitiesImportsHelper.ClickElement("ClickOnPriority");

            //Click On Copy To CC Check Box
            OpportunitiesImportsHelper.ClickElement("ClickOnCopyToCCCheckBox");

            //Select Copy To CC
            OpportunitiesImportsHelper.Select("SelectCopyToCC", "owners");

            //Click On Copy To BCC Check Box
            OpportunitiesImportsHelper.ClickElement("ClickOnCopyToBCCCheckBox");

            //Select Copy To BCC
            OpportunitiesImportsHelper.Select("SelectCopyToBCC", "Managers");

            //Select Email Signature
            OpportunitiesImportsHelper.Select("SelectEmailSignature", "");

            //Click On Send Button
            OpportunitiesImportsHelper.ClickElement("ClickOnSendButton");
            OpportunitiesImportsHelper.WaitForWorkAround(10000);




//###################  OPPORTUNITIES BULK DELETE  #########################


            
            //Click on Master Check Box
            OpportunitiesImportsHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Move over
            OpportunitiesImportsHelper.MouseOver("Locator");

            //Click on Delete Opportunities
            OpportunitiesImportsHelper.ClickElement("ClickOnDeleteOpportunities");

            OpportunitiesImportsHelper.AcceptAlert();
            OpportunitiesImportsHelper.WaitForWorkAround(10000);





        }
    }
}
