using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class AddEmailAccouts : DriverTestCase
    {
        [TestMethod]
        public void AddemailAccount()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username1");
            password = oXMLData.getData("settings/Credentials", "password1");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var EmailacccountsIndexPageActionsHelper = new EmailAcccountsIndexPageActionsHelper(GetWebDriver());

            //Variables
            var AccountName = "TestAccount" + RandomNumber(1, 9);
            var Signaturename = "TestSignature" + RandomNumber(1,9);

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Emils
            EmailacccountsIndexPageActionsHelper.ClickElement("ClickOnEmails");
            EmailacccountsIndexPageActionsHelper.WaitForWorkAround(5000);

            //Click on EmailAccounts
            EmailacccountsIndexPageActionsHelper.ClickElement("ClickOnEmailsaccounts");
            EmailacccountsIndexPageActionsHelper.WaitForWorkAround(5000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //EmailacccountsIndexPageActionsHelper.WaitForWorkAround(7000);


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
            EmailacccountsIndexPageActionsHelper.Select("Selectsignature", "8");

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

            //Go to index page
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/mails/mailaccounts/");
            EmailacccountsIndexPageActionsHelper.WaitForWorkAround(1000);




            //Click on Filtersearch
            EmailacccountsIndexPageActionsHelper.TypeText("ClickOnFilterByEmailAccounts", "Test");
            EmailacccountsIndexPageActionsHelper.WaitForWorkAround(5000);

            //Click on resetfiltersearch
            EmailacccountsIndexPageActionsHelper.ClickElement("ResetFilter");

            //Click on MialAccount to view
            EmailacccountsIndexPageActionsHelper.ClickElement("FirstMailaccount");
            EmailacccountsIndexPageActionsHelper.WaitForWorkAround(5000); 

           

           






















































































            //Click on resetfiltersearch
            EmailacccountsIndexPageActionsHelper.ClickElement("ClickonCancelbutton");
            EmailacccountsIndexPageActionsHelper.WaitForWorkAround(2000);


            //Click on Filtersearch
            EmailacccountsIndexPageActionsHelper.TypeText("ClickOnFilterByEmailAccounts" , "NewEmails");
            EmailacccountsIndexPageActionsHelper.WaitForWorkAround(5000);

            //Click on resetfiltersearch
            EmailacccountsIndexPageActionsHelper.ClickElement("ResetFilter");

           //Click On MasterCheckbox
            EmailacccountsIndexPageActionsHelper.ClickElement("ClickonMasterCheckbox");

            //Click On removeMailAccount
            EmailacccountsIndexPageActionsHelper.ClickElement("ClickRemoveButton");
             
            //Dismiss Alert
            EmailacccountsIndexPageActionsHelper.DismissAlert();
            EmailacccountsIndexPageActionsHelper.WaitForWorkAround(2000);

            //Click on First Mail Account
            EmailacccountsIndexPageActionsHelper.ClickElement("FirstMailaccount");

          

           
           








        }
    }
}
