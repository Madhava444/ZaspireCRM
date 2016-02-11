using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite

    {
        [TestClass]
        public class EmailTemplatesCreatePage : DriverTestCase
        {
            [TestMethod]
            public void emailtemplatecreatepage()
            {
                string[] username = null;
                string[] password = null;

                XMLParse oXMLData = new XMLParse();
                oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

                username = oXMLData.getData("settings/Credentials", "username");
                password = oXMLData.getData("settings/Credentials", "password");

                //Initializing the objects
                LoginHelper loginHelper = new LoginHelper(GetWebDriver());
                EmailTemplatesHelper EmailTemplatesHelper = new EmailTemplatesHelper(GetWebDriver());


                //Login with valid username and password
                Login(username[0], password[0]);
                Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

                //Verify Page title
                VerifyTitle("Dashboard");
                Console.WriteLine("Redirected at Dashboard screen.");
                EmailTemplatesHelper.WaitForWorkAround(4000);

                EmailTemplatesHelper.ClickElement("ClickOnActivitiestab");
                EmailTemplatesHelper.WaitForWorkAround(4000);

               GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/emailtemplates");
               EmailTemplatesHelper.WaitForWorkAround(4000);

                //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/emailtemplates/addnew");
               // EmailTemplatesHelper.WaitForWorkAround(4000);

                EmailTemplatesHelper.ClickElement("ClickOnEmailTemplateNewButton");

                EmailTemplatesHelper.Select("RelatedTO", "9");

                EmailTemplatesHelper.Select("Category", "12544");

                EmailTemplatesHelper.Select("Status", "Active");

                EmailTemplatesHelper.Select("Owner", "17");

                EmailTemplatesHelper.Select("Manager", "17");

               // EmailTemplateHelper.Select("Group", "")

                EmailTemplatesHelper.ClickElement("ClickOnAddNewGroupLink");

                EmailTemplatesHelper.TypeText("GroupName", "New1");

                EmailTemplatesHelper.ClickElement("ClickOnSavesbutton");

                EmailTemplatesHelper.TypeText("TemplateName", "LeadsTemplate");

                EmailTemplatesHelper.TypeText("EmailTemplateSubject", "Leadssubjectname");

                EmailTemplatesHelper.TypeText("MessageBody", "LeadsMessagebody");

                EmailTemplatesHelper.ClickElement("ClickOnCheckboxx");

                EmailTemplatesHelper.ClickElement("ClickOnMessageHeaderExpandbuttons");

                EmailTemplatesHelper.TypeText("MessageHeaderDescription", "Leads Header");

                EmailTemplatesHelper.ClickElement("ClickOnMessageFooterExpandbuttons");

                EmailTemplatesHelper.ClickElement("ClickOnAddUnsubscribeLinkInFooter");

                EmailTemplatesHelper.TypeText("MessageFooterDescription", "LeadsFooter");

                EmailTemplatesHelper.ClickElement("ClickOnSavebuttonss");


                


            }
        }
}
