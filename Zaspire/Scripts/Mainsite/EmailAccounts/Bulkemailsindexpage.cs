using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class BulkEmailAccoutsIndexPageActions : DriverTestCase
    {
        [TestMethod]
        public void Bulkemailaccountindexpageactions()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var bulkemailshelper = new BulkEmailsHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");


            //Click on Activities
            bulkemailshelper.ClickElement("ClickonActivities");
            
            //Click on Emils
            bulkemailshelper.ClickElement("ClickOnEmails");
            bulkemailshelper.WaitForWorkAround(5000);

            //Goto Bulk emails
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/bulkemails");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            bulkemailshelper.WaitForWorkAround(3000);



            //Click on Bulkemail
            bulkemailshelper.ClickElement("ClickonBulkemail");
            bulkemailshelper.WaitForWorkAround(2000);

            //Backto bulkemailindex
            bulkemailshelper.ClickElement("Backtobutlkemail");
            bulkemailshelper.WaitForWorkAround(2000);

            //Click on Filter
            bulkemailshelper.TypeText("SearchBulkemail", "Test");

            //Reset Bulkemail
            //bulkemailshelper.ClickElement("ResetBulkemail");

            //ClickonMasterchekbox
            bulkemailshelper.ClickElement("ClickonMasterCheckbox");

            //Mouseover on Bulkactionis
            bulkemailshelper.MouseOver("locator");

            //Click on Delete Bulkemails
            bulkemailshelper.ClickElement("RemoveBulkemail");
            bulkemailshelper.AcceptAlert();

            GetWebDriver().Navigate().Refresh();

            //Clickon First Bulkemail
//            bulkemailshelper.ClickElement("CheckFirstBulkemail");

            //Click on Second Bulkemail
           // bulkemailshelper.ClickElement("ChecksecondBulkemail");


            //Click on Trash
            bulkemailshelper.ClickElement("ClickonTrash");

            //Back to Bulkemails
            bulkemailshelper.ClickElement("Backtobulkemailsfromtrash");


           
      
        }
    }
}
