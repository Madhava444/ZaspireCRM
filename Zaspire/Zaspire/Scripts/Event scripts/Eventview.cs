using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class EventView : DriverTestCase
    {
        [TestMethod]
        public void Eventview()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var EventHelper = new EventHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Dashboard in menu
            EventHelper.ClickElement("Selectevents");


            //######################### ViewEvent ######################################


            // Click on record
            EventHelper.ClickElement("EventView");

            //Clcik on activity tab
           // EventHelper.ClickElement("EventEdit");

            //Click on Timline
            EventHelper.ClickElement("ClickonCancel");
            
            
            //-------------------------AddFile------------------------
              
              //Click on Add file
               EventHelper.ClickElement("EventAddFile");

               //EnterFile name
               EventHelper.TypeText("EventFileName","Event");

               //Select Category
               EventHelper.Select("EventFileCategory", "12556");

               //Click on Select file
               EventHelper.ClickElement("EventFileSelect");

               //Enter Descriptions
               EventHelper.TypeText("EventDescription","new event adding a file");

               // Click on Save
               EventHelper.ClickElement("EventFileSave");

          //-----------Inline edit--------------------------------------

            //Click on status inline edit
            EventHelper.ClickElement("EventInlineeditStatus");

            //Click on Category
            EventHelper.ClickElement("EventInlineeditCategory");

            //Select Category from list
            EventHelper.Select("SelectCategory", "12502");

            //Click on Save symbol
            EventHelper.ClickElement("SelectCategorySave");

            // Click on Category
            EventHelper.ClickElement("EventInlineeditOwner");

            //Select Category from list
            EventHelper.Select("SelectOwner", "17");

            //Click on Save symbol
            EventHelper.ClickElement("SelectOwnerSave");

            //File Download
            EventHelper.ClickElement("EventFileDownload");

            //File delete
            EventHelper.ClickElement("EventFileDelete");

            // Click on back button
            EventHelper.ClickElement("EventBack");

            // Click on record
            EventHelper.ClickElement("EventView");

            //-------------------DeleteEvent-----------------------------------

            //Moves hover on more actions
            EventHelper.Mouseover("EventMoreaction");


            //Click on Delete
            EventHelper.ClickElement("EventDelete");










        }

    }
}