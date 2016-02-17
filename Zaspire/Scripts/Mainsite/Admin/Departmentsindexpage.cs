using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin
{
    [TestClass]
    public class DepartmentsIndexPage : DriverTestCase
    {
        [TestMethod]
        public void departmentsindexpage()
        {
            string[] username = null;
            string[] password = null;

            XMLParse oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            LoginHelper loginHelper = new LoginHelper(GetWebDriver());
            //ClientsHelper clientHelper = new ClientsHelper(GetWebDriver());
            //AddContactHelper AddAccountHelper = new AddContactHelper(GetWebDriver());
            DepartmentsViewHelper DepartmentsViewHelper = new DepartmentsViewHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);


            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            DepartmentsViewHelper.WaitForWorkAround(4000);

            //Click On Client Tab
            //DepartmentsViewHelper.ClickElement("ClickContactsTab");
            //DepartmentsViewHelper.WaitForWorkAround(4000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin");
            DepartmentsViewHelper.WaitForWorkAround(7000);

            //*************   Admin Team Record View Page Functionalities     ******************
            //Edit Button Functions
            // TeamViewHelper.ClickElement("TeamTab");
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin/departments");
            DepartmentsViewHelper.WaitForWorkAround(7000);

            //Team Add New Button Function
            // DepartmentsViewHelper.ClickElement("DepartmentsAddNew");
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin/departments/create");
            DepartmentsViewHelper.ClickElement("DepartmentsAddNewCancelButton");
            DepartmentsViewHelper.WaitForWorkAround(7000);

            //Filter Field Functions
            DepartmentsViewHelper.TypeText("DepartmentsFilterField", "Dep");
            DepartmentsViewHelper.WaitForWorkAround(7000);
            DepartmentsViewHelper.ClickElement("DepartmentsFilterResetButton");
            DepartmentsViewHelper.WaitForWorkAround(7000);

            //Delete Team Functions
            /* Note: Delete Icon is working but there is no confirmation Message whether to delete
            or not so deleting every first record.*/

            /*DepartmentsViewHelper.ClickElement("DeleteDepartmentsIcon");
            DepartmentsViewHelper.ClickElement("");
            DepartmentsViewHelper.WaitForWorkAround(7000);*/

            //Update Team Functions
            DepartmentsViewHelper.ClickElement("UpdateDepartmentsIcon");
            DepartmentsViewHelper.ClickElement("UpdateDepartmentsIconCancel");
            DepartmentsViewHelper.WaitForWorkAround(7000);

            //Team Record View
            DepartmentsViewHelper.ClickElement("DepartmentsRecordView");
            //DepartmentsViewHelper.Dismiss(); Note: has  HTML improper id so using direct url for temparary
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin/departments");
            DepartmentsViewHelper.WaitForWorkAround(7000);

            //Record Per Page 
            DepartmentsViewHelper.Select("DepartmentsRecordsPerPage", "20");
            DepartmentsViewHelper.WaitForWorkAround(7000);



        }
    }
}