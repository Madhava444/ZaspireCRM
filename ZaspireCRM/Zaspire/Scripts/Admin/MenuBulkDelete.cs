using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin
{
    [TestClass]
    public class MenuBulkDelete : DriverTestCase
    {
        [TestMethod]
        public void menubulkdelete()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var MenusIndexHelper = new MenusIndexHelper(GetWebDriver());

            //Variable
            var MenuName = "Test Menu" + RandomNumber(1, 99);

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");


            //MouseOver
            MenusIndexHelper.MouseOver("locator");

            //Click on Admin
            MenusIndexHelper.ClickElement("ClickOnAdmin");
            MenusIndexHelper.WaitForWorkAround(10000);

            //Click on Menu Management
            MenusIndexHelper.ClickElement("ClickOnMenus");
            MenusIndexHelper.WaitForWorkAround(10000);

            //Click on Add New
            MenusIndexHelper.ClickElement("ClickOnAddNew");

            //Enter Menu Title
            MenusIndexHelper.TypeText("EnterMenuTitle", MenuName);

            //DragAndDrop
            MenusIndexHelper.DragAndDrop("locater");
            MenusIndexHelper.WaitForWorkAround(10000);

            //DragAndDrop
            MenusIndexHelper.DragAndDrop1("locater1");
            MenusIndexHelper.WaitForWorkAround(10000);


            MenusIndexHelper.ClickElement("ClickOnSave");
            MenusIndexHelper.WaitForWorkAround(10000);


//#################  MENUS BULK DELETE  ############################


            //EnterFilterBox
            MenusIndexHelper.TypeText("EnterFilterBox", MenuName);
            MenusIndexHelper.WaitForWorkAround(10000);

            //Click On Master Check Box
            MenusIndexHelper.ClickElement("ClickOnMasterCheckBox");

            //Click On Delete
            MenusIndexHelper.ClickElement("ClickOnDelete");

            MenusIndexHelper.AcceptAlert();
            MenusIndexHelper.WaitForWorkAround(10000);

            
        }
    }
}