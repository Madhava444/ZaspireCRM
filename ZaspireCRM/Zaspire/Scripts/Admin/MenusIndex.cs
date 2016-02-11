using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin
{
    [TestClass]
    public class MenusIndex : DriverTestCase
    {
        [TestMethod]
        public void menusindex()
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

            //Click on Add New Back
            MenusIndexHelper.ClickElement("ClickOnAddNewBack");

            //Enter Filter Search Box
            MenusIndexHelper.TypeText("EnterFilterBox", "Test");
            MenusIndexHelper.WaitForWorkAround(10000);

            //Click on Reset
            MenusIndexHelper.ClickElement("ClickOnReset");

            //Click on Check Master Check Box
            MenusIndexHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Uncheck Master Check Box
            MenusIndexHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Edit
            MenusIndexHelper.ClickElement("ClickOnEditIcon");

            //Click on Edit Back
            MenusIndexHelper.ClickElement("ClickOnEditBack");

            //Click on View
            MenusIndexHelper.ClickElement("ClickOnViewIcon");

            //Click on View Back
            MenusIndexHelper.ClickElement("ClickOnViewBack");

            //Click on Active/Inactive
            MenusIndexHelper.ClickElement("ClickOnActiveInactive");






        }
    }
}