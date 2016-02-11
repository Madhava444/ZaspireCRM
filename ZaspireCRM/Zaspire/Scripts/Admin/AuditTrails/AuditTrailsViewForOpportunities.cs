using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin.AuditTrails
{
    [TestClass]
    public class AuditTrailsViewForOpportunities : DriverTestCase
    {
        [TestMethod]
        public void audittrailsviewforopportunities()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AuditTrailsIndexHelper = new AuditTrailsIndexHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");


            //MouseOver
            AuditTrailsIndexHelper.MouseOver("locator");

            //Click on Admin
            AuditTrailsIndexHelper.ClickElement("ClickOnAdmin");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);

            //Click on Audit Trails
            AuditTrailsIndexHelper.ClickElement("ClickOnAuditTrails");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);

            //Enter Filter Box
            AuditTrailsIndexHelper.TypeText("EnterFilterBox", "Opportunities");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);

            //Click On Opportunities
            AuditTrailsIndexHelper.ClickElement("ClickOnOpportunities");


//#######################  OPPORTUNITIES DETAILS  #####################

            
            //Click On Contact Address Details Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppConAddDetails");

            //Click On Address Details Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppDetails");

            //Click On Emails Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppEmail");
                        
            //Click On Phone Details Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppPhoneDetails");

            //Click On SocialLink Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppSocialLink");

            //Click On About Opportunity Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppAboutOpp");

            //Click On Account Name Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppAccountName");

            //Click On Amount Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppAmount");

            //Click On Annual Revenue Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppAnnualRevenue");

            //Click On Bill Date Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppBillDate");

            //Click On Caluculated Gross Amount Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppCalGrossAmt");

            //Click On Closing Date Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppClosingDate");

            //Click On Company Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppCompany");

            //Click On Industry Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppIndustry");
            
            //Click On Opportunity Name Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppName");

            //Click On Next Step Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppNextStep");

            //Click On No Of Employees Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppNoOfEmp");

            //Click On Opportunity Group Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppOppGroup");

            //Click On Pay Rate Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppPayRate");

            //Click On Probability Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppProbability");

            //Click On Skill Type Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppSkillType");

            //Click On Specific Skill Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppSpecificSkill");
            
            //Click On Start Date Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppStartDate");

            //Click On Unweighted Pipe Line Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppUnweightedPipeline");

            //Click On Weighted Pipe Line Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppWeightedPipeline");


//#######################  OPPORTUNITIES INTERNAL FIELDS  #####################
            
            //Click On Category Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppCategory");
            
            //Click On Manager Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppManager");

            //Click On Owner Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppOwner");

            //Click On Source Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppSource");

            //Click On Status Check Box
            AuditTrailsIndexHelper.ClickElement("ClickOnOppStatus");


            //Click On Opportunities Save
            AuditTrailsIndexHelper.ClickElement("ClickOnOppSave");
            AuditTrailsIndexHelper.WaitForWorkAround(10000);

        }
    }
}