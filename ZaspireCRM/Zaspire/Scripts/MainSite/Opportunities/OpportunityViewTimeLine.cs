using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class OpportunityViewTimeLine : DriverTestCase
    {
        [TestMethod]
        public void opportunityviewtimeline()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var OpportunityViewPageHelper = new OpportunityViewPageHelper(GetWebDriver());

            
            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Opportunities
            OpportunityViewPageHelper.ClickElement("ClickOnOpportunities");

            //Open Opportunity
            OpportunityViewPageHelper.ClickElement("FirstOpportunityNameLink");


//################### INLINE EDIT CHANGE STATUS #########################


            //Click on Change Status
            OpportunityViewPageHelper.ClickElement("ChangeStatus");


//################### INLINE EDIT CHANGE OWNER  #########################


            //Click on Owner
            OpportunityViewPageHelper.ClickElement("ClickOnOwner");

            //Select Owner
            OpportunityViewPageHelper.Select("SelectOwner", "57");

            //Click On Ok button
            OpportunityViewPageHelper.ClickElement("ClickOnOwnerOk");


//################### INLINE EDIT CHANGE MANAGER  #########################


            //Click on Manager
            OpportunityViewPageHelper.ClickElement("ClickOnManager");

            //Select Manager
            OpportunityViewPageHelper.Select("SelectManager", "57");

            //Click On Ok button
            OpportunityViewPageHelper.ClickElement("ClickOnManagerOk");

//################### TIME LINE  #########################


            //Click On More Activity
            OpportunityViewPageHelper.ClickElement("ClickOnMoreActivity");
                        
            //Click On List View
            OpportunityViewPageHelper.ClickElement("ClickOnListView");

            //Enter List View Search Box
            OpportunityViewPageHelper.TypeText("EnterListViewSearchBox", "");
            OpportunityViewPageHelper.WaitForWorkAround(8000);

            //Click On Reset Button
            OpportunityViewPageHelper.ClickElement("ClickOnListViewReset");

            //Click On Graphical View
            OpportunityViewPageHelper.ClickElement("ClickOnGraphicalView");
            OpportunityViewPageHelper.WaitForWorkAround(10000);

            //Click On User Name
            OpportunityViewPageHelper.ClickElement("ClickOnUserName");
            OpportunityViewPageHelper.WaitForWorkAround(10000);


        }
    }
}