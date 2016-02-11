using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class ContactTrashIndexPage : DriverTestCase
    {
        [TestMethod]
        public void contacttrashindexpage()
        {
            string[] username = null;
            string[] password = null;

            XMLParse oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            LoginHelper loginHelper = new LoginHelper(GetWebDriver());
            TrashHelper TrashHelper = new TrashHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            TrashHelper.WaitForWorkAround(4000);



            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            TrashHelper.WaitForWorkAround(3000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/trash");
            TrashHelper.WaitForWorkAround(5000);

 /*           TrashHelper.TypeText("FilterSearchBox", "Hold");
            TrashHelper.WaitForWorkAround(2000);

            TrashHelper.ClickElement("ClickOnResetButton");

            TrashHelper.TypeText("SearchbySource", "Email");
            TrashHelper.WaitForWorkAround(2000);

            TrashHelper.ClickElement("ClickOnMasterCheckbox");

            TrashHelper.MouseHover("Locator");

            TrashHelper.ClickElement("ClickOnDeleteForever");
            TrashHelper.WaitForWorkAround(2000);

            TrashHelper.AcceptAlert();
            TrashHelper.WaitForWorkAround(5000);


            TrashHelper.TypeText("SearchbyCompany", "Borland");
            TrashHelper.WaitForWorkAround(2000);

            TrashHelper.ClickElement("ClickOnMasterCheckbox");

            TrashHelper.MouseHover("Locator");

            TrashHelper.ClickElement("ClickOnRestoreContacts");
            TrashHelper.WaitForWorkAround(3000);


            TrashHelper.AcceptAlert();
            TrashHelper.WaitForWorkAround(5000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/trash");*/
            TrashHelper.WaitForWorkAround(5000);


    //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ Quick Links $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

            TrashHelper.Mouseover("Locator");

            TrashHelper.ClickElement("ClickOnQuicklinks");

            TrashHelper.ClickElement("ClickOnDeleteForeverOption");

            TrashHelper.AcceptAlert();
            TrashHelper.WaitForWorkAround(10000);

            TrashHelper.Mouseover("Locator");

            TrashHelper.ClickElement("ClickOnQuicklinks");
           
            TrashHelper.AcceptAlert();
            TrashHelper.WaitForWorkAround(10000);

            TrashHelper.ClickElement("ClickOnRestoreOption");


            //######################### Trash View Page ##########################

            //AddAccountHelper.ClickElement("ClicOnTrashRecordViewPage");

            TrashHelper.ClickElement("ClickonFirstRecord");


   // ########################## Group Trash ##############

            //AddAccountHelper.ClickElement("ClicOnGroupTrashButton");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/trash");

            TrashHelper.Select("ClickOnPageNo.", "50");

    //******************* Export Functionalities ********************
            TrashHelper.ClickElement("ClickOnCsvExport");
            TrashHelper.WaitForWorkAround(2000);

            TrashHelper.ClickElement("ClickOnPdfExport");
            TrashHelper.WaitForWorkAround(2000);

    //%%%%%%%%%%%%%%%%%%%%%%%% Group Trash Button %%%%%%%%%%%%%%%%%

            //TrashHelper.ClickElement("ClickOnGroupTrashButton");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/groups/trash");

   // &&&&&&&&&&&&&&&&&&&&&& Back function &&&&&&&&&&&&&&&&&

            // Click on Trash option
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/trash");

            // Click on Back Option
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");


        }
    }
}