using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    class BulkUpdate
    {
        [TestClass]
        public class bulkUpdate : DriverTestCase
        {
            [TestMethod]
            public void bulkupdate()
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
                AddContactHelper addcontacHelper = new AddContactHelper(GetWebDriver());
                

                //Login with valid username and password
                Login(username[0], password[0]);
                Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

                //Verify Page title
                VerifyTitle("Dashboard");
                Console.WriteLine("Redirected at Dashboard screen.");
                addcontacHelper.WaitForWorkAround(4000);

                //Click On Account Tab
                addcontacHelper.ClickElement("ClickoncContactsTab");
                addcontacHelper.WaitForWorkAround(4000);

               //################# Bulk Update ##########################

                //Enter Account in search field
                addcontacHelper.TypeText("SearchStatus", "New");
                addcontacHelper.WaitForWorkAround(10000);

                //Click on Account
                addcontacHelper.ClickElement("SelectMasterCheckbox");

             
                //Click on Bulk Update Button
                addcontacHelper.MouseOver("Locator");


                addcontacHelper.ClickElement("ClickonBulkUpdate");

                //Select Manager
                addcontacHelper.Select("ClickOnManager", "51");
                addcontacHelper.WaitForWorkAround(4000);

                addcontacHelper.Select("ClickOnPartner", "6");
                addcontacHelper.WaitForWorkAround(4000);

                addcontacHelper.Select("ClickOnSource", "Campaign");
                addcontacHelper.WaitForWorkAround(4000);

                addcontacHelper.Select("ClickOnOwner", "51");
                addcontacHelper.WaitForWorkAround(4000);

                addcontacHelper.Select("ClickOnCategory", "20545");
                addcontacHelper.WaitForWorkAround(4000);

                addcontacHelper.Select("ClickOnStatus", "New");
                addcontacHelper.WaitForWorkAround(4000);

                //Click on Upadte Button
                addcontacHelper.ClickElement("ClickOnUpadte");
                addcontacHelper.WaitForWorkAround(4000);

                //Accept Alert
                addcontacHelper.AcceptAlert();
                addcontacHelper.WaitForWorkAround(8000);


    //&&&&&&&&&&&&&&&&&&&&&&&&&&& Bulk Email &&&&&&&&&&&&&&&&&&&&&&&&&&&&

                //Click on Bulk Update
                addcontacHelper.TypeText("SearchCompany", "Woods");
                addcontacHelper.WaitForWorkAround(10000);

                //Click on Bulk Update
                addcontacHelper.ClickElement("SelectMasterCheckbox");

                //Click on Move over
                addcontacHelper.MouseOver("Locator");


                //Click on Bulk Email
                addcontacHelper.ClickElement("ClickOnBulkEmail");
                addcontacHelper.WaitForWorkAround(4000);

                //Enter Email Cc Address
                addcontacHelper.TypeText("EnterEmailCcAddress", "nthamishetty@chraterglobal.com");

                //Enter Email Bcc Address
                addcontacHelper.TypeText("EnterEmailBccAddress", "nthamishetty@chraterglobal.com");

                //Enter Email Subject
                addcontacHelper.TypeText("EnterEmailSubject", "Test Email");

                //Click On Priority
                addcontacHelper.ClickElement("ClickOnPriority");

                //Click On Copy To CC Check Box
                addcontacHelper.ClickElement("ClickOnCopyToCCCheckBox");

                //Select Copy To CC
                addcontacHelper.Select("SelectCopyToCC", "owners");

                //Click On Copy To BCC Check Box
                addcontacHelper.ClickElement("ClickOnCopyToBCCCheckBox");

                //Select Copy To BCC
                addcontacHelper.Select("SelectCopyToBCC", "Managers");

                //Select Email Signature
                addcontacHelper.Select("SelectEmailSignature", "");

                //Click On Send Button
                addcontacHelper.ClickElement("ClickOnSendButton");
                addcontacHelper.WaitForWorkAround(10000);

                 //######################## Delete Contact ############################

                //Click On Account Tab
                addcontacHelper.ClickElement("ClickonContactsTab");
                addcontacHelper.WaitForWorkAround(4000);

                addcontacHelper.TypeText("SearchCompany", "Woods");
                addcontacHelper.WaitForWorkAround(10000);

                //Click on Bulk Update
                addcontacHelper.ClickElement("ClickOnMasterCheckBox");

                //Click on Move over
                addcontacHelper.MouseOver("Locator");


                //Click on Bulk Delete
                addcontacHelper.ClickElement("ClickOnDeleteAccounts");
                addcontacHelper.WaitForWorkAround(4000);


                addcontacHelper.AcceptAlert();
                addcontacHelper.WaitForWorkAround(10000);

        //$$$$$$$$$$$$$$$$$$$$$$ Add to Group $$$$$$$$$$$$$$$$$$$$$$$$$$$$$

                addcontacHelper.TypeText("SearchCompany", "Woods");
                addcontacHelper.WaitForWorkAround(10000);

                //Click on Bulk Update
                addcontacHelper.ClickElement("ClickOnMasterCheckBox");

                //Click on Move over
                addcontacHelper.MouseOver("Locator");


                //Click on Bulk Update
                addcontacHelper.ClickElement("ClickOnAddToGroup");
                addcontacHelper.WaitForWorkAround(4000);

                //Enter Add New Lead Group Name
                addcontacHelper.TypeText("EnterGroupName", "Test Group");

                //Click On Add Leads
                addcontacHelper.ClickElement("ClickOnAddGroupUpdate");

                addcontacHelper.AcceptAlert();
                addcontacHelper.WaitForWorkAround(10000);

  //######################### Add To Campaign ########################
                //Search Company Name
                addcontacHelper.TypeText("SearchContactCompany", "ContactCompany");
                addcontacHelper.WaitForWorkAround(10000);

                //Click on Bulk Update
                addcontacHelper.ClickElement("ClickOnMasterCheckBox");

                //Click on Move over
                addcontacHelper.MouseOver("Locator");


                //Click on Bulk Update
                addcontacHelper.ClickElement("ClickOnAddToCampaign");
                addcontacHelper.WaitForWorkAround(4000);

                //Click on Merge Button
                addcontacHelper.ClickElement("ClickOnMergeButton");

                //Click On Campaign Name
                addcontacHelper.ClickElement("ClickOnCampaignName");

                //Select Campaign Group
                //addcontacHelper.Select("SelectCampaignGroup", "10");

                //Enter Add New Campaign Group Name
                addcontacHelper.TypeText("EnterCampaignGroupName", "Test Group");

                //Click On Add Leads
                addcontacHelper.ClickElement("ClickOnAddContacts");

                addcontacHelper.AcceptAlert();
                addcontacHelper.WaitForWorkAround(10000);


            }
        }
    }
}
