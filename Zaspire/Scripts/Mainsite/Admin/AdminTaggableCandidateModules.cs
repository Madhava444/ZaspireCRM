using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AdminTaggableCandidateModules : DriverTestCase
    {
        [TestMethod]
        public void admintaggableCandidatemodules()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AdminTaggableLeadModulesHelpher = new AdminTaggableLeadModulesHelper(GetWebDriver());



            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            AdminTaggableLeadModulesHelpher.WaitForWorkAround(10000);

            AdminTaggableLeadModulesHelpher.MouseOver("Locator");

            AdminTaggableLeadModulesHelpher.ClickElement("ClickOnAdmin");
            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin");

            AdminTaggableLeadModulesHelpher.ClickElement("clickonsetup");
            AdminTaggableLeadModulesHelpher.ClickElement("clickontagfields");
            // GetWebDriver().Navigate().GoToUrl("http://zaspire.com//admin/settings/admintaggable");
            AdminTaggableLeadModulesHelpher.WaitForWorkAround(7000);

            AdminTaggableLeadModulesHelpher.Select("selectmodule", "15");
            AdminTaggableLeadModulesHelpher.ClickElement("CJobType");
            AdminTaggableLeadModulesHelpher.ClickElement("CPreferedCity");
            AdminTaggableLeadModulesHelpher.ClickElement("CGroup");
            AdminTaggableLeadModulesHelpher.ClickElement("CSkillType");
            AdminTaggableLeadModulesHelpher.ClickElement("CSkillName");
            AdminTaggableLeadModulesHelpher.ClickElement("CJobTitle");
            AdminTaggableLeadModulesHelpher.ClickElement("CCompany");
            AdminTaggableLeadModulesHelpher.ClickElement("CExperienceIndustry");
            AdminTaggableLeadModulesHelpher.ClickElement("CExperienceState");
            AdminTaggableLeadModulesHelpher.ClickElement("CState");
            AdminTaggableLeadModulesHelpher.ClickElement("CVisaType");
            AdminTaggableLeadModulesHelpher.ClickElement("CTitle");
            AdminTaggableLeadModulesHelpher.ClickElement("CEducation");
            AdminTaggableLeadModulesHelpher.ClickElement("CExperienceState");
            AdminTaggableLeadModulesHelpher.ClickElement("CPreferedIndustry");
            AdminTaggableLeadModulesHelpher.ClickElement("CStatus");
            AdminTaggableLeadModulesHelpher.ClickElement("uncheckall");
            AdminTaggableLeadModulesHelpher.ClickElement("tagmodule");
           // AdminTaggableLeadModulesHelpher.ClickElement("cancel");
        }
    }
}
