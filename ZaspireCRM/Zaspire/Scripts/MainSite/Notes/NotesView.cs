using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class NotesView : DriverTestCase
    {
        [TestMethod]
        public void notesview()
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


            //Click on First Record
            NotesIndexHelper.ClickElement("ClickOnFirstRecord");

            //Click on Back
            NotesIndexHelper.ClickElement("ClickOnViewBack");

            //Click on First Record
            NotesIndexHelper.ClickElement("ClickOnFirstRecord");

            //Click on Edit Button
            NotesIndexHelper.ClickElement("ClickOnViewEdit");

            //Click on Edit Page to Index Page
            NotesIndexHelper.ClickElement("ClickOnEditBack");

            //Click on First Record
            NotesIndexHelper.ClickElement("ClickOnFirstRecord");

            //Click on New Button
            NotesIndexHelper.ClickElement("ClickOnViewNew");

            //Click on Add New page cancel button
            NotesIndexHelper.ClickElement("ClickOnAddNewCancel");

            //Click on First Record
            NotesIndexHelper.ClickElement("ClickOnFirstRecord");
            NotesIndexHelper.WaitForWorkAround(10000);

            //MouseOver2
            NotesIndexHelper.MouseOver2("locator2");

            //Click on Delete
            NotesIndexHelper.ClickElement("ClickOnViewDelete");

            NotesIndexHelper.AcceptAlert();
            NotesIndexHelper.WaitForWorkAround(10000);


//#########################  FORWORD NOTE  ##############################


            //Click on First Record
            NotesIndexHelper.ClickElement("ClickOnFirstRecord");
            NotesIndexHelper.WaitForWorkAround(10000);

            //MouseOver2
            NotesIndexHelper.MouseOver2("locator2");

            //Click on Forward
            NotesIndexHelper.ClickElement("ClickOnViewForward");

            //Click On Employees Link
            NotesIndexHelper.ClickElement("ClickOnEmployeesLink");

            //Click On To Address Check Box
            NotesIndexHelper.ClickElement("ToAddressCheckBox");

            //Click On CC Address Check Box
            NotesIndexHelper.ClickElement("CCAddressCheckBox");

            //Click On BCC Address Check Box
            NotesIndexHelper.ClickElement("BCCAddressCheckBox");

            //Click On Add Email Address Button
            NotesIndexHelper.ClickElement("ClickOnAddEmailAddress");

            //Click on Send Email Button
            NotesIndexHelper.ClickElement("ClickOnSendEmailButton");
            NotesIndexHelper.WaitForWorkAround(10000);



            //Click on Notes
            NotesIndexHelper.ClickElement("ClickOnNotes");

            //Click on First Record
            NotesIndexHelper.ClickElement("ClickOnFirstRecord");


//#########################  ADD FILE  ###############################


            //Click on Add File
            NotesIndexHelper.ClickElement("ClickOnAddFile");

            //Enter File Name
            NotesIndexHelper.TypeText("EnterFileName", "Test File");

            //Select File Category
            NotesIndexHelper.Select("SelectFileCategory", "");

            //Click On Attachment File
            NotesIndexHelper.ClickElement("ClickOnAttachmentFile");

            //Enter Description
            NotesIndexHelper.ClickElement("EnterDescription");


            //Click On Add File Save
            NotesIndexHelper.ClickElement("ClickOnAddFileSave");



            //Click On Attachment Icon
            NotesIndexHelper.ClickElement("ClickOnAttachmentIcon");

            //Click On Delete Icon
            NotesIndexHelper.ClickElement("ClickOnDeleteIcon");

            NotesIndexHelper.AcceptAlert();
            NotesIndexHelper.WaitForWorkAround(10000);


//#########################  INLINE EDIT OWNER ####################################


            //Click On Owner
            NotesIndexHelper.ClickElement("ClickOnOwner");

            //Select Inline Edit Owner
            NotesIndexHelper.ClickElement("SelectInlineEditOwner");

            //Click On Owner Ok Button
            NotesIndexHelper.ClickElement("ClickOnOwnerOk");


//#########################  INLINE EDIT OWNER ####################################


            //Click On Owner
            NotesIndexHelper.ClickElement("ClickOnCategory");

            //Select Inline Edit Category
            NotesIndexHelper.ClickElement("SelectInlineEditCategory");

            //Click On Category Ok Button
            NotesIndexHelper.ClickElement("ClickOnCategoryOk");



            //Click On More Activity
            NotesIndexHelper.ClickElement("ClickOnMoreActivity");
            NotesIndexHelper.WaitForWorkAround(10000);






             
        }
    }
}