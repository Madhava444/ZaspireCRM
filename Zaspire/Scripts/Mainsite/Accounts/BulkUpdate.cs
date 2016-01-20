using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    class Bulkupdate_Status
    {
        [TestClass]
        public class BulkUpdateStatus : DriverTestCase
        {
            [TestMethod]
            public void bulkUpdateStatus()
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
                BulkUpdateHelper BulkUpdateHelper = new BulkUpdateHelper(GetWebDriver());

                //Login with valid username and password
                Login(username[0], password[0]);
                Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

                //Verify Page title
                VerifyTitle("Dashboard");
                Console.WriteLine("Redirected at Dashboard screen.");
                BulkUpdateHelper.WaitForWorkAround(4000);

                //Click On Account Tab
                BulkUpdateHelper.ClickElement("ClickonAccountsTab");
                BulkUpdateHelper.WaitForWorkAround(4000);

                //Enter Account in search field
                BulkUpdateHelper.TypeText("SearchStatus", "New");
                BulkUpdateHelper.WaitForWorkAround(10000);

                //Click on Account
                BulkUpdateHelper.ClickElement("SelectMasterCheckbox");

                //Click on Delete
                //BulkUpdateHelper.ClickElement("SelectClient2");

                //Click on Bulk Update Button
                BulkUpdateHelper.MouseOver("Locator");
                

                BulkUpdateHelper.ClickElement("ClickonBulkUpdate");

                //Select Manager
                BulkUpdateHelper.Select("ClickOnManager", "51");
                BulkUpdateHelper.WaitForWorkAround(4000);

                BulkUpdateHelper.Select("ClickOnPartner", "6");
                BulkUpdateHelper.WaitForWorkAround(4000);

                BulkUpdateHelper.Select("ClickOnSource", "Campaign");
                BulkUpdateHelper.WaitForWorkAround(4000);

                BulkUpdateHelper.Select("ClickOnOwner", "51");
                BulkUpdateHelper.WaitForWorkAround(4000);

                BulkUpdateHelper.Select("ClickOnCategory", "20545");
                BulkUpdateHelper.WaitForWorkAround(4000);

                BulkUpdateHelper.Select("ClickOnStatus", "New");
                BulkUpdateHelper.WaitForWorkAround(4000);

                //Click on Upadte Button
                BulkUpdateHelper.ClickElement("ClickOnUpadte");
                BulkUpdateHelper.WaitForWorkAround(4000);

                //Accept Alert
                BulkUpdateHelper.AcceptAlert();
                BulkUpdateHelper.WaitForWorkAround(8000);


    //&&&&&&&&&&&&&&&&&&&&&&&&&&& Bulk Email &&&&&&&&&&&&&&&&&&&&&&&&&&&&

                //Click on Bulk Update
                BulkUpdateHelper.TypeText("SearchCompany", "Woods");
                BulkUpdateHelper.WaitForWorkAround(10000);

                //Click on Bulk Update
                BulkUpdateHelper.ClickElement("SelectMasterCheckbox");

                //Click on Move over
                BulkUpdateHelper.MouseOver("Locator");


                //Click on Bulk Email
                BulkUpdateHelper.ClickElement("ClickOnBulkEmail");
                BulkUpdateHelper.WaitForWorkAround(4000);

                //Enter Email Cc Address
                BulkUpdateHelper.TypeText("EnterEmailCcAddress", "nthamishetty@chraterglobal.com");

                //Enter Email Bcc Address
                BulkUpdateHelper.TypeText("EnterEmailBccAddress", "nthamishetty@chraterglobal.com");

                //Enter Email Subject
                BulkUpdateHelper.TypeText("EnterEmailSubject", "Test Email");

                //Click On Priority
                BulkUpdateHelper.ClickElement("ClickOnPriority");

                //Click On Copy To CC Check Box
                BulkUpdateHelper.ClickElement("ClickOnCopyToCCCheckBox");

                //Select Copy To CC
                BulkUpdateHelper.Select("SelectCopyToCC", "owners");

                //Click On Copy To BCC Check Box
                BulkUpdateHelper.ClickElement("ClickOnCopyToBCCCheckBox");

                //Select Copy To BCC
                BulkUpdateHelper.Select("SelectCopyToBCC", "Managers");

                //Select Email Signature
                BulkUpdateHelper.Select("SelectEmailSignature", "");

                //Click On Send Button
                BulkUpdateHelper.ClickElement("ClickOnSendButton");
                BulkUpdateHelper.WaitForWorkAround(10000);

                 //######################## Delete Account ############################

                //Click On Account Tab
                BulkUpdateHelper.ClickElement("ClickonAccountsTab");
                BulkUpdateHelper.WaitForWorkAround(4000);

                BulkUpdateHelper.TypeText("SearchCompany", "Woods");
                BulkUpdateHelper.WaitForWorkAround(10000);

                //Click on Bulk Update
                BulkUpdateHelper.ClickElement("ClickOnMasterCheckBox");

                //Click on Move over
                BulkUpdateHelper.MouseOver("Locator");


                //Click on Bulk Delete
                BulkUpdateHelper.ClickElement("ClickOnDeleteAccounts");
                BulkUpdateHelper.WaitForWorkAround(4000);


                BulkUpdateHelper.AcceptAlert();
                BulkUpdateHelper.WaitForWorkAround(10000);

        //$$$$$$$$$$$$$$$$$$$$$$ Add to Group $$$$$$$$$$$$$$$$$$$$$$$$$$$$$

                BulkUpdateHelper.TypeText("SearchCompany", "Woods");
                BulkUpdateHelper.WaitForWorkAround(10000);

                //Click on Bulk Update
                BulkUpdateHelper.ClickElement("ClickOnMasterCheckBox");

                //Click on Move over
                BulkUpdateHelper.MouseOver("Locator");


                //Click on Bulk Update
                BulkUpdateHelper.ClickElement("ClickOnAddToGroup");
                BulkUpdateHelper.WaitForWorkAround(4000);

                //Enter Add New Lead Group Name
                BulkUpdateHelper.TypeText("EnterGroupName", "Test Group");

                //Click On Add Leads
                BulkUpdateHelper.ClickElement("ClickOnAddGroupUpdate");

                BulkUpdateHelper.AcceptAlert();
                BulkUpdateHelper.WaitForWorkAround(10000);


          

            }
        }
    }
}
