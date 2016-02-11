using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class CustomViewAddNews : DriverTestCase
    {
        [TestMethod]
        public void customviewaddnews()
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
            //AddContactHelper AddAccountHelper = new AddContactHelper(GetWebDriver());
            CustomContactHelper CustomContactHelper = new CustomContactHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            CustomContactHelper.WaitForWorkAround(4000);

            //Click On Client Tab
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            CustomContactHelper.WaitForWorkAround(7000);

            CustomContactHelper.ClickElement("ClickOnCustomNew");

            CustomContactHelper.TypeText("SaveViewas", SaveViewas);
            CustomContactHelper.WaitForWorkAround(2000);

            CustomContactHelper.ClickElement("ClickOnOrder");

            CustomContactHelper.Select("Owner", "Ranjith");
            CustomContactHelper.WaitForWorkAround(3000);


            CustomContactHelper.Select("Status", "Active");

            CustomContactHelper.Select("Source", "Email");

            CustomContactHelper.Select("Category", "Shifted");

            CustomContactHelper.Select("CreatedBy", "Ranjith");

            CustomContactHelper.Select("ModifiedBy", "Ranjith");

            CustomContactHelper.Select("Group", "7");

            //CustomContactHelper.Select("Created", "2016-01-18");
            //CustomContactHelper.WaitForWorkAround(5000);

            //CustomContactHelper.Select("Modified", "2016-01-18");
            //CustomContactHelper.WaitForWorkAround(6000);

            CustomContactHelper.ClickElement("Save");
            CustomContactHelper.WaitForWorkAround(6000);


        }
    }
}