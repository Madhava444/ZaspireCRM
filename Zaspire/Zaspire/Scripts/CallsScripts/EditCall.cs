using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class EditCall : DriverTestCase
    {
        [TestMethod]
        public void Editacall()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var CallHelper = new CallHelper(GetWebDriver());

            //Variable

            var CallSubject = "Test Call" + RandomNumber(1, 99);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Activities
            CallHelper.ClickElement("ClickonActivities");

            //Click on Calls
            CallHelper.ClickElement("ClickOnCalls");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/calls");
            //CallHelper.WaitForWorkAround(7000);


            //#################### CREATE A CALL   #####################################

            //Create on Call
            CallHelper.ClickElement("Callview");

            // GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/calls/update/47");



            //################### CLASSIFICATIONS & OWNERSHIP  #########################
            //Create on Call
            CallHelper.ClickElement("CallEdit");

            //Select Related To
            CallHelper.Select("SelectRelatedTo", "10");

            //Click On Merge Button
            CallHelper.ClickElement("SelectMergebox");

            //Select Related To Record
            CallHelper.ClickElement("SelectrelatedToContent");


            //Select Call Category
            CallHelper.Select("SelectCallCategory", "12403");

            //Select Owner  
            CallHelper.Select("SelectCallowner", "17");



            //Enter Call Subject
            CallHelper.TypeText("EnterCallSubject", CallSubject);

            //Select Call Type
           CallHelper.Select("SelectCallType", "Inbounds");

            //Select Call From
            //CallHelper.Select("SelectCallFrom", "");

            //Select Call To
            //CallHelper.Select("SelectCallTo", "");

            // Number From
            CallHelper.TypeText("Enternumberfrom", "8746620369");

            //Enter Number From Extension
            CallHelper.TypeText("EnterExtension", "1235");

            //Enter Number To
            CallHelper.TypeText("EnterNumberto", "985655s2369");

            //Enter Number To Extension
            CallHelper.TypeText("EnterExtension1", "5321");

            //Enter Call From Name
            CallHelper.TypeText("EnterCallFrom", "Call1");

            //Enter Call To Name
            CallHelper.TypeText("EnterCallTo", "Call2");

            //Select Employee
            //CallHelper.Select("SelectEmployee", "28*Kavitha Kedika* 989 898 8989");

            //Click On Starting Time
            CallHelper.ClickElement("EnterStartingtime");

            //Click On Starting Time
            CallHelper.TypeText("CallHours", "00");

            //Click On Starting Time
            CallHelper.TypeText("CallMinutes", "15");

            //Click On Starting Time
            CallHelper.TypeText("Callsinsec", "30");

            //Click On Save
            CallHelper.ClickElement("UpdateSelectsave");
           



        }
    }
}