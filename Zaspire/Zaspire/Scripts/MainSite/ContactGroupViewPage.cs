using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class ContactGroupViewPage : DriverTestCase
    {
        [TestMethod]
        public void contactgroupviewpage()
        {
            string[] username = null;
            string[] password = null;

            XMLParse oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            LoginHelper loginHelper = new LoginHelper(GetWebDriver());
            GroupTrashHelper GroupTrashHelper = new GroupTrashHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            GroupTrashHelper.WaitForWorkAround(4000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            GroupTrashHelper.WaitForWorkAround(7000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/groups");
            GroupTrashHelper.WaitForWorkAround(7000);

            //*********************** Group Index Page ************************

            GroupTrashHelper.TypeText("FilerSearchBox", "new1234");

            GroupTrashHelper.ClickElement("ClickOnFirstRecord");

            // Back Button option

            GroupTrashHelper.ClickElement("ClickOnBackOption");

            // ******************* Edit Functionality *****************

            GroupTrashHelper.TypeText("FilerSearchBox", "new1234");

            GroupTrashHelper.ClickElement("ClickOnFirstRecord");


            GroupTrashHelper.ClickElement("ClickOnSavesButton");

            //********************** Add New Functionality ***************

            GroupTrashHelper.ClickElement("ClickOnGroupAddNewButton");

            GroupTrashHelper.ClickElement("ClickOnCancelOptions");


            //  ################### More Actions ##############

            GroupTrashHelper.TypeText("FilerSearchBox", "new1234");

            GroupTrashHelper.ClickElement("ClickOnFirstRecord");

            GroupTrashHelper.MouseHover05("locator");

            //Click On View
            GroupTrashHelper.ClickElement("ClickOnDeleteOptions");

            GroupTrashHelper.AcceptAlert();
            GroupTrashHelper.WaitForWorkAround(5000);

            //@@@@@@@@@@@@@@@@@@@ Add Contact @@@@@@@@@@@@@@@@@@@@@@@@@
            GroupTrashHelper.TypeText("FilerSearchBox", "new1234");

            GroupTrashHelper.ClickElement("ClickOnFirstRecord");

            GroupTrashHelper.ClickElement("ClickOnAddContactOption");

            GroupTrashHelper.ClickElement("ClickOnCancelOptions");


            //*********************** Bulk Actions *************************

            GroupTrashHelper.TypeText("FilterSearchByStatus", "Hold");

            GroupTrashHelper.ClickElement("ClickOnResetButton");

            GroupTrashHelper.TypeText("FilterSearchByStatus", "Hold");
            GroupTrashHelper.WaitForWorkAround(2000);

            GroupTrashHelper.ClickElement("ClickOnMasterCheckbox");

            GroupTrashHelper.MouseHover00("locators");

            GroupTrashHelper.ClickElement("ClickOnBulkUpdate");

            // ****** Bulk Update *********

            GroupTrashHelper.Select("Status", "Hold");

            GroupTrashHelper.Select("Source", "Email");

            GroupTrashHelper.Select("Category", "12399");

            GroupTrashHelper.Select("Owner", "17");

            GroupTrashHelper.ClickElement("ClickOnUpdateButton");

            GroupTrashHelper.AcceptAlert();
            GroupTrashHelper.WaitForWorkAround(2000);


            // ********** Bulk Email ************

            GroupTrashHelper.TypeText("FilterSearchByStatus", "Inactive");
            GroupTrashHelper.WaitForWorkAround(2000);

            GroupTrashHelper.ClickElement("ClickOnMasterCheckbox");

            GroupTrashHelper.MouseHover00("locators");

            GroupTrashHelper.ClickElement("ClickOnBulkEmail");

            //Enter Email Cc Address
            GroupTrashHelper.TypeText("EnterEmailCcAddress", "nthamishetty@chraterglobal.com");

            //Enter Email Bcc Address
            GroupTrashHelper.TypeText("EnterEmailBccAddress", "nthamishetty@chraterglobal.com");

            //Enter Email Subject
            GroupTrashHelper.TypeText("EnterEmailSubject", "Test Email");

            //Click On Priority
            GroupTrashHelper.ClickElement("ClickOnPriority");

            GroupTrashHelper.ClickElement("ClickOnContactEmailTemplate");

            GroupTrashHelper.TypeText("NameorIdSearchFilter", "johnson");

            GroupTrashHelper.ClickElement("ClickOnResetbutton");

            GroupTrashHelper.TypeText("NameorIdSearchFilter", "johnson");

            GroupTrashHelper.ClickElement("ClickOnSearchbutton");

            GroupTrashHelper.ClickElement("ClickOntheLink");

            //Click On Copy To CC Check Box
            GroupTrashHelper.ClickElement("ClickOnCopyToCCCheckBox");

            //Select Copy To CC
            GroupTrashHelper.Select("SelectCopyToCC", "owners");

            //Click On Copy To BCC Check Box
            GroupTrashHelper.ClickElement("ClickOnCopyToBCCCheckBox");

            //Select Copy To BCC
            GroupTrashHelper.Select("SelectCopyToBCC", "Managers");

            //Select Email Signature
            GroupTrashHelper.Select("SelectEmailSignature", "");

            //Click On Send Button
            GroupTrashHelper.ClickElement("ClickOnSendButton");
            GroupTrashHelper.WaitForWorkAround(10000);


            // ****************** Add To Campaign ****************

            //Search Company Name
            GroupTrashHelper.TypeText("SearchContactCompany", "ContactCompany");
            GroupTrashHelper.WaitForWorkAround(10000);

            //Click on Bulk Update
            GroupTrashHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Move over
            GroupTrashHelper.MouseOver("Locator");


            //Click on Bulk Update
            GroupTrashHelper.ClickElement("ClickOnAddToCampaign");
            GroupTrashHelper.WaitForWorkAround(4000);

            //Click on Merge Button
            GroupTrashHelper.ClickElement("ClickOnMergeButton");

            //Click On Campaign Name
            GroupTrashHelper.TypeText("CampaingNameFilterSearchbox", "Cam1");

            GroupTrashHelper.ClickElement("ClickOnResetButton");

            GroupTrashHelper.TypeText("CampaingNameFilterSearchbox", "Cam1");

            GroupTrashHelper.ClickElement("ClickOnSearchButton");

            GroupTrashHelper.ClickElement("ClickOnCampaignLink");

            GroupTrashHelper.Select("MemberStatus", "Invite");

            GroupTrashHelper.Select("MemberGroup", "new");

            //Enter Add New Campaign Group Name
            GroupTrashHelper.TypeText("EnterCampaignGroupName", "Test Group");

            //Click On Add Leads
            GroupTrashHelper.ClickElement("ClickOnAddContacts");

            GroupTrashHelper.AcceptAlert();
            GroupTrashHelper.WaitForWorkAround(10000);

            // ************** Delete From Group *************

            //Search Company Name
            GroupTrashHelper.TypeText("SearchContactName", "AldenRogers");
            GroupTrashHelper.WaitForWorkAround(10000);

            //Click on Bulk Update
            GroupTrashHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Move over
            GroupTrashHelper.MouseOver("Locator");


            //Click on Bulk Update
            GroupTrashHelper.ClickElement("ClickOnDeletefromGroup");
            GroupTrashHelper.WaitForWorkAround(4000);

            GroupTrashHelper.AcceptAlert();
            GroupTrashHelper.WaitForWorkAround(10000);



        }
    }
}