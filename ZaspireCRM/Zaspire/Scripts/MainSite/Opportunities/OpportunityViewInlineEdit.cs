using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class OpportunityViewInlineEdit : DriverTestCase
    {
        [TestMethod]
        public void opportunityviewinlineedit()
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
            OpportunityViewPageHelper.WaitForWorkAround(7000);


            //Open Lead
            OpportunityViewPageHelper.ClickElement("FirstOpportunityNameLink");




//################### INLINE EDIT CHANGE STATUS #########################


            //Click on Change Status
            OpportunityViewPageHelper.ClickElement("ChangeStatus");


//################### INLINE EDIT CHANGE OWNER  #########################


            //Click on Owner
            OpportunityViewPageHelper.ClickElement("ClickOnOwner");

            //Select Owner
            OpportunityViewPageHelper.Select("SelectOwner", "20");

            //Click On Ok button
            OpportunityViewPageHelper.ClickElement("ClickOnOwnerOk");


//################### INLINE EDIT CHANGE MANAGER  #########################


            //Click on Manager
            OpportunityViewPageHelper.ClickElement("ClickOnManager");

            //Select Manager
            OpportunityViewPageHelper.Select("SelectManager", "20");

            //Click On Ok button
            OpportunityViewPageHelper.ClickElement("ClickOnManagerOk");


//################### INLINE EDIT CHANGE SOURCE  #########################


            //Click on Source
            OpportunityViewPageHelper.ClickElement("ClickOnSource");

            //Select Source
            OpportunityViewPageHelper.Select("SelectSource", "Web Site/1f7a4e");

            //Click On Ok button
            OpportunityViewPageHelper.ClickElement("ClickOnSourceOk");


//################### INLINE EDIT CHANGE CATEGORY  #########################


            //Click On Expand
            OpportunityViewPageHelper.ClickElement("ClickOnExpand");

            //Click on Category
            OpportunityViewPageHelper.ClickElement("ClickOnCategory");

            //Select Category
            OpportunityViewPageHelper.Select("SelectCategory", "12524/3e7a68");

            //Click On Ok button
            OpportunityViewPageHelper.ClickElement("ClickOnCategoryOk");




            
        }
    }
}
