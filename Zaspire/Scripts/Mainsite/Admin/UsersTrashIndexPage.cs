using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin
{
    [TestClass]
    public class UsersTrashIndexPage : DriverTestCase
    {
        [TestMethod]
        public void userstrashindexpage()
        {
            string[] username = null;
            string[] password = null;

            XMLParse oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            LoginHelper loginHelper = new LoginHelper(GetWebDriver());
            //ClientsHelper clientHelper = new ClientsHelper(GetWebDriver());
            //AddContactHelper AddAccountHelper = new AddContactHelper(GetWebDriver());
            UserTrashViewPageHelper UserTrashViewPageHelper = new UserTrashViewPageHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);


            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            UserTrashViewPageHelper.WaitForWorkAround(4000);

            //Click On Client Tab
            //UserTrashViewPageHelper.ClickElement("ClickContactsTab");
            //CustomContacontactHelper.WaitForWorkAround(4000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin/users/trash");
            UserTrashViewPageHelper.WaitForWorkAround(7000);

            //*************   User Admin Trash Index Page Functionalities     ******************

            /*   Below commented fields doesnot have proper HTML id so they are not working that's why i put them as Comment  

              UserTrashViewPageHelper.ClickElement("TrashViewBulkActions");
              UserTrashViewPageHelper.ClickElement("TrashViewBack");
              UserTrashViewPageHelper.WaitForWorkAround(10000);*/
            //UserTrashViewPageHelper.ClickElement("TrashIndexRecordView");
            //UserTrashViewPageHelper.ClickElement("TrashRecordViewBack");

            UserTrashViewPageHelper.TypeText("TrashIndexFilterField", "Role");
            UserTrashViewPageHelper.WaitForWorkAround(10000);
            UserTrashViewPageHelper.ClickElement("TrashIndexFilterReset");
            UserTrashViewPageHelper.WaitForWorkAround(10000);
            UserTrashViewPageHelper.Select("TrashViewRecordForPage", "20");
            UserTrashViewPageHelper.WaitForWorkAround(10000);
            UserTrashViewPageHelper.ClickElement("TrashViewSelectAllButton");
            UserTrashViewPageHelper.WaitForWorkAround(5000);
            UserTrashViewPageHelper.ClickElement("TrashViewSelectAllButton");
            UserTrashViewPageHelper.ClickElement("TrashRestoreUserIcon");
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin/users/trash");
            UserTrashViewPageHelper.WaitForWorkAround(5000);

            //  *********** Pagination  Functions    **************

            UserTrashViewPageHelper.ClickElement("TrashViewFirstPage");
            UserTrashViewPageHelper.ClickElement("TrashViewPrevPage");
            UserTrashViewPageHelper.ClickElement("TrashIndexPaginate");
            UserTrashViewPageHelper.ClickElement("TrashViewNextPage");
            UserTrashViewPageHelper.ClickElement("TrashViewLastPage");
            UserTrashViewPageHelper.WaitForWorkAround(5000);




        }
    }
}