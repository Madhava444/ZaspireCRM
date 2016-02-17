using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class OpportunityCopyandDelete : DriverTestCase
    {
        [TestMethod]
        public void opportunitycopyanddelete()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AddEventsForOpportunityHelper = new AddEventsForOpportunityHelper(GetWebDriver());

            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Opportunities
            AddEventsForOpportunityHelper.ClickElement("ClickOnOpportunities");
            AddEventsForOpportunityHelper.WaitForWorkAround(7000);


            //Open Opportunity
            AddEventsForOpportunityHelper.ClickElement("FirstOpportunityNameLink");
            AddEventsForOpportunityHelper.WaitForWorkAround(10000);

            //Click on Move over
            AddEventsForOpportunityHelper.MouseOver("locator");
            AddEventsForOpportunityHelper.WaitForWorkAround(5000);


            
//#################### OPPORTUNITY COPY  #####################################



            //Click on Copy
            AddEventsForOpportunityHelper.ClickElement("ClickOnCopy");
            
            AddEventsForOpportunityHelper.AcceptAlert();
            AddEventsForOpportunityHelper.WaitForWorkAround(10000);


//#################### OPPORTUNITY DELETE  #####################################



            //Click on Move over
            AddEventsForOpportunityHelper.MouseOver("locator");
            AddEventsForOpportunityHelper.WaitForWorkAround(5000);
            
            //Click on Delete
            AddEventsForOpportunityHelper.ClickElement("ClickOnDelete");
            
            AddEventsForOpportunityHelper.AcceptAlert();
            AddEventsForOpportunityHelper.WaitForWorkAround(10000);

            


        }
    }
}