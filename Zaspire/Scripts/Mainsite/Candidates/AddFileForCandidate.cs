using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddFileForCandidate : DriverTestCase
    {
        [TestMethod]
        public void addfileforcandidate()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AddEventsForcandidateHelper = new AddEventsForCandidateHelper(GetWebDriver());

            //Variable

            var FileName = "Test File" + RandomNumber(1, 99);
                      

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            AddEventsForcandidateHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/leads");
            //AddEventsForcandidateHelper.WaitForWorkAround(7000);


            //Open Lead
            AddEventsForcandidateHelper.ClickElement("FirstLeadNameLink");

            //Click on Move over
            AddEventsForcandidateHelper.ClickElement("MoveHover");
            AddEventsForcandidateHelper.WaitForWorkAround(10000);


//################### ADD FILE  #########################


            //Click on Add File
            AddEventsForcandidateHelper.ClickElement("ClickOnAddFile");

            //Enter Note Subject
            AddEventsForcandidateHelper.TypeText("EnterFileName", FileName);

            //Select Category
            AddEventsForcandidateHelper.TypeText("SelectCategory", "9293");
            
            //Upload File 
            String Filename = GetPath() + "C:\\Users\\Public\\Pictures\\Sample Pictures\\image\\Tulips.jpeg";
            AddEventsForcandidateHelper.Upload("SelectAttachmentFile", Filename);
            AddEventsForcandidateHelper.WaitForWorkAround(10000);

            //Enter File Description
            AddEventsForcandidateHelper.TypeText("EnterFileDescription", "This is File Description");

            //Click On Save
            AddEventsForcandidateHelper.ClickElement("ClickOnSaveFile");
            AddEventsForcandidateHelper.WaitForWorkAround(7000);


            
        }
    }
}

