using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class BulkemailDeletefromveiwpage : DriverTestCase
    {
        [TestMethod]
        public void bulkemailDeletefromveiwpage()
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

            //Click on DeleteBulkemail
            bulkemailshelper.ClickElement("DeleteFromview");

            bulkemailshelper.WaitForWorkAround(2000);
                

           


           
      
        }
    }
}
