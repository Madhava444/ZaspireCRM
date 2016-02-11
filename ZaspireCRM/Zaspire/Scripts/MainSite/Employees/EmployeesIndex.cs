using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class EmployeesIndex : DriverTestCase
    {
        [TestMethod]
        public void employeesindex()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var EmployeesIndexHelper = new EmployeesIndexHelper(GetWebDriver());
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Employees
            EmployeesIndexHelper.ClickElement("ClickOnEmployees");
            EmployeesIndexHelper.WaitForWorkAround(10000);

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/employees");
            //EmployeesIndexHelper.WaitForWorkAround(7000);
            
            
            //Click On Custom Views
            EmployeesIndexHelper.ClickElement("ClickOnCustomViews");

            //Click on Back to Employees
            EmployeesIndexHelper.ClickElement("ClickOnCustomViewBack");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/employees");

            //Click On Custom Views New
            EmployeesIndexHelper.ClickElement("ClickOnCustomViewNew");

            //Click on Back to Employees
            EmployeesIndexHelper.ClickElement("ClickOnCustomViewNewBack");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/employees");

            //Select Custom View
            EmployeesIndexHelper.Select("SelectCustomView", "");

            
            //Click on First Employee Name Link
            EmployeesIndexHelper.ClickElement("ClickOnFirstEmployeeNameLink");

            //Click on Back to Employees
            EmployeesIndexHelper.ClickElement("ClickOnEmployeeViewBack");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/employees");

            //Click on Employees New Button
            EmployeesIndexHelper.ClickElement("ClickOnNew");

            //Click on Back to Employees
            EmployeesIndexHelper.ClickElement("ClickOnNewBack");

            
            //Enter Filter Search
            EmployeesIndexHelper.TypeText("EnterFilterSearch", "New");
            EmployeesIndexHelper.WaitForWorkAround(10000);

            //Clock On Filter Reset
            EmployeesIndexHelper.ClickElement("ClockOnFilterReset");

            //Clock On Master Check Box
            EmployeesIndexHelper.ClickElement("ClockOnMasterCheckBox");

            //Clock On Master Uncheck Box
            EmployeesIndexHelper.ClickElement("ClockOnMasterCheckBox");


            //Clock On Edit Icon
            EmployeesIndexHelper.ClickElement("ClickOnEditIcon");

            //Click on Back to Employees
            EmployeesIndexHelper.ClickElement("ClickOnEditBack");


            //Clock On Delete Icon
            //EmployeesIndexHelper.ClickElement("ClickOnDeleteIcon");

            //EmployeesIndexHelper.AcceptAlert();
            //EmployeesIndexHelper.WaitForWorkAround(10000);


            //Select SelectPagination
            EmployeesIndexHelper.Select("SelectPagination", "20");

            //Click on Next
            EmployeesIndexHelper.ClickElement("ClickOnNext");

            //Click on Last
            EmployeesIndexHelper.ClickElement("ClickOnLast");

            //Click on Previous
            EmployeesIndexHelper.ClickElement("ClickOnprevious");

            //Click on First
            EmployeesIndexHelper.ClickElement("ClickOnFirst");
            
        }
    }
}