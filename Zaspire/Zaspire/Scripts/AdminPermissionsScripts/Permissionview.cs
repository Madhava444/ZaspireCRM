using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;


namespace Zaspire.Scripts
{
    [TestClass]
    public class AdminPermissions : DriverTestCase
    {
        [TestMethod]
        public void Adminpermissions()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AdminPermissionHelper = new AdminPermissionHelper(GetWebDriver());

            //Variable

            var Name = "Team" + RandomNumber(1, 99);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Mouse over on Profile
            AdminPermissionHelper.Mouseover("locator");

            //click on admin
            AdminPermissionHelper.ClickElement("ClickonAdmin");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin");

            //Click on Usermanagement
            AdminPermissionHelper.ClickElement("Setup");


            //Click on back to home
            AdminPermissionHelper.ClickElement("Permission");

            //Click on AdminProfile1
            AdminPermissionHelper.ClickElement("ClickonViewPermissions");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin");

            //Click on back to home
            AdminPermissionHelper.ClickElement("ClickRadioButton");


            // --------------------------Consultents-------------------------------------------
            //Click  on consultents view team permissions
            AdminPermissionHelper.ClickElement("ConsultentViewAssigneed");
            AdminPermissionHelper.ClickElement("ConsultentViewEveryoneup");
            AdminPermissionHelper.ClickElement("ConsultentViewEveryoneDown");
            AdminPermissionHelper.ClickElement("ConsultentViewEveryoneElse");
            AdminPermissionHelper.ClickElement("ConsultentViewAnyoneFrom");

            //Click on consultents edit team permissions
            AdminPermissionHelper.ClickElement("ConsultentEditAssigneed");
            AdminPermissionHelper.ClickElement("ConsultentEditEveryoneup");
            AdminPermissionHelper.ClickElement("ConsultentEditEveryoneDown");
            AdminPermissionHelper.ClickElement("ConsultentEditEveryoneElse");
            AdminPermissionHelper.ClickElement("ConsultentEditAnyoneFrom");


            //Click on consultents Delete team permissions
            AdminPermissionHelper.ClickElement("ConsultentDeleteAssigneed");
            AdminPermissionHelper.ClickElement("ConsultentDeleteEveryoneup");
            AdminPermissionHelper.ClickElement("ConsultentDeleteEveryoneDown");
            AdminPermissionHelper.ClickElement("ConsultentDeleteEveryoneElse");
            AdminPermissionHelper.ClickElement("ConsultentDeleteAnyoneFrom");


            //--------------------------Email Templates---------------------------

            //Click  on EmailTemplates view team permissions
            AdminPermissionHelper.ClickElement("EmailTemplateViewAssigneed");
            AdminPermissionHelper.ClickElement("EmailTemplateViewEveryoneup");
            AdminPermissionHelper.ClickElement("EmailTemplateViewEveryoneDown");
            AdminPermissionHelper.ClickElement("EmailTemplateViewEveryoneElse");
            AdminPermissionHelper.ClickElement("EmailTemplateViewAnyoneFrom");

            //Click on EmailTemplates edit team permissions
            AdminPermissionHelper.ClickElement("EmailTemplateEditAssigneed");
            AdminPermissionHelper.ClickElement("EmailTemplateEditEveryoneup");
            AdminPermissionHelper.ClickElement("EmailTemplateEditEveryoneDown");
            AdminPermissionHelper.ClickElement("EmailTemplateEditEveryoneElse");
            AdminPermissionHelper.ClickElement("EmailTemplateEditAnyoneFrom");


            //Click on EmailTemplates Delete team permissions
            AdminPermissionHelper.ClickElement("EmailTemplateDeleteAssigneed");
            AdminPermissionHelper.ClickElement("EmailTemplateDeleteEveryoneup");
            AdminPermissionHelper.ClickElement("EmailTemplateDeleteEveryoneDown");
            AdminPermissionHelper.ClickElement("EmailTemplateDeleteEveryoneElse");
            AdminPermissionHelper.ClickElement("EmailTemplateDeleteAnyoneFrom");



            //-------------------------Accounts----------------------------------

            //Click  on Accounts view team permissions
            AdminPermissionHelper.ClickElement("AccountViewAssigneed");
            AdminPermissionHelper.ClickElement("AccountViewEveryoneup");
            AdminPermissionHelper.ClickElement("AccountViewEveryoneDown");
            AdminPermissionHelper.ClickElement("AccountViewEveryoneElse");
            AdminPermissionHelper.ClickElement("AccountViewAnyoneFrom");

            //Click on Account edit team permissions
            AdminPermissionHelper.ClickElement("AccountEditAssigneed");
            AdminPermissionHelper.ClickElement("AccountEditEveryoneup");
            AdminPermissionHelper.ClickElement("AccountEditEveryoneDown");
            AdminPermissionHelper.ClickElement("AccountEditEveryoneElse");
            AdminPermissionHelper.ClickElement("AccountEditAnyoneFrom");


            //Click on Account Delete team permissions
            AdminPermissionHelper.ClickElement("AccountDeleteAssigneed");
            AdminPermissionHelper.ClickElement("AccountDeleteEveryoneup");
            AdminPermissionHelper.ClickElement("AccountDeleteEveryoneDown");
            AdminPermissionHelper.ClickElement("AccountDeleteEveryoneElse");
            AdminPermissionHelper.ClickElement("AccountDeleteAnyoneFrom");


            //--------------------------Applications--------------------------------------------
            //Click  on Applications view team permissions
            AdminPermissionHelper.ClickElement("ApplicationViewAssigneed");
            AdminPermissionHelper.ClickElement("ApplicationViewEveryoneup");
            AdminPermissionHelper.ClickElement("ApplicationViewEveryoneDown");
            AdminPermissionHelper.ClickElement("ApplicationViewEveryoneElse");
            AdminPermissionHelper.ClickElement("ApplicationViewAnyoneFrom");

            //Click on Applications edit team permissions
            AdminPermissionHelper.ClickElement("ApplicationEditAssigneed");
            AdminPermissionHelper.ClickElement("ApplicationEditEveryoneup");
            AdminPermissionHelper.ClickElement("ApplicationEditEveryoneDown");
            AdminPermissionHelper.ClickElement("ApplicationEditEveryoneElse");
            AdminPermissionHelper.ClickElement("ApplicationEditAnyoneFrom");


            //Click on Applications Delete team permissions
            AdminPermissionHelper.ClickElement("ApplicationDeleteAssigneed");
            AdminPermissionHelper.ClickElement("ApplicationDeleteEveryoneup");
            AdminPermissionHelper.ClickElement("ApplicationDeleteEveryoneDown");
            AdminPermissionHelper.ClickElement("ApplicationDeleteEveryoneElse");
            AdminPermissionHelper.ClickElement("ApplicationDeleteAnyoneFrom");

            //------------------------------BulkEmail-------------------------------------

            //Click  on BulkEmails view team permissions
            AdminPermissionHelper.ClickElement("BulkEmailsViewAssigneed");
            AdminPermissionHelper.ClickElement("BulkEmailsViewEveryoneup");
            AdminPermissionHelper.ClickElement("BulkEmailsViewEveryoneDown");
            AdminPermissionHelper.ClickElement("BulkEmailsViewEveryoneElse");
            AdminPermissionHelper.ClickElement("BulkEmailsViewAnyoneFrom");

            //Click on BulkEmails edit team permissions
            AdminPermissionHelper.ClickElement("BulkEmailEditAssigneed1");
            AdminPermissionHelper.ClickElement("BulkEmailEditEveryoneup");
            AdminPermissionHelper.ClickElement("BulkEmailEditEveryoneDown");
            AdminPermissionHelper.ClickElement("BulkEmailEditEveryoneElse");
            AdminPermissionHelper.ClickElement("BulkEmailEditAnyoneFrom");


            //Click on BulkEmails Delete team permissions
            AdminPermissionHelper.ClickElement("BulkEmailDeleteAssigneed");
            AdminPermissionHelper.ClickElement("BulkEmailDeleteEveryoneup");
            AdminPermissionHelper.ClickElement("BulkEmailDeleteEveryoneDown");
            AdminPermissionHelper.ClickElement("BulkEmailDeleteEveryoneElse");
            AdminPermissionHelper.ClickElement("BulkEmailDeleteAnyoneFrom");


            //---------------------------Campaign------------------------------------------------

            //Click  on Campaign view team permissions
            AdminPermissionHelper.ClickElement("CampaignViewAssigneed");
            AdminPermissionHelper.ClickElement("CampaignViewEveryoneup");
            AdminPermissionHelper.ClickElement("CampaignViewEveryoneDown");
            AdminPermissionHelper.ClickElement("CampaignViewEveryoneElse");
            AdminPermissionHelper.ClickElement("CampaignViewAnyoneFrom");

            //Click on Campaign edit team permissions
            AdminPermissionHelper.ClickElement("CampaignEditAssigneed");
            AdminPermissionHelper.ClickElement("CampaignEditEveryoneup");
            AdminPermissionHelper.ClickElement("CampaignEditEveryoneDown");
            AdminPermissionHelper.ClickElement("CampaignEditEveryoneElse");
            AdminPermissionHelper.ClickElement("CampaignEditAnyoneFrom");


            //Click on Campaign Delete team permissions
            AdminPermissionHelper.ClickElement("CampaignDeleteAssigneed");
            AdminPermissionHelper.ClickElement("CampaignDeleteEveryoneup");
            AdminPermissionHelper.ClickElement("CampaignDeleteEveryoneDown");
            AdminPermissionHelper.ClickElement("CampaignDeleteEveryoneElse");
            AdminPermissionHelper.ClickElement("CampaignDeleteAnyoneFrom");


            //---------------------------------Candidates----------------------------------

            //Click  on Candidate view team permissions
            AdminPermissionHelper.ClickElement("CandidateViewAssigneed");
            AdminPermissionHelper.ClickElement("CandidateViewEveryoneup");
            AdminPermissionHelper.ClickElement("CandidateViewEveryoneDown");
            AdminPermissionHelper.ClickElement("CandidateViewEveryoneElse");
            AdminPermissionHelper.ClickElement("CandidateViewAnyoneFrom");

            //Click on Candidate edit team permissions
            AdminPermissionHelper.ClickElement("CandidateEditAssigneed");
            AdminPermissionHelper.ClickElement("CandidateEditEveryoneup");
            AdminPermissionHelper.ClickElement("CandidateEditEveryoneDown");
            AdminPermissionHelper.ClickElement("CandidateEditEveryoneElse");
            AdminPermissionHelper.ClickElement("CandidateEditAnyoneFrom");


            //Click on Candidate Delete team permissions
            AdminPermissionHelper.ClickElement("CandidateDeleteAssigneed");
            AdminPermissionHelper.ClickElement("CandidateDeleteEveryoneup");
            AdminPermissionHelper.ClickElement("CandidateDeleteEveryoneDown");
            AdminPermissionHelper.ClickElement("CandidateDeleteEveryoneElse");
            AdminPermissionHelper.ClickElement("CandidateDeleteAnyoneFrom");


            //---------------------------------Contact----------------------------------

            //Click  on Contact view team permissions
            AdminPermissionHelper.ClickElement("ContactViewAssigneed");
            AdminPermissionHelper.ClickElement("ContactViewEveryoneup");
            AdminPermissionHelper.ClickElement("ContactViewEveryoneDown");
            AdminPermissionHelper.ClickElement("ContactViewEveryoneElse");
            AdminPermissionHelper.ClickElement("ContactViewAnyoneFrom");

            //Click on Contact edit team permissions
            AdminPermissionHelper.ClickElement("ContactEditAssigneed");
            AdminPermissionHelper.ClickElement("ContactEditEveryoneup");
            AdminPermissionHelper.ClickElement("ContactEditEveryoneDown");
            AdminPermissionHelper.ClickElement("ContactEditEveryoneElse");
            AdminPermissionHelper.ClickElement("ContactEditAnyoneFrom");


            //Click on Contact Delete team permissions
            AdminPermissionHelper.ClickElement("ContactDeleteAssigneed");
            AdminPermissionHelper.ClickElement("ContactDeleteEveryoneup");
            AdminPermissionHelper.ClickElement("ContactDeleteEveryoneDown");
            AdminPermissionHelper.ClickElement("ContactDeleteEveryoneElse");
            AdminPermissionHelper.ClickElement("ContactDeleteAnyoneFrom");



            //---------------------------------Interview----------------------------------

            //Click  on Interview view team permissions
            AdminPermissionHelper.ClickElement("InterviewViewAssigneed");
            AdminPermissionHelper.ClickElement("InterviewViewEveryoneup");
            AdminPermissionHelper.ClickElement("InterviewViewEveryoneDown");
            AdminPermissionHelper.ClickElement("InterviewViewEveryoneElse");
            AdminPermissionHelper.ClickElement("InterviewViewAnyoneFrom");

            //Click on Interview edit team permissions
            AdminPermissionHelper.ClickElement("InterviewEditAssigneed");
            AdminPermissionHelper.ClickElement("InterviewEditEveryoneup");
            AdminPermissionHelper.ClickElement("InterviewEditEveryoneDown");
            AdminPermissionHelper.ClickElement("InterviewEditEveryoneElse");
            AdminPermissionHelper.ClickElement("InterviewEditAnyoneFrom");


            //Click on Interview Delete team permissions
            AdminPermissionHelper.ClickElement("InterviewDeleteAssigneed");
            AdminPermissionHelper.ClickElement("InterviewDeleteEveryoneup");
            AdminPermissionHelper.ClickElement("InterviewDeleteEveryoneDown");
            AdminPermissionHelper.ClickElement("InterviewDeleteEveryoneElse");
            AdminPermissionHelper.ClickElement("InterviewDeleteAnyoneFrom");



            //---------------------------------Job----------------------------------

            //Click  on Job view team permissions
            AdminPermissionHelper.ClickElement("JobViewAssigneed");
            AdminPermissionHelper.ClickElement("JobViewEveryoneup");
            AdminPermissionHelper.ClickElement("JobViewEveryoneDown");
            AdminPermissionHelper.ClickElement("JobViewEveryoneElse");
            AdminPermissionHelper.ClickElement("JobViewAnyoneFrom");

            //Click on Job edit team permissions
            AdminPermissionHelper.ClickElement("JobEditAssigneed");
            AdminPermissionHelper.ClickElement("JobEditEveryoneup");
            AdminPermissionHelper.ClickElement("JobEditEveryoneDown");
            AdminPermissionHelper.ClickElement("JobEditEveryoneElse");
            AdminPermissionHelper.ClickElement("JobEditAnyoneFrom");


            //Click on Candidate Delete team permissions
            AdminPermissionHelper.ClickElement("JobDeleteAssigneed");
            AdminPermissionHelper.ClickElement("JobDeleteEveryoneup");
            AdminPermissionHelper.ClickElement("JobDeleteEveryoneDown");
            AdminPermissionHelper.ClickElement("JobDeleteEveryoneElse");
            AdminPermissionHelper.ClickElement("JobDeleteAnyoneFrom");

            //---------------------------------Lead----------------------------------

            //Click  on Lead view team permissions
            AdminPermissionHelper.ClickElement("LeadViewAssigneed");
            AdminPermissionHelper.ClickElement("LeadViewEveryoneup");
            AdminPermissionHelper.ClickElement("LeadViewEveryoneDown");
            AdminPermissionHelper.ClickElement("LeadViewEveryoneElse");
            AdminPermissionHelper.ClickElement("LeadViewAnyoneFrom");

            //Click on Lead edit team permissions
            AdminPermissionHelper.ClickElement("LeadEditAssigneed");
            AdminPermissionHelper.ClickElement("LeadEditEveryoneup");
            AdminPermissionHelper.ClickElement("LeadEditEveryoneDown");
            AdminPermissionHelper.ClickElement("LeadEditEveryoneElse");
            AdminPermissionHelper.ClickElement("LeadEditAnyoneFrom");


            //Click on Lead Delete team permissions
            AdminPermissionHelper.ClickElement("LeadDeleteAssigneed");
            AdminPermissionHelper.ClickElement("LeadDeleteEveryoneup");
            AdminPermissionHelper.ClickElement("LeadDeleteEveryoneDown");
            AdminPermissionHelper.ClickElement("LeadDeleteEveryoneElse");
            AdminPermissionHelper.ClickElement("LeadDeleteAnyoneFrom");

            //---------------------------------opportunity----------------------------------

            //Click  on opportunity view team permissions
            AdminPermissionHelper.ClickElement("OpportunityViewAssigneed");
            AdminPermissionHelper.ClickElement("OpportunityViewEveryoneup");
            AdminPermissionHelper.ClickElement("OpportunityViewEveryoneDown");
            AdminPermissionHelper.ClickElement("OpportunityViewEveryoneElse");
            AdminPermissionHelper.ClickElement("OpportunityViewAnyoneFrom");

            //Click on opportunity edit team permissions
            AdminPermissionHelper.ClickElement("OpportunityEditAssigneed");
            AdminPermissionHelper.ClickElement("OpportunityEditEveryoneup");
            AdminPermissionHelper.ClickElement("OpportunityEditEveryoneDown");
            AdminPermissionHelper.ClickElement("OpportunityEditEveryoneElse");
            AdminPermissionHelper.ClickElement("OpportunityEditAnyoneFrom");


            //Click on opportunity Delete team permissions
            AdminPermissionHelper.ClickElement("OpportunityDeleteAssigneed");
            AdminPermissionHelper.ClickElement("OpportunityDeleteEveryoneup");
            AdminPermissionHelper.ClickElement("OpportunityDeleteEveryoneDown");
            AdminPermissionHelper.ClickElement("OpportunityDeleteEveryoneElse");
            AdminPermissionHelper.ClickElement("OpportunityDeleteAnyoneFrom");

            //---------------------------------partners----------------------------------
            //Click  on partners view team permissions
            AdminPermissionHelper.ClickElement("PartnersViewAssigneed");
            AdminPermissionHelper.ClickElement("PartnersViewEveryoneup");
            AdminPermissionHelper.ClickElement("PartnersViewEveryoneDown");
            AdminPermissionHelper.ClickElement("PartnersViewEveryoneElse");
            AdminPermissionHelper.ClickElement("PartnersViewAnyoneFrom");

            //Click on partners edit team permissions
            AdminPermissionHelper.ClickElement("PartnersEditAssigneed");
            AdminPermissionHelper.ClickElement("PartnersEditEveryoneup");
            AdminPermissionHelper.ClickElement("PartnersEditEveryoneDown");
            AdminPermissionHelper.ClickElement("PartnersEditEveryoneElse");
            AdminPermissionHelper.ClickElement("PartnersEditAnyoneFrom");


            //Click on partners Delete team permissions
            AdminPermissionHelper.ClickElement("PartnersDeleteAssigneed");
            AdminPermissionHelper.ClickElement("PartnersDeleteEveryoneup");
            AdminPermissionHelper.ClickElement("PartnersDeleteEveryoneDown");
            AdminPermissionHelper.ClickElement("PartnersDeleteEveryoneElse");
            AdminPermissionHelper.ClickElement("PartnersDeleteAnyoneFrom");

            //---------------------------------Report----------------------------------

            //Click  on Report view team permissions
            AdminPermissionHelper.ClickElement("ReportViewAssigneed");
            AdminPermissionHelper.ClickElement("ReportViewEveryoneup");
            AdminPermissionHelper.ClickElement("ReportViewEveryoneDown");
            AdminPermissionHelper.ClickElement("ReportViewEveryoneElse");
            AdminPermissionHelper.ClickElement("ReportViewAnyoneFrom");

            //Click on Report edit team permissions
            AdminPermissionHelper.ClickElement("ReportEditAssigneed");
            AdminPermissionHelper.ClickElement("ReportEditEveryoneup");
            AdminPermissionHelper.ClickElement("ReportEditEveryoneDown");
            AdminPermissionHelper.ClickElement("ReportEditEveryoneElse");
            AdminPermissionHelper.ClickElement("ReportEditAnyoneFrom");


            //Click on Report Delete team permissions
            AdminPermissionHelper.ClickElement("ReportDeleteAssigneed");
            AdminPermissionHelper.ClickElement("ReportDeleteEveryoneup");
            AdminPermissionHelper.ClickElement("ReportDeleteEveryoneDown");
            AdminPermissionHelper.ClickElement("ReportDeleteEveryoneElse");
            AdminPermissionHelper.ClickElement("ReportDeleteAnyoneFrom");

             //---------------------------------Vendor----------------------------------

             //Click  on Vendor view team permissions
             AdminPermissionHelper.ClickElement("VendorViewAssigneed");
            AdminPermissionHelper.ClickElement("VendorViewEveryoneup");
            AdminPermissionHelper.ClickElement("VendorEditEveryoneDown");
            AdminPermissionHelper.ClickElement("VendorViewEveryoneElse");
            AdminPermissionHelper.ClickElement("VendorViewAnyoneFrom");

            //Click on Vendor edit team permissions
            AdminPermissionHelper.ClickElement("VendorEditAssigneed");
            AdminPermissionHelper.ClickElement("VendorEditEveryoneup");
            AdminPermissionHelper.ClickElement("VendorEditEveryoneDown");
            AdminPermissionHelper.ClickElement("VendorEditEveryoneElse");
            AdminPermissionHelper.ClickElement("VendorEditAnyoneFrom");


            //Click on Vendor Delete team permissions
            AdminPermissionHelper.ClickElement("VendorDeleteAssigneed");
            AdminPermissionHelper.ClickElement("VendorDeleteEveryoneup");
            AdminPermissionHelper.ClickElement("VendorDeleteEveryoneDown");
            AdminPermissionHelper.ClickElement("VendorDeleteEveryoneElse");
            AdminPermissionHelper.ClickElement("VendorDeleteAnyoneFrom");


            //---------------------------------Email----------------------------------

            //Click  on Email view team permissions
            AdminPermissionHelper.ClickElement("EmailViewAssigneed");
            AdminPermissionHelper.ClickElement("EmailViewEveryoneup");
            AdminPermissionHelper.ClickElement("EmailViewEveryoneDown");
            AdminPermissionHelper.ClickElement("EmailViewEveryoneElse");
            AdminPermissionHelper.ClickElement("EmailViewAnyoneFrom");

            //Click on Email edit team permissions
            AdminPermissionHelper.ClickElement("EmailEditAssigneed");
            AdminPermissionHelper.ClickElement("EmailEditEveryoneup");
            AdminPermissionHelper.ClickElement("EmailEditEveryoneDown");
            AdminPermissionHelper.ClickElement("EmailEditEveryoneElse");
            AdminPermissionHelper.ClickElement("EmailEditAnyoneFrom");


            //Click on Email Delete team permissions
            AdminPermissionHelper.ClickElement("EmailDeleteAssigneed");
            AdminPermissionHelper.ClickElement("EmailDeleteEveryoneup");
            AdminPermissionHelper.ClickElement("EmailDeleteEveryoneDown");
            AdminPermissionHelper.ClickElement("EmailDeleteEveryoneElse");
            AdminPermissionHelper.ClickElement("EmailDeleteAnyoneFrom");


            //---------------------------------Library----------------------------------

            //Click  on Library view team permissions
            AdminPermissionHelper.ClickElement("LibraryViewAssigneed");
            AdminPermissionHelper.ClickElement("LibraryViewEveryoneup");
            AdminPermissionHelper.ClickElement("LibraryViewEveryoneDown");
            AdminPermissionHelper.ClickElement("LibraryViewEveryoneElse");
            AdminPermissionHelper.ClickElement("LibraryViewAnyoneFrom");

            //Click on Library edit team permissions
            AdminPermissionHelper.ClickElement("LibraryEditAssigneed");
            AdminPermissionHelper.ClickElement("LibraryEditEveryoneup");
            AdminPermissionHelper.ClickElement("LibraryEditEveryoneDown");
            AdminPermissionHelper.ClickElement("LibraryEditEveryoneElse");
            AdminPermissionHelper.ClickElement("LibraryEditAnyoneFrom");


            //Click on Library Delete team permissions
            AdminPermissionHelper.ClickElement("LibraryDeleteAssigneed");
            AdminPermissionHelper.ClickElement("LibraryDeleteEveryoneup");
            AdminPermissionHelper.ClickElement("LibraryDeleteEveryoneDown");
            AdminPermissionHelper.ClickElement("LibraryDeleteEveryoneElse");
            AdminPermissionHelper.ClickElement("LibraryDeleteAnyoneFrom");



            //Click on Save button
            AdminPermissionHelper.ClickElement("PermissionsSave");

            //Clic onn Back
            AdminPermissionHelper.ClickElement("Back");

        }
    }
}
