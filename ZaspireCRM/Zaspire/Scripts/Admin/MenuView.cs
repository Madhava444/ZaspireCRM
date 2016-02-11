using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin
{
    [TestClass]
    public class MenuView : DriverTestCase
    {
        [TestMethod]
        public void menusview()
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

            //Click on View
            MenusIndexHelper.ClickElement("ClickOnViewIcon");

            //Click on Menu View Back
            MenusIndexHelper.ClickElement("ClickOnViewBack");

            //Click on View
            MenusIndexHelper.ClickElement("ClickOnViewIcon");

 /*           //Click On Menu View Edit
            MenusIndexHelper.ClickElement("ClickOnViewEdit");

            //Click On Menu Edit Back
            MenusIndexHelper.ClickElement("ClickOnEditBack");

            //Click on View
            MenusIndexHelper.ClickElement("ClickOnViewIcon");
*/
            //MouseOver
            MenusIndexHelper.MouseOver1("locator1");

            //Click On Menu Copy
            MenusIndexHelper.ClickElement("ClickOnViewCopy");

            MenusIndexHelper.AcceptAlert();
            MenusIndexHelper.WaitForWorkAround(10000);

            //Click On Menu Delete
            MenusIndexHelper.ClickElement("ClickOnViewDelete");

            MenusIndexHelper.AcceptAlert();
            MenusIndexHelper.WaitForWorkAround(10000);


        }
    }
}