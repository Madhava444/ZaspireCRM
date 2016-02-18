using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class EmailViewPage : DriverTestCase
    {
        [TestMethod]
        public void emailviewpage()
        {
            string[] username = null;
            string[] password = null;

            XMLParse oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            LoginHelper loginHelper = new LoginHelper(GetWebDriver());
           // EmailHelper EmailHelper = new EmailHelper(GetWebDriver());
            EmailViewHelper EmailViewHelper = new EmailViewHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            EmailViewHelper.WaitForWorkAround(4000);

            EmailViewHelper.ClickElement("ClickOnActivitiestab");

           EmailViewHelper.ClickElement("ClickOnEmailbutton");
            EmailViewHelper.WaitForWorkAround(4000);
    
            //Inbox Page
            EmailViewHelper.TypeText("SearchFilter", "Company8");
            EmailViewHelper.WaitForWorkAround(4000);

            EmailViewHelper.ClickElement("ClickOnInboxViewpages");
            EmailViewHelper.WaitForWorkAround(4000);



            EmailViewHelper.ClickElement("ClickOnRepllyButton");

            //Reply Button
            EmailViewHelper.ClickElement("ClickOnReplyButton");

            EmailViewHelper.TypeText("EnterSubjectName", "NewSamplemail");


            EmailViewHelper.ClickElement("ClickOnSendButton");  


            //Reply All Button
            EmailViewHelper.ClickElement("ClickOnActivitiestab");
            EmailViewHelper.WaitForWorkAround(4000);

            EmailViewHelper.ClickElement("ClickOnEmailbutton");
            EmailViewHelper.WaitForWorkAround(4000);

            EmailViewHelper.TypeText("SearchFilter", "Company8");
            EmailViewHelper.WaitForWorkAround(4000);

            EmailViewHelper.ClickElement("ClickOnInboxViewpages");
            EmailViewHelper.WaitForWorkAround(4000);

            EmailViewHelper.ClickElement("ClickOnRepllyButton");

            EmailViewHelper.ClickElement("ClickOnReplyAllButton");

            EmailViewHelper.TypeText("EnterSubjectName", "NewSamplemail");

            EmailViewHelper.ClickElement("ClickOnSendButton");

            //Forward Button

            EmailViewHelper.ClickElement("ClickOnActivitiestab");
            EmailViewHelper.WaitForWorkAround(4000);

            EmailViewHelper.ClickElement("ClickOnEmailbutton");
            EmailViewHelper.WaitForWorkAround(4000);

            EmailViewHelper.TypeText("SearchFilter", "Company8");
            EmailViewHelper.WaitForWorkAround(4000);

            EmailViewHelper.ClickElement("ClickOnInboxViewpages");
            EmailViewHelper.WaitForWorkAround(4000);

            EmailViewHelper.ClickElement("ClickOnRepllyButton");

            EmailViewHelper.ClickElement("ClickOnForwardButton");

            EmailViewHelper.ClickElement("ClickOnEmployeesLink");

            EmailViewHelper.ClickElement("EnabletheCheckbox");

            EmailViewHelper.ClickElement("ClickOnAddButton");

            EmailViewHelper.TypeText("EnterSubjectName", "NewSamplemail");

            EmailViewHelper.ClickElement("ClickOnSendButton");



        }
    }
}