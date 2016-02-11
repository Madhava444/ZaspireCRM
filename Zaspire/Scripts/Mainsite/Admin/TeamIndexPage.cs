/*using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin
/*{
    [TestClass]
    public class TeamIndexPage : DriverTestCase
    {
        [TestMethod]
        public void teamindexpage()
        {
            string[] username = null;
            string[] password = null;

            XMLParse oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

            username = oXMLData.getData("settings/Credentials", "username1");
            password = oXMLData.getData("settings/Credentials", "password1");

            //Initializing the objects
            LoginHelper loginHelper = new LoginHelper(GetWebDriver());
            //ClientsHelper clientHelper = new ClientsHelper(GetWebDriver());
            //AddContactHelper AddAccountHelper = new AddContactHelper(GetWebDriver());
            TeamViewHelper TeamViewHelper = new TeamViewHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);


            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            TeamViewHelper.WaitForWorkAround(4000);

            //Click On Client Tab
            //TeamViewrHelper.ClickElement("ClickContactsTab");
            //TeamViewrHelper.WaitForWorkAround(4000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin");
            TeamViewHelper.WaitForWorkAround(7000);

            //*************   Admin Team Record View Page Functionalities     ******************
            //Edit Button Functions
            // TeamViewHelper.ClickElement("TeamTab");
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin/roles/team");
            TeamViewHelper.WaitForWorkAround(7000);

            //Team Add New Button Function
            TeamViewHelper.ClickElement("TeamAddNew");
            TeamViewHelper.ClickElement("TeamAddNewCancelButton");
            TeamViewHelper.WaitForWorkAround(7000);

            //Filter Field Functions
            TeamViewHelper.TypeText("TeamFilterField", "Dev");
            TeamViewHelper.WaitForWorkAround(7000);
            TeamViewHelper.ClickElement("TeamFilterResetButton");
            TeamViewHelper.WaitForWorkAround(7000);

            //Delete Team Functions
            /* Note: Delete Icon is working but there is no confirmation Message whether to delete
            or not so deleting every first record.*/

            /*TeamViewHelper.ClickElement("DeleteTeamIcon");
            TeamViewHelper.ClickElement("");
            TeamViewHelper.WaitForWorkAround(7000);

            //Update Team Functions
            TeamViewHelper.ClickElement("UpdateTeamIcon");
            TeamViewHelper.ClickElement("UpdateTeamIconCancel");
            TeamViewHelper.WaitForWorkAround(7000);

            //Team Record View
            TeamViewHelper.ClickElement("TeamRecordView");
            //TeamViewHelper.Dismiss(); Note: has  HTML improper id so using direct url for temparary
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin/roles/team");
            TeamViewHelper.WaitForWorkAround(7000);

            //Record Per Page 
            TeamViewHelper.Select("TeamRecordsPerPage", "20");
            TeamViewHelper.WaitForWorkAround(7000);



        }
    }
}*/