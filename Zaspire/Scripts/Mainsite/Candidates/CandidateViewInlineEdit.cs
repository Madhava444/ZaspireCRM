using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class CandidateViewInlineEdit : DriverTestCase
    {
        [TestMethod]
        public void Candidateviewinlineedit()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var CandidateViewPageHelper = new CanidateViewPageHelper(GetWebDriver());

                                 

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            CandidateViewPageHelper.ClickElement("ClickOnLeads");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //CandidateViewPageHelper.WaitForWorkAround(7000);


            //Open Lead
            CandidateViewPageHelper.ClickElement("FirstLeadNameLink");




//################### INLINE EDIT CHANGE STATUS #########################


            //Click on Change Status
            CandidateViewPageHelper.ClickElement("ChangeStatus");


//################### INLINE EDIT CHANGE OWNER  #########################


            //Click on Owner
            CandidateViewPageHelper.ClickElement("ClickOnOwner");

            //Select Owner
            CandidateViewPageHelper.Select("SelectOwner", "57");

            //Click On Ok button
            CandidateViewPageHelper.ClickElement("ClickOnOwnerOk");


//################### INLINE EDIT CHANGE MANAGER  #########################


            //Click on Manager
            CandidateViewPageHelper.ClickElement("ClickOnManager");

            //Select Manager
            CandidateViewPageHelper.Select("SelectManager", "57");

            //Click On Ok button
            CandidateViewPageHelper.ClickElement("ClickOnManagerOk");


//################### INLINE EDIT CHANGE SOURCE  #########################


            //Click on Source
            CandidateViewPageHelper.ClickElement("ClickOnSource");

            //Select Source
            CandidateViewPageHelper.Select("SelectSource", "Cold Call/598787");

            //Click On Ok button
            CandidateViewPageHelper.ClickElement("ClickOnSourceOk");


//################### INLINE EDIT CHANGE CATEGORY  #########################


            //Click on Category
            CandidateViewPageHelper.ClickElement("ClickOnCategory");

            //Select Category
            CandidateViewPageHelper.Select("SelectCategory", "9248/76bf1a");

            //Click On Ok button
            CandidateViewPageHelper.ClickElement("ClickOnCategoryOk");


//################### INLINE EDIT CHANGE PARTNER  #########################


            //Click on Partner
            CandidateViewPageHelper.ClickElement("ClickOnPartner");

            //Select Partner
            CandidateViewPageHelper.Select("SelectPartner", "");

            //Click On Ok button
            CandidateViewPageHelper.ClickElement("ClickOnPartnerOk");

            
        }
    }
}
