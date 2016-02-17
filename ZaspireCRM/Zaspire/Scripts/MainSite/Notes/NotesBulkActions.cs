using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class NotesBulkActions : DriverTestCase
    {
        [TestMethod]
        public void notesbulkactions()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var NotesIndexHelper = new NotesIndexHelper(GetWebDriver());
            var AddNewNoteHelper = new AddNewNoteHelper(GetWebDriver());


            //Variable

            var NoteSubject = "Test Note" + RandomNumber(1, 99);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Activities
            NotesIndexHelper.ClickElement("ClickOnActivitiess");

            //Click on Notes
            NotesIndexHelper.ClickElement("ClickOnNotes");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/notes");
            //AddNewNoteHelper.WaitForWorkAround(7000);



//#################### CREATE A NOTE   #####################################

            
            //Create on Note
            AddNewNoteHelper.ClickElement("ClickOnNoteAddNew");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/notes/addnew");



//################### CLASSIFICATIONS & OWNERSHIP  #########################

            
            //Select Note Category
            AddNewNoteHelper.Select("SelectNoteCategory", "12186");

            //Select Owner  
            AddNewNoteHelper.Select("SelectNoteOwner", "17");

            //Select Related To
            AddNewNoteHelper.Select("SelectRelatedTo", "11");

            //Click On Merge Button
            AddNewNoteHelper.ClickElement("ClickOnMergeButton");

            //Select Related To Record
            AddNewNoteHelper.ClickElement("SelectRelatedToRecord");

            //Enter Note Subject
            AddNewNoteHelper.TypeText("EnterNoteSubject", NoteSubject);
            AddNewNoteHelper.WaitForWorkAround(4000);

            //Click On Save
            //AddNewNoteHelper.ClickElement("SelectFile");

            //Upload File
            //var filename = GetPath() + "//image//sample.jpg";
            //AddNewNoteHelper.Upload("upload", filename);

            //Click On Save
            AddNewNoteHelper.ClickElement("ClickOnSave");
            AddNewNoteHelper.WaitForWorkAround(10000);

            



//#######################  NOTES BULK UPDATE  ############################


            //Enter Search Box
            NotesIndexHelper.TypeText("EnterSearchBox", NoteSubject);
            NotesIndexHelper.WaitForWorkAround(10000);

            //Click on Check Master Check Box
            NotesIndexHelper.ClickElement("ClickOnMasterCheckBox");
            
            //Bulk Actions MouseOver1
            NotesIndexHelper.MouseOver1("locator1");

            //Click on Bulk Update
            NotesIndexHelper.ClickElement("ClickOnBulkUpdate");

            //Select Category
            NotesIndexHelper.Select("SelectCategory", "34163");

            //Select Owner
            NotesIndexHelper.Select("SelectOwner", "20");


            //Click on Update
            NotesIndexHelper.ClickElement("ClickOnUpdate");

            NotesIndexHelper.AcceptAlert();
            NotesIndexHelper.WaitForWorkAround(10000);


            
//#######################  NOTES BULK DELETE  ############################
            

            //Enter Search Box
            NotesIndexHelper.TypeText("EnterSearchBox", NoteSubject);
            NotesIndexHelper.WaitForWorkAround(10000);

            //Click on Check Master Check Box
            NotesIndexHelper.ClickElement("ClickOnMasterCheckBox");

            //Bulk Actions MouseOver1
            NotesIndexHelper.MouseOver1("locator1");

            //Click on Bulk Delete
            NotesIndexHelper.ClickElement("ClickOnBulkDelete");

            NotesIndexHelper.AcceptAlert();
            NotesIndexHelper.WaitForWorkAround(10000);


        }
    }
}