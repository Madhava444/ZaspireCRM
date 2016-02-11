using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin
{
    [TestClass]
    public class UserIndexPage : DriverTestCase
    {
        [TestMethod]
        public void userindexpage()
        {
            string[] username = null;
            string[] password = null;

            XMLParse oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username1");
            password = oXMLData.getData("settings/Credentials", "password1");

            //Initializing the objects
            LoginHelper loginHelper = new LoginHelper(GetWebDriver());
            var AddNewuserhelper = new AddNewUserHelper(GetWebDriver());
            
            //ClientsHelper clientHelper = new ClientsHelper(GetWebDriver());
            //AddContactHelper AddAccountHelper = new AddContactHelper(GetWebDriver());
            
            
            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);


            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            AddNewuserhelper.WaitForWorkAround(4000);

            //Click On Client Tab
            //CustomContacontactHelper.ClickElement("ClickContactsTab");
            //CustomContacontactHelper.WaitForWorkAround(4000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/admin/users");
            AddNewuserhelper.WaitForWorkAround(7000);

            //*************   User Admin Index Page Functionalities     ******************

            //Below commented fields doenot have proper HTML id so they are not working that's why i put them as Comment  
           // AddNewuserhelper.ClickElement("UserBulkActions");
            //AddNewuserhelper.ClickElement("UserIndexTrashButton");
            //AddNewuserhelper.WaitForWorkAround(10000);
           // AddNewuserhelper.ClickElement("TrashViewBackButton");
            //AddNewuserhelper.WaitForWorkAround(10000);
            AddNewuserhelper.ClickElement("UserIndexAddNew");
            AddNewuserhelper.ClickElement("UserAddNewCancelButton");
            AddNewuserhelper.TypeText("UserIndexFilterField", "sample");
            AddNewuserhelper.WaitForWorkAround(10000);
            AddNewuserhelper.ClickElement("UserIndexFilterReset");
            AddNewuserhelper.ClickElement("UpdateUserRecord");
            AddNewuserhelper.ClickElement("UpdateUserRecordCancel");
            AddNewuserhelper.ClickElement("DeleteUser");
            AddNewuserhelper.DismissAlert();
            AddNewuserhelper.ClickElement("UserIndexRecordView");
            AddNewuserhelper.WaitForWorkAround(10000);
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/admin/users");
            AddNewuserhelper.Select("RecordForPage", "20");
            AddNewuserhelper.WaitForWorkAround(10000);

            //   *******    Sorting Fields    *******
            AddNewuserhelper.ClickElement("SortingUserName");

            //  *********** Pagination  Functions    **************

            AddNewuserhelper.ClickElement("UserIndexFirstPage");
            AddNewuserhelper.ClickElement("UserIndexPrevPage");
            AddNewuserhelper.ClickElement("UserIndexPaginate");
            AddNewuserhelper.ClickElement("UserIndexNextPage");
            AddNewuserhelper.ClickElement("UserIndexLastPage");
            AddNewuserhelper.WaitForWorkAround(10000);




        }
    }
}
