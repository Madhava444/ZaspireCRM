using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class EmployeesCustomViewsIndex : DriverTestCase
    {
        [TestMethod]
        public void employeescustomviewsindex()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var EmployeesCustomViewsHelper = new EmployeesCustomViewsHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Employees
            EmployeesCustomViewsHelper.ClickElement("ClickOnEmployees");
            EmployeesCustomViewsHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/employees");
            //EmployeesCustomViewsHelper.WaitForWorkAround(7000);


            //Click On Custom Views
            EmployeesCustomViewsHelper.ClickElement("ClickOnCustomViews");

            //Click on Back Button
            EmployeesCustomViewsHelper.ClickElement("ClickOnBackButton");

            //Click On Custom Views
            EmployeesCustomViewsHelper.ClickElement("ClickOnCustomViews");

            //Enter Search Box
            EmployeesCustomViewsHelper.TypeText("EnterSearchBox", "Test");
            EmployeesCustomViewsHelper.WaitForWorkAround(10000);

            //Click on Check Master Check Box
            EmployeesCustomViewsHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Delete Button
            EmployeesCustomViewsHelper.ClickElement("ClickOnDeleteButton");

            EmployeesCustomViewsHelper.AcceptAlert();
            EmployeesCustomViewsHelper.WaitForWorkAround(10000);

            //Click On New Button
            EmployeesCustomViewsHelper.ClickElement("ClickOnNewButton");

            //Click On New Button
            EmployeesCustomViewsHelper.ClickElement("ClickOnNewBack");

            //Click on Custom Views
            EmployeesCustomViewsHelper.ClickElement("ClickOnCustomViews");

            //Enter Search Box
            EmployeesCustomViewsHelper.TypeText("EnterSearchBox", "Test");
            EmployeesCustomViewsHelper.WaitForWorkAround(10000);

            //Click on Reset
            EmployeesCustomViewsHelper.ClickElement("ClickOnReset");

            //Select Pagination
            EmployeesCustomViewsHelper.ClickElement("SelectPagination");

            //Click on Check Master Check Box
            EmployeesCustomViewsHelper.ClickElement("ClickOnMasterCheckBox");

            //Click on Uncheck Master Check Box
            EmployeesCustomViewsHelper.ClickElement("ClickOnMasterCheckBox");


            //Click on First Record
            EmployeesCustomViewsHelper.ClickElement("ClickOnFirstRecord");

            //Click on Custom Views
            EmployeesCustomViewsHelper.ClickElement("ClickOnCustomViews");


            //Click on Edit
            EmployeesCustomViewsHelper.ClickElement("ClickOnEdit");

            //Click on Edit Back
            EmployeesCustomViewsHelper.ClickElement("ClickOnEditBack");

            //Click on Custom Views
            EmployeesCustomViewsHelper.ClickElement("ClickOnCustomViews");

            //Click on Delete
            EmployeesCustomViewsHelper.ClickElement("ClickOnDelete");

            EmployeesCustomViewsHelper.AcceptAlert();
            EmployeesCustomViewsHelper.WaitForWorkAround(10000);

            //Click on Permissions
            EmployeesCustomViewsHelper.ClickElement("ClickOnPermissions");

            //Click on Permissions Check1
            EmployeesCustomViewsHelper.ClickElement("ClickOnPermissionsCheck1");

            //Click on Permissions Check2
            EmployeesCustomViewsHelper.ClickElement("ClickOnPermissionsCheck2");

            //Click on Permissions Check3
            EmployeesCustomViewsHelper.ClickElement("ClickOnPermissionsCheck3");

            //Click on Permissions Save
            EmployeesCustomViewsHelper.ClickElement("ClickOnPermissionsSave");
            EmployeesCustomViewsHelper.WaitForWorkAround(10000);


            

        }
    }
}
