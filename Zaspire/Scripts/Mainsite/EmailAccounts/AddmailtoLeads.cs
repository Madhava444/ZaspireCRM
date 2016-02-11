using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class AddMailtoLead : DriverTestCase
    {
        [TestMethod]
        public void AddmailtoLead()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var EmailacccountsIndexPageActionsHelper = new EmailAcccountsIndexPageActionsHelper(GetWebDriver());
            var AddNewLeadHelper = new AddNewLeadHelper(GetWebDriver());

            //Variables
            var AccountName = "TestAccount" + RandomNumber(1, 9);
            var Signaturename = "TestSignature" + RandomNumber(1,9);
            var FirstName = "Test" + RandomNumber(1, 99);
            var LastName = "Tester" + RandomNumber(1, 99);
            var LeadCompany = "Test Company" + RandomNumber(1, 99);
            var LeadTitle = "Test Title" + RandomNumber(1, 99);
            var Email = "Test" + RandomNumber(1, 99) + "@gmail.com";
            var Number = "12345678" + RandomNumber(10, 99);

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Activities
            EmailacccountsIndexPageActionsHelper.ClickElement("ClickonActivities");
            EmailacccountsIndexPageActionsHelper.WaitForWorkAround(5000);




            //Click on Emils
            EmailacccountsIndexPageActionsHelper.ClickElement("ClickOnEmails");
            EmailacccountsIndexPageActionsHelper.WaitForWorkAround(5000);

            //Go to MailAccounts
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/mails/mailaccounts");
            EmailacccountsIndexPageActionsHelper.WaitForWorkAround(3000);
            ////Click on EmailAccounts
            //EmailacccountsIndexPageActionsHelper.ClickElement("ClickOnEmailsaccounts");
            //EmailacccountsIndexPageActionsHelper.WaitForWorkAround(5000);

           //Click on NewButton

            EmailacccountsIndexPageActionsHelper.ClickElement("ClickNewButton");
            EmailacccountsIndexPageActionsHelper.WaitForWorkAround(2000);

            //type Account name
            EmailacccountsIndexPageActionsHelper.TypeText("AccountName", AccountName);

            //Select Account type
            EmailacccountsIndexPageActionsHelper.Select("AccountType", "2");

            //type username
            EmailacccountsIndexPageActionsHelper.TypeText("UserName", "madhava.godavarthi@infozeal.com");

            //type username
            EmailacccountsIndexPageActionsHelper.TypeText("Password", "bobby8121286761");

            //Select Account type2
            EmailacccountsIndexPageActionsHelper.Select("AccountType2", "Gmail-IMAP");

            //type protocal
           // EmailacccountsIndexPageActionsHelper.TypeText("Protocol", "IMAP");


            //type Mailserveraddress
            //EmailacccountsIndexPageActionsHelper.TypeText("MailServerAddress", "imap.gmail.com");

            //Select SSL/TSL
            EmailacccountsIndexPageActionsHelper.Select("SSLTLS", "ssl");


            //type Mailserver Port
            //EmailacccountsIndexPageActionsHelper.TypeText("MailServerPort", "993");

            //Click on TestSettings
            EmailacccountsIndexPageActionsHelper.ClickElement("TestSettings");

            //Close poup
            EmailacccountsIndexPageActionsHelper.ClickElement("Closepopup");
            EmailacccountsIndexPageActionsHelper.WaitForWorkAround(2000);

            //Click on Radio1
            EmailacccountsIndexPageActionsHelper.ClickElement("UseSamesettingsasmyIncomingServer");

            //type Outgoing SMTP Mail Server Address 
            //EmailacccountsIndexPageActionsHelper.TypeText("OutgoingSMTPMailServerAddress", "smtp.gmail.com");

            //Select Ssl
            EmailacccountsIndexPageActionsHelper.Select("SSLTLS2", "ssl");


            //type Outgoing SMTP Mail Server Port 
          //  EmailacccountsIndexPageActionsHelper.TypeText("OutgoingSMTPMailServerPort", "465");

            //Click on test settings
            EmailacccountsIndexPageActionsHelper.ClickElement("TestSettings2");

           //Click on Popup
            EmailacccountsIndexPageActionsHelper.ClickElement("Closepopup2");
            EmailacccountsIndexPageActionsHelper.WaitForWorkAround(2000);

            //Slelect Signature
            EmailacccountsIndexPageActionsHelper.Select("Selectsignature", "6");

            ////Click on Signature
            //EmailacccountsIndexPageActionsHelper.ClickElement("CreateSign");

            ////Entername
            //EmailacccountsIndexPageActionsHelper.TypeText("Signaturename" ,Signaturename);

            ////Enter Discription
            //EmailacccountsIndexPageActionsHelper.TypeText("SingDescription", "this is sample signature");

            ////Clikc on save
            //EmailacccountsIndexPageActionsHelper.ClickElement("SignSave");
            //EmailacccountsIndexPageActionsHelper.WaitForWorkAround(1000);

            //Click on Save button
            EmailacccountsIndexPageActionsHelper.ClickElement("SaveAccount");

            //Click on Filtersearch
            EmailacccountsIndexPageActionsHelper.TypeText("ClickOnFilterByEmailAccounts", "Test");
            EmailacccountsIndexPageActionsHelper.WaitForWorkAround(5000);

            //Click on resetfiltersearch
            EmailacccountsIndexPageActionsHelper.ClickElement("ResetFilter");

            //Click on MialAccount to view
            EmailacccountsIndexPageActionsHelper.ClickElement("FirstMailaccount");
            EmailacccountsIndexPageActionsHelper.WaitForWorkAround(5000); 

            //Click on Firt eamil
            EmailacccountsIndexPageActionsHelper.ClickElement("Clickonmailininbox");

            //Click on AddNewLead
            EmailacccountsIndexPageActionsHelper.ClickElement("ClickonAddtolead");
            EmailacccountsIndexPageActionsHelper.WaitForWorkAround(3000);

             //Select Status
            AddNewLeadHelper.Select("SelectStatus", "New");

            //Select Source
            AddNewLeadHelper.Select("SelectSource", "Web Site");

            //Select Category
            AddNewLeadHelper.Select("SelectCategory", "12507");

            //Select Owner  
            AddNewLeadHelper.Select("SelectOwner", "28");

            //Select Manager
            AddNewLeadHelper.Select("SelectManager", "28");

            //Select Partner
            AddNewLeadHelper.Select("SelectPartner", "");


//####################### LEAD DETAILS  #############################

            //Select Salutation
            AddNewLeadHelper.Select("SelectSalutation", "Mr");

            //Enter First Name
            //AddNewLeadHelper.TypeText("EnterFirstName", FirstName);

            //Enter Middle Name
            AddNewLeadHelper.TypeText("EnterMiddleName", "Mark");

            //Enter Last Name
            AddNewLeadHelper.TypeText("EnterLastName", LastName);

            //Enter Company Name
            //AddNewLeadHelper.TypeText("EnterCompany", LeadCompany);

            //Enter Lead Title Name
            AddNewLeadHelper.TypeText("EnterLeadTitle", LeadTitle);

            //Enter Department Name
            AddNewLeadHelper.TypeText("EnterDepartment", "HR");

            //Enter Website
            AddNewLeadHelper.TypeText("EnterWebsite", "abc.com");

            //Enter No Of Employees
            AddNewLeadHelper.TypeText("EnterNoOfEmployees", "78");

            //Select Industry
            AddNewLeadHelper.Select("SelectIndustry", "Advertising");

            //Enter Annual Revenue
            AddNewLeadHelper.TypeText("EnterAnnualRevenue", "784512");



//############################# LEAD ADDRESS   #################################


            //Select Address Type
            AddNewLeadHelper.Select("SelectAddressType", "Corporate");

            //Enter Address Line1
            AddNewLeadHelper.TypeText("EnterAddressLine1", "Test Addressline1");

            //Enter Address Line2
            AddNewLeadHelper.TypeText("EnterAddressLine2", "Test Addressline2");

            //Enter City
            AddNewLeadHelper.TypeText("EnterCity", "Test City");

            //Select State
            AddNewLeadHelper.Select("SelectState", "DC");

            //Select County
            AddNewLeadHelper.Select("SelectCountry", "USA");
            //AddNewLeadHelper.WaitForWorkAround(3000);

            //Enter Zip Code
            AddNewLeadHelper.TypeText("EnterZipCode", "87452");


//##################   CONTACT INFORMATION  #############################


            //Select Contact Salutation
            AddNewLeadHelper.Select("SelectContactSalutation", "Mr");

            //Enter Contact First Name
            AddNewLeadHelper.TypeText("EnterContactFirstName", FirstName);

            //Enter Contact Middle Name
            AddNewLeadHelper.TypeText("EnterContactMiddleName", "");

            //Enter Contact Last Name
            AddNewLeadHelper.TypeText("EnterContactLastName", LastName);

            //Select Contact Phone Type
            AddNewLeadHelper.Select("SelectContactPhoneType", "Cell");

            //Enter Contact Phone Number
            AddNewLeadHelper.TypeText("EnterContactPhoneNumber", Number);

            //Select Contact Email Type
            AddNewLeadHelper.Select("SelectContactEmailType", "Work");
            //AddNewLeadHelper.WaitForWorkAround(3000);

            //Enter Contact Email
            //AddNewLeadHelper.TypeText("EnterContactEmail", Email);

            // Select Contact Social Link Type
            AddNewLeadHelper.Select("SelectContactSocialLinkType", "Facebook");

            //Enter Contact Social Link
            AddNewLeadHelper.TypeText("EnterContactSocialLink", "test@facebook.com");



//###################### CONTACT INFORMATION ADDRESS  ######################################


            //Click on Add Address
            AddNewLeadHelper.ClickElement("ClickOnAddAddress");

            //Select Contact Address Type
            AddNewLeadHelper.Select("SelectContactAddressType", "Location");

            //Enter Contact Address Line1
            AddNewLeadHelper.TypeText("EnterContactAddressLine1", "Test Contact Addressline1");

            //Enter Contact Address Line2
            AddNewLeadHelper.TypeText("EnterContactAddressLine2", "Test Contact Addressline2");

            //Enter Contact City
            AddNewLeadHelper.TypeText("EnterContactCity", "Test Contact City");

            //Select Contact State
            AddNewLeadHelper.Select("SelectContactState", "GA");

            //Select Contact Country
            AddNewLeadHelper.Select("SelectContactCountry", "USA");
            //AddNewLeadHelper.WaitForWorkAround(3000);

            //Enter Contact Zip Code
            AddNewLeadHelper.TypeText("EnterContactZipCode", "25417");


//######################  SAVE LEAD  ###########################

            //Click on Save
            AddNewLeadHelper.ClickElement("ClickOnSave");
            AddNewLeadHelper.WaitForWorkAround(10000);

           


        }
    }
}

       

           

           



































































