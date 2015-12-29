using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class CustomViewAddNew : DriverTestCase
    {
        [TestMethod]
        public void customviewadd()
        {
            string[] username = null;
            string[] password = null;

            XMLParse oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            var SaveViewas = "CustomView" + RandomNumber(20, 99);

            //Initializing the objects
            LoginHelper loginHelper = new LoginHelper(GetWebDriver());
            //ClientsHelper clientHelper = new ClientsHelper(GetWebDriver());
            AddAccountHelper AddAccountHelper = new AddAccountHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            AddAccountHelper.WaitForWorkAround(4000);

            //Click On Client Tab
            AddAccountHelper.ClickElement("ClickAccountsTab");
            AddAccountHelper.WaitForWorkAround(4000);

            AddAccountHelper.ClickElement("ClickOnCustomNew");

            AddAccountHelper.TypeText("SaveViewas", SaveViewas);
            AddAccountHelper.WaitForWorkAround(2000);

            AddAccountHelper.ClickElement("ClickOnOrder");

            AddAccountHelper.Select("Owner", "Ranjith");
            AddAccountHelper.WaitForWorkAround(3000);

            AddAccountHelper.Select("Manager", "Ranjith");

            AddAccountHelper.Select("Status", "Agreement");

            AddAccountHelper.Select("Source", "Email");

            AddAccountHelper.Select("Category", "Marketing");

            AddAccountHelper.Select("CreatedBy", "Ranjith");

            AddAccountHelper.Select("ModifiedBy", "Ranjith");

            AddAccountHelper.Select("Group", "4");

            AddAccountHelper.Select("Partner", "Partner5");
            AddAccountHelper.WaitForWorkAround(5000);

            AddAccountHelper.ClickElement("ClickSaveButton");
            AddAccountHelper.WaitForWorkAround(10000);

        }
    }
}