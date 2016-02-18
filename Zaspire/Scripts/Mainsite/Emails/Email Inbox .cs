using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class EmailInbox : DriverTestCase
    {
        [TestMethod]
        public void emailinbox()
        {
            string[] username = null;
            string[] password = null;

            XMLParse oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            LoginHelper loginHelper = new LoginHelper(GetWebDriver());
            EmailHelper EmailHelper = new EmailHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            EmailHelper.WaitForWorkAround(4000);

            EmailHelper.ClickElement("ClickOnActivitiestab");

            EmailHelper.ClickElement("ClickOnEmailbutton");



            //Inbox Page
            EmailHelper.TypeText("SearchFilter", "Company8");
            EmailHelper.WaitForWorkAround(4000);

            EmailHelper.ClickElement("ClickOnInboxViewpages");
            EmailHelper.WaitForWorkAround(4000);

            EmailHelper.ClickElement("ClickOnBackButtons1");
            EmailHelper.WaitForWorkAround(4000);




            //Sent Email
            EmailHelper.ClickElement("ClickOnSentmailbox");
            EmailHelper.WaitForWorkAround(4000);

            EmailHelper.TypeText("SearchFilterss", "Hyatt");
            EmailHelper.WaitForWorkAround(4000);

            EmailHelper.ClickElement("ClickOnSentmailViewpage");
            EmailHelper.WaitForWorkAround(4000);

            EmailHelper.ClickElement("ClickOnBackButtons1");
            EmailHelper.WaitForWorkAround(4000);



       /*     //Imported Email

            EmailHelper.ClickElement("ClickOnImportedmailbox");
            EmailHelper.WaitForWorkAround(4000);

            EmailHelper.TypeText("SearchFilter", "Hyatt");
            EmailHelper.WaitForWorkAround(4000);

            EmailHelper.ClickElement("ClickOnImportedViewpage");
            EmailHelper.WaitForWorkAround(4000);

            EmailHelper.ClickElement("ClickOnBackButtons2");
            EmailHelper.WaitForWorkAround(4000);*/



            //Trash box
            EmailHelper.ClickElement("ClickOnTrashbox");
            EmailHelper.WaitForWorkAround(4000);

            /*   EmailHelper.TypeText("SearchFilter", "Hyatt");
               EmailHelper.WaitForWorkAround(4000);

               EmailHelper.ClickElement("ClickOnmastercheckboxx");
               EmailHelper.WaitForWorkAround(4000);

               EmailHelper.MouseOver013("Locator");

               EmailHelper.ClickElement("ClickOnDeletebutton");

               EmailHelper.TypeText("SearchFilter", "mark");
               EmailHelper.WaitForWorkAround(4000);

               EmailHelper.ClickElement("ClickOnmastercheckboxx");
               EmailHelper.WaitForWorkAround(4000);

               EmailHelper.MouseOver013("Locator");

               EmailHelper.ClickElement("ClickOnDeletebutton");*/

            //EmailHelper.TypeText("Searchfilter", "lmited.in");
            //EmailHelper.WaitForWorkAround(4000);

          //  EmailHelper.ClickElement("ClickOnFirsstRecord");

            EmailHelper.ClickElement("ClickonRestore");

            //EmailHelper.TypeText("Searchfilter", "Hedley");
            //EmailHelper.WaitForWorkAround(4000);

            //EmailHelper.ClickElement("ClickOnFirstsRecord");

            EmailHelper.ClickElement("ClickonDelete");                          



            //Archive Box

            EmailHelper.ClickElement("ClickOnArchivebox");

            EmailHelper.ClickElement("ClickOnFirstCheckboxe1");
            EmailHelper.WaitForWorkAround(5000);

            EmailHelper.MouseHover05("Locator");

            EmailHelper.ClickElement("ClickOnTrashOptions");

            EmailHelper.ClickElement("ClickOnFirstCheckboxss1");
            EmailHelper.WaitForWorkAround(5000);

            EmailHelper.MouseHover06("Locators");
            EmailHelper.WaitForWorkAround(3000);

            EmailHelper.ClickElement("ClickOnCreateLabell");
            EmailHelper.WaitForWorkAround(3000);

            EmailHelper.TypeText("Names", "Folder1");
            EmailHelper.WaitForWorkAround(2000);

            EmailHelper.ClickElement("ClickOnMovesOption");
            EmailHelper.WaitForWorkAround(3000);

            // Push to Existing folder

            //EmailHelper.TypeText("SearchFilter", "company8");
            EmailHelper.ClickElement("ClickOnArchivebox");

            EmailHelper.MouseHover06("Locators");
            EmailHelper.WaitForWorkAround(3000);

            EmailHelper.ClickElement("ClickOnFirstCheckboxss2");
            EmailHelper.WaitForWorkAround(5000);

            EmailHelper.MouseHover06("Locators");

            EmailHelper.ClickElement("ClickOnnewfolder");


            //Draft box

            EmailHelper.ClickElement("ClickOnDraftbox");

            EmailHelper.ClickElement("EnableFirstCheckbox");

            EmailHelper.MouseHover08("Locators");

            EmailHelper.ClickElement("ClickOnTrashesOption");

            EmailHelper.ClickElement("ClickonFirstDraftmail");
            EmailHelper.WaitForWorkAround(5000);

            EmailHelper.ClickElement("ClickOnSendbuttons");


        }
    }
}