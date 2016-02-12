using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class CallView : DriverTestCase
    {
        [TestMethod]
        public void callview()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var CallHelper = new CallHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Dashboard in menu
            CallHelper.ClickElement("ClickonActivities");
            //Click on Calls
            CallHelper.ClickElement("ClickOnCalls");

            //######################### ViewEvent ######################################


            // Click on record
            CallHelper.ClickElement("Callview");

            //Clcik on activity tab
            // CallHelper.ClickElement("CallEdit");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/calls/update/28");

            //Click on Timline
            CallHelper.ClickElement("UpdateSelectsave");


            //-------------------------AddFile------------------------
            /*  //Click on view 
              CallHelper.ClickElement("Callview");

              //Click on Add file
              CallHelper.ClickElement("CallAddfile");

              //EnterFile name
              CallHelper.TypeText("CallFileName", "Event");

              //Select Category
              CallHelper.Select("CallFileCategory", "12556");

              //Click on Select file
              CallHelper.ClickElement("CallFileSelect");

              //Enter Descriptions
              CallHelper.TypeText("CallDescription","new call adding a file");

              // Click on Save
              CallHelper.ClickElement("CallFileSave");

              //-----------Inline edit--------------------------------------



              //Click on Category
              CallHelper.ClickElement("CallCategoryInlineedit");

              //Select Category from list
              CallHelper.Select("Caltegorylist", "12502");

              //Click on Save symbol
              CallHelper.ClickElement("CategorySave");

              // Click on Category
              CallHelper.ClickElement("CallOwnerInlineedit");

              //Select Category from list
              CallHelper.Select("OwnerList", "17");

              //Click on Save symbol
              CallHelper.ClickElement("OwnerSave");

              //File Download
              CallHelper.ClickElement("Downloadfile");

              //File delete
              CallHelper.ClickElement("CallFileDelete");


              // Click on record
              CallHelper.ClickElement("CallView");

              // Click on back button
              CallHelper.ClickElement("CallBack");*/



            //-------------------Delete Calls-----------------------------------

            // Click on record
            CallHelper.ClickElement("Callview");

            //Moves hover on more actions
            CallHelper.MouseOver("CallMoreactions");


            //Click on forward
            CallHelper.ClickElement("ForwardCall");

            //Clcik on Employee link
            CallHelper.ClickElement("SelectEmployeelist");

            //Click  on Add checkbox
            CallHelper.ClickElement("CheckToCheckbox");

            //Click on Cc checkbox
            CallHelper.ClickElement("CheckCCCheckbox");

            //Click on BCC Chebox
            CallHelper.ClickElement("CheckBccCheckbox");

            //Click on Add Button
            CallHelper.ClickElement("AddButton");

            //Click on Delete
            CallHelper.ClickElement("DeleteCall");










        }

    }
}