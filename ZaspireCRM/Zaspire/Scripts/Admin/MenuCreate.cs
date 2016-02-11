using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin
{
    [TestClass]
    public class MenuCreate : DriverTestCase
    {
        [TestMethod]
        public void menucreate()
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
            //MenusIndexHelper.ClickElement("ClickOnMenus");
            //MenusIndexHelper.WaitForWorkAround(10000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin/menu");
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
            
            //DragAndDrop
            MenusIndexHelper.DragAndDrop3("//*[@id='nestable_list_3']/ol/li[2]/div[1]", "//*[@id='nestable_list_1']/ol/li[2]/div[1]");
            MenusIndexHelper.WaitForWorkAround(10000);


            MenusIndexHelper.ClickElement("ClickOnSave");
            MenusIndexHelper.WaitForWorkAround(10000);

        }
    }
}

