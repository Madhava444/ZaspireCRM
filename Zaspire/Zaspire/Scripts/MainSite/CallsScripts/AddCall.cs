using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddNewCall : DriverTestCase
    {
        [TestMethod]
        public void addnewcall()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AddNewCallHelper = new CallHelper(GetWebDriver());

            //Variable

            var CallSubject = "Test Call" + RandomNumber(1, 99);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Activities
            AddNewCallHelper.ClickElement("ClickonActivities");

            //Click on Calls
            AddNewCallHelper.ClickElement("ClickOnCalls");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/calls");
            //AddNewCallHelper.WaitForWorkAround(7000);


            //#################### CREATE A CALL   #####################################

            //Create on Call
            //AddNewCallHelper.ClickElement("ClickOnCallsAddNew");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/calls/addnew");



            //################### CLASSIFICATIONS & OWNERSHIP  #########################

            //Select Related To
            AddNewCallHelper.Select("SelectRelatedTo", "10");

            //Click On Merge Button
            AddNewCallHelper.ClickElement("SelectMergebox");

            //Select Related To Record
            AddNewCallHelper.ClickElement("SelectrelatedToContent");


            //Select Call Category
            AddNewCallHelper.Select("SelectCallCategory", "12403");

            //Select Owner  
            AddNewCallHelper.Select("SelectCallowner", "82");



            //Enter Call Subject
            AddNewCallHelper.TypeText("EnterCallSubject", CallSubject);

            //Select Call Type
            AddNewCallHelper.Select("SelectCallType", "Inbounds");

            //Select Call From
           //AddNewCallHelper.Select("SelectCallFrom", "");

            //Select Call To
            //AddNewCallHelper.Select("SelectCallTo", "");

            // Number From
            AddNewCallHelper.TypeText("Enternumberfrom", "8745120369");

            //Enter Number From Extension
            AddNewCallHelper.TypeText("EnterExtension", "4582");

            //Enter Number To
            AddNewCallHelper.TypeText("EnterNumberto", "9856412369");

            //Enter Number To Extension
            AddNewCallHelper.TypeText("EnterExtension1", "7882");

            //Enter Call From Name
            AddNewCallHelper.TypeText("EnterCallFrom", "TestName1");

            //Enter Call To Name
            AddNewCallHelper.TypeText("EnterCallTo", "TestName2");

            //Select Employee
          AddNewCallHelper.Select("SelectEmployee", "102*Daron werison* (899) 956-3333"); 

             //Click On Starting Time
             AddNewCallHelper.ClickElement("EnterStartingtime");

            //Click On Starting Time
            AddNewCallHelper.TypeText("CallHours", "00");

            //Click On Starting Time
            AddNewCallHelper.TypeText("CallMinutes", "20");

            //Click On Starting Time
            AddNewCallHelper.TypeText("Callsinsec", "55");
           
            //Click On Save
            AddNewCallHelper.ClickElement("Selectsave");
           



        }
    }
}