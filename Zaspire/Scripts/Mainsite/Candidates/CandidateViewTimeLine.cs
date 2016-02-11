using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class CandidateViewTimeLine : DriverTestCase
    {
        [TestMethod]
        public void candidateviewtimeline()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var candidateViewPageHelper = new CanidateViewPageHelper(GetWebDriver());

            
            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            candidateViewPageHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //candidateViewPageHelper.WaitForWorkAround(7000);


            //Open Lead
            candidateViewPageHelper.ClickElement("FirstLeadNameLink");


//################### INLINE EDIT CHANGE STATUS #########################


            //Click on Change Status
            candidateViewPageHelper.ClickElement("ChangeStatus");


//################### INLINE EDIT CHANGE OWNER  #########################


            //Click on Owner
            candidateViewPageHelper.ClickElement("ClickOnOwner");

            //Select Owner
            candidateViewPageHelper.Select("SelectOwner", "57");

            //Click On Ok button
            candidateViewPageHelper.ClickElement("ClickOnOwnerOk");


//################### INLINE EDIT CHANGE MANAGER  #########################


            //Click on Manager
            candidateViewPageHelper.ClickElement("ClickOnManager");

            //Select Manager
            candidateViewPageHelper.Select("SelectManager", "57");

            //Click On Ok button
            candidateViewPageHelper.ClickElement("ClickOnManagerOk");

//################### TIME LINE  #########################


            //Click On More Activity
            candidateViewPageHelper.ClickElement("ClickOnMoreActivity");
                        
            //Click On List View
            candidateViewPageHelper.ClickElement("ClickOnListView");

            //Enter List View Search Box
            candidateViewPageHelper.TypeText("EnterListViewSearchBox", "");
            candidateViewPageHelper.WaitForWorkAround(8000);

            //Click On Reset Button
            candidateViewPageHelper.ClickElement("ClickOnListViewReset");

            //Click On Graphical View
            candidateViewPageHelper.ClickElement("ClickOnGraphicalView");
            candidateViewPageHelper.WaitForWorkAround(10000);

            //Click On User Name
            candidateViewPageHelper.ClickElement("ClickOnUserName");
            

        }
    }
}