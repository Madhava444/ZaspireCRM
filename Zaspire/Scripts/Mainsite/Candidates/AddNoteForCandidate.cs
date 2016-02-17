using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddNoteForCandidates : DriverTestCase
    {
        [TestMethod]
        public void addnoteforcandidates()
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

            var NoteSubject = "Test Note" + RandomNumber(1, 99);
                      

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            AddEventsForcandidateHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //AddEventsForLeadHelper.WaitForWorkAround(7000);


            //Open Lead
            AddEventsForcandidateHelper.ClickElement("FirstLeadNameLink");

            //Click on Move over
            AddEventsForcandidateHelper.ClickElement("MoveHover");
            AddEventsForcandidateHelper.WaitForWorkAround(5000);


//################### ADD NOTE  #########################


            //Click on Add Note
            AddEventsForcandidateHelper.ClickElement("ClickOnAddNote");

            //Enter Note Subject
            AddEventsForcandidateHelper.TypeText("EnterNoteSubject", NoteSubject);

            //Enter Note Description
            AddEventsForcandidateHelper.TypeText("EnterNoteDescription", "This is Note Description");
            
            //Upload File 
            String Filename = GetPath() + "C:\\Users\\Public\\Pictures\\Sample Pictures\\image\\Tulips.jpeg";
            AddEventsForcandidateHelper.Upload("SelectNoteFile", Filename);
            AddEventsForcandidateHelper.WaitForWorkAround(10000);
            

            //Click On Save
            AddEventsForcandidateHelper.ClickElement("ClickOnSaveNote");
            AddEventsForcandidateHelper.WaitForWorkAround(7000);


            
        }
    }
}
