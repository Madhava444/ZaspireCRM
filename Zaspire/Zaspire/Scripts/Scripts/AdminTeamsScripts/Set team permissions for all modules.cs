using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;
using OpenQA.Selenium.Interactions;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AllModulesSetTeamPermissions: DriverTestCase
    {
        [TestMethod]
        public void SetteamPermissionsforallmodules()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AdminTeamsHelper = new AdminTeamsHelper(GetWebDriver());

            //Variable

            var Name = "Team" + RandomNumber(1, 99);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Mouse over on Profile
            AdminTeamsHelper.Mouseover("locator");

            //click on admin
            AdminTeamsHelper.ClickElement("ClickonAdmin");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin");

            //Click on teams
            AdminTeamsHelper.ClickElement("teams");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin/roles/team");


            //Click on View team
            AdminTeamsHelper.ClickElement("Teamview");
            
            //Click on Set permission
            AdminTeamsHelper.ClickElement("Setpermissions");

            //Click on Module radio button
            AdminTeamsHelper.ClickElement("Modulepermissions");


            // --------------------------Consultents-------------------------------------------
            //Click  on consultents view team permissions
            /*  AdminTeamsHelper.ClickElement("ConsultentViewAssigneed");
              AdminTeamsHelper.ClickElement("ConsultentViewEveryoneup");
              AdminTeamsHelper.ClickElement("ConsultentViewEveryoneDown");
              AdminTeamsHelper.ClickElement("ConsultentViewEveryoneElse");
              AdminTeamsHelper.ClickElement("ConsultentViewAnyoneFrom");

              //Click on consultents edit team permissions
              AdminTeamsHelper.ClickElement("ConsultentEditAssigneed");
              AdminTeamsHelper.ClickElement("ConsultentEditEveryoneup");
              AdminTeamsHelper.ClickElement("ConsultentEditEveryoneDown");
              AdminTeamsHelper.ClickElement("ConsultentEditEveryoneElse");
              AdminTeamsHelper.ClickElement("ConsultentEditAnyoneFrom");


              //Click on consultents Delete team permissions
              AdminTeamsHelper.ClickElement("ConsultentDeleteAssigneed");
              AdminTeamsHelper.ClickElement("ConsultentDeleteEveryoneup");
              AdminTeamsHelper.ClickElement("ConsultentDeleteEveryoneDown");
              AdminTeamsHelper.ClickElement("ConsultentDeleteEveryoneElse");
              AdminTeamsHelper.ClickElement("ConsultentDeleteAnyoneFrom");


              //--------------------------Email Templates---------------------------

              //Click  on EmailTemplates view team permissions
              AdminTeamsHelper.ClickElement("EmailTemplateViewAssigneed");
              AdminTeamsHelper.ClickElement("EmailTemplateViewEveryoneup");
              AdminTeamsHelper.ClickElement("EmailTemplateViewEveryoneDown");
              AdminTeamsHelper.ClickElement("EmailTemplateViewEveryoneElse");
              AdminTeamsHelper.ClickElement("EmailTemplateViewAnyoneFrom");

              //Click on EmailTemplates edit team permissions
              AdminTeamsHelper.ClickElement("EmailTemplateEditAssigneed");
              AdminTeamsHelper.ClickElement("EmailTemplateEditEveryoneup");
              AdminTeamsHelper.ClickElement("EmailTemplateEditEveryoneDown");
              AdminTeamsHelper.ClickElement("EmailTemplateEditEveryoneElse");
              AdminTeamsHelper.ClickElement("EmailTemplateEditAnyoneFrom");


              //Click on EmailTemplates Delete team permissions
              AdminTeamsHelper.ClickElement("EmailTemplateDeleteAssigneed");
              AdminTeamsHelper.ClickElement("EmailTemplateDeleteEveryoneup");
              AdminTeamsHelper.ClickElement("EmailTemplateDeleteEveryoneDown");
              AdminTeamsHelper.ClickElement("EmailTemplateDeleteEveryoneElse");
              AdminTeamsHelper.ClickElement("EmailTemplateDeleteAnyoneFrom");



              //-------------------------Accounts----------------------------------

              //Click  on Accounts view team permissions
              AdminTeamsHelper.ClickElement("AccountViewAssigneed");
              AdminTeamsHelper.ClickElement("AccountViewEveryoneup");
              AdminTeamsHelper.ClickElement("AccountViewEveryoneDown");
              AdminTeamsHelper.ClickElement("AccountViewEveryoneElse");
              AdminTeamsHelper.ClickElement("AccountViewAnyoneFrom");

              //Click on Account edit team permissions
              AdminTeamsHelper.ClickElement("AccountEditAssigneed");
              AdminTeamsHelper.ClickElement("AccountEditEveryoneup");
              AdminTeamsHelper.ClickElement("AccountEditEveryoneDown");
              AdminTeamsHelper.ClickElement("AccountEditEveryoneElse");
              AdminTeamsHelper.ClickElement("AccountEditAnyoneFrom");


              //Click on Account Delete team permissions
              AdminTeamsHelper.ClickElement("AccountDeleteAssigneed");
              AdminTeamsHelper.ClickElement("AccountDeleteEveryoneup");
              AdminTeamsHelper.ClickElement("AccountDeleteEveryoneDown");
              AdminTeamsHelper.ClickElement("AccountDeleteEveryoneElse");
              AdminTeamsHelper.ClickElement("AccountDeleteAnyoneFrom");


              //--------------------------Applications--------------------------------------------
              //Click  on Applications view team permissions
              AdminTeamsHelper.ClickElement("ApplicationViewAssigneed");
              AdminTeamsHelper.ClickElement("ApplicationViewEveryoneup");
              AdminTeamsHelper.ClickElement("ApplicationViewEveryoneDown");
              AdminTeamsHelper.ClickElement("ApplicationViewEveryoneElse");
              AdminTeamsHelper.ClickElement("ApplicationViewAnyoneFrom");

              //Click on Applications edit team permissions
              AdminTeamsHelper.ClickElement("ApplicationEditAssigneed");
              AdminTeamsHelper.ClickElement("ApplicationEditEveryoneup");
              AdminTeamsHelper.ClickElement("ApplicationEditEveryoneDown");
              AdminTeamsHelper.ClickElement("ApplicationEditEveryoneElse");
              AdminTeamsHelper.ClickElement("ApplicationEditAnyoneFrom");*/


            //Click on Applications Delete team permissions
            AdminTeamsHelper.ClickElement("ApplicationDeleteAssigneed");
            AdminTeamsHelper.ClickElement("ApplicationDeleteEveryoneup");
            AdminTeamsHelper.ClickElement("ApplicationDeleteEveryoneDown");
            AdminTeamsHelper.ClickElement("ApplicationDeleteEveryoneElse");
            AdminTeamsHelper.ClickElement("ApplicationDeleteAnyoneFrom");

            //------------------------------BulkEmail-------------------------------------

            //Click  on BulkEmails view team permissions
            AdminTeamsHelper.ClickElement("BulkEmailsViewAssigneed");
            AdminTeamsHelper.ClickElement("BulkEmailsViewEveryoneup");
            AdminTeamsHelper.ClickElement("BulkEmailsViewEveryoneDown");
            AdminTeamsHelper.ClickElement("BulkEmailsViewEveryoneElse");
            AdminTeamsHelper.ClickElement("BulkEmailsViewAnyoneFrom");

            //Click on BulkEmails edit team permissions
            AdminTeamsHelper.ClickElement("BulkEmailEditAssigneed1");
            AdminTeamsHelper.ClickElement("BulkEmailEditEveryoneup");
            AdminTeamsHelper.ClickElement("BulkEmailEditEveryoneDown");
            AdminTeamsHelper.ClickElement("BulkEmailEditEveryoneElse");
            AdminTeamsHelper.ClickElement("BulkEmailEditAnyoneFrom");


            //Click on BulkEmails Delete team permissions
            AdminTeamsHelper.ClickElement("BulkEmailDeleteAssigneed");
            AdminTeamsHelper.ClickElement("BulkEmailDeleteEveryoneup");
            AdminTeamsHelper.ClickElement("BulkEmailDeleteEveryoneDown");
            AdminTeamsHelper.ClickElement("BulkEmailDeleteEveryoneElse");
            AdminTeamsHelper.ClickElement("BulkEmailDeleteAnyoneFrom");


            //---------------------------Campaign------------------------------------------------

            //Click  on Campaign view team permissions
            AdminTeamsHelper.ClickElement("CampaignViewAssigneed");
            AdminTeamsHelper.ClickElement("CampaignViewEveryoneup");
            AdminTeamsHelper.ClickElement("CampaignViewEveryoneDown");
            AdminTeamsHelper.ClickElement("CampaignViewEveryoneElse");
            AdminTeamsHelper.ClickElement("CampaignViewAnyoneFrom");

            //Click on Campaign edit team permissions
            AdminTeamsHelper.ClickElement("CampaignEditAssigneed");
            AdminTeamsHelper.ClickElement("CampaignEditEveryoneup");
            AdminTeamsHelper.ClickElement("CampaignEditEveryoneDown");
            AdminTeamsHelper.ClickElement("CampaignEditEveryoneElse");
            AdminTeamsHelper.ClickElement("CampaignEditAnyoneFrom");


            //Click on Campaign Delete team permissions
            AdminTeamsHelper.ClickElement("CampaignDeleteAssigneed");
            AdminTeamsHelper.ClickElement("CampaignDeleteEveryoneup");
            AdminTeamsHelper.ClickElement("CampaignDeleteEveryoneDown");
            AdminTeamsHelper.ClickElement("CampaignDeleteEveryoneElse");
            AdminTeamsHelper.ClickElement("CampaignDeleteAnyoneFrom");


            //---------------------------------Candidates----------------------------------,n.

            //Click  on Candidate view team permissions
            AdminTeamsHelper.ClickElement("CandidateViewAssigneed");
            AdminTeamsHelper.ClickElement("CandidateViewEveryoneup");
            AdminTeamsHelper.ClickElement("CandidateViewEveryoneDown");
            AdminTeamsHelper.ClickElement("CandidateViewEveryoneElse");
            AdminTeamsHelper.ClickElement("CandidateViewAnyoneFrom");

            //Click on Candidate edit team permissions
            AdminTeamsHelper.ClickElement("CandidateEditAssigneed");
            AdminTeamsHelper.ClickElement("CandidateEditEveryoneup");
            AdminTeamsHelper.ClickElement("CandidateEditEveryoneDown");
            AdminTeamsHelper.ClickElement("CandidateEditEveryoneElse");
            AdminTeamsHelper.ClickElement("CandidateEditAnyoneFrom");


            //Click on Candidate Delete team permissions
            AdminTeamsHelper.ClickElement("CandidateDeleteAssigneed");
            AdminTeamsHelper.ClickElement("CandidateDeleteEveryoneup");
            AdminTeamsHelper.ClickElement("CandidateDeleteEveryoneDown");
            AdminTeamsHelper.ClickElement("CandidateDeleteEveryoneElse");
            AdminTeamsHelper.ClickElement("CandidateDeleteAnyoneFrom");


            //---------------------------------Contact----------------------------------,n.

            //Click  on Contact view team permissions
            AdminTeamsHelper.ClickElement("ContactViewAssigneed");
            AdminTeamsHelper.ClickElement("ContactViewEveryoneup");
            AdminTeamsHelper.ClickElement("ContactViewEveryoneDown");
            AdminTeamsHelper.ClickElement("ContactViewEveryoneElse");
            AdminTeamsHelper.ClickElement("ContactViewAnyoneFrom");

            //Click on Contact edit team permissions
            AdminTeamsHelper.ClickElement("ContactEditAssigneed");
            AdminTeamsHelper.ClickElement("ContactEditEveryoneup");
            AdminTeamsHelper.ClickElement("ContactEditEveryoneDown");
            AdminTeamsHelper.ClickElement("ContactEditEveryoneElse");
            AdminTeamsHelper.ClickElement("ContactEditAnyoneFrom");


            //Click on Contact Delete team permissions
            AdminTeamsHelper.ClickElement("ContactDeleteAssigneed");
            AdminTeamsHelper.ClickElement("ContactDeleteEveryoneup");
            AdminTeamsHelper.ClickElement("ContactDeleteEveryoneDown");
            AdminTeamsHelper.ClickElement("ContactDeleteEveryoneElse");
            AdminTeamsHelper.ClickElement("ContactDeleteAnyoneFrom");



            //---------------------------------Interview----------------------------------,n.

            //Click  on Interview view team permissions
            AdminTeamsHelper.ClickElement("InterviewViewAssigneed");
            AdminTeamsHelper.ClickElement("InterviewViewEveryoneup");
            AdminTeamsHelper.ClickElement("InterviewViewEveryoneDown");
            AdminTeamsHelper.ClickElement("InterviewViewEveryoneElse");
            AdminTeamsHelper.ClickElement("InterviewViewAnyoneFrom");

            //Click on Interview edit team permissions
            AdminTeamsHelper.ClickElement("InterviewEditAssigneed");
            AdminTeamsHelper.ClickElement("InterviewEditEveryoneup");
            AdminTeamsHelper.ClickElement("InterviewEditEveryoneDown");
            AdminTeamsHelper.ClickElement("InterviewEditEveryoneElse");
            AdminTeamsHelper.ClickElement("InterviewEditAnyoneFrom");


            //Click on Interview Delete team permissions
            AdminTeamsHelper.ClickElement("InterviewDeleteAssigneed");
            AdminTeamsHelper.ClickElement("InterviewDeleteEveryoneup");
            AdminTeamsHelper.ClickElement("InterviewDeleteEveryoneDown");
            AdminTeamsHelper.ClickElement("InterviewDeleteEveryoneElse");
            AdminTeamsHelper.ClickElement("InterviewDeleteAnyoneFrom");



            //---------------------------------Job----------------------------------,n.

            //Click  on Job view team permissions
            AdminTeamsHelper.ClickElement("JobViewAssigneed");
            AdminTeamsHelper.ClickElement("JobViewEveryoneup");
            AdminTeamsHelper.ClickElement("JobViewEveryoneDown");
            AdminTeamsHelper.ClickElement("JobViewEveryoneElse");
            AdminTeamsHelper.ClickElement("JobViewAnyoneFrom");

            //Click on Job edit team permissions
            AdminTeamsHelper.ClickElement("JobEditAssigneed");
            AdminTeamsHelper.ClickElement("JobEditEveryoneup");
            AdminTeamsHelper.ClickElement("JobEditEveryoneDown");
            AdminTeamsHelper.ClickElement("JobEditEveryoneElse");
            AdminTeamsHelper.ClickElement("JobEditAnyoneFrom");


            //Click on Candidate Delete team permissions
            AdminTeamsHelper.ClickElement("JobDeleteAssigneed");
            AdminTeamsHelper.ClickElement("JobDeleteEveryoneup");
            AdminTeamsHelper.ClickElement("JobDeleteEveryoneDown");
            AdminTeamsHelper.ClickElement("JobDeleteEveryoneElse");
            AdminTeamsHelper.ClickElement("JobDeleteAnyoneFrom");

            //---------------------------------Lead----------------------------------,n.

            //Click  on Lead view team permissions
            AdminTeamsHelper.ClickElement("LeadViewAssigneed");
            AdminTeamsHelper.ClickElement("LeadViewEveryoneup");
            AdminTeamsHelper.ClickElement("LeadViewEveryoneDown");
            AdminTeamsHelper.ClickElement("LeadViewEveryoneElse");
            AdminTeamsHelper.ClickElement("LeadViewAnyoneFrom");

            //Click on Lead edit team permissions
            AdminTeamsHelper.ClickElement("LeadEditAssigneed");
            AdminTeamsHelper.ClickElement("LeadEditEveryoneup");
            AdminTeamsHelper.ClickElement("LeadCaEditEveryoneDown");
            AdminTeamsHelper.ClickElement("LeadEditEveryoneElse");
            AdminTeamsHelper.ClickElement("LeadEditAnyoneFrom");


            //Click on Lead Delete team permissions
            AdminTeamsHelper.ClickElement("LeadDeleteAssigneed");
            AdminTeamsHelper.ClickElement("LeadDeleteEveryoneup");
            AdminTeamsHelper.ClickElement("LeadDeleteEveryoneDown");
            AdminTeamsHelper.ClickElement("LeadDeleteEveryoneElse");
            AdminTeamsHelper.ClickElement("LeadDeleteAnyoneFrom");

            //---------------------------------opportunity----------------------------------,n.

            //Click  on opportunity view team permissions
            AdminTeamsHelper.ClickElement("OpportunityViewAssigneed");
            AdminTeamsHelper.ClickElement("OpportunityViewEveryoneup");
            AdminTeamsHelper.ClickElement("OpportunityViewEveryoneDown");
            AdminTeamsHelper.ClickElement("OpportunitydViewEveryoneElse");
            AdminTeamsHelper.ClickElement("OpportunityViewViewAnyoneFrom");

            //Click on opportunity edit team permissions
            AdminTeamsHelper.ClickElement("OpportunityEditAssigneed");
            AdminTeamsHelper.ClickElement("opportunityEditEveryoneup");
            AdminTeamsHelper.ClickElement("opportunityEditEveryoneDown");
            AdminTeamsHelper.ClickElement("opportunityEditEveryoneElse");
            AdminTeamsHelper.ClickElement("opportunityEditAnyoneFrom");


            //Click on opportunity Delete team permissions
            AdminTeamsHelper.ClickElement("opportunityDeleteAssigneed");
            AdminTeamsHelper.ClickElement("opportunityDeleteEveryoneup");
            AdminTeamsHelper.ClickElement("opportunityDeleteEveryoneDown");
            AdminTeamsHelper.ClickElement("opportunityDeleteEveryoneElse");
            AdminTeamsHelper.ClickElement("opportunityDeleteAnyoneFrom");

            //---------------------------------partners----------------------------------
            //Click  on partners view team permissions
            AdminTeamsHelper.ClickElement("partnersViewAssigneed");
            AdminTeamsHelper.ClickElement("partnersViewEveryoneup");
            AdminTeamsHelper.ClickElement("partnersViewEveryoneDown");
            AdminTeamsHelper.ClickElement("partnersdViewEveryoneElse");
            AdminTeamsHelper.ClickElement("partnersViewViewAnyoneFrom");

            //Click on partners edit team permissions
            AdminTeamsHelper.ClickElement("partnersEditAssigneed");
            AdminTeamsHelper.ClickElement("partnersEditEveryoneup");
            AdminTeamsHelper.ClickElement("partnersEditEveryoneDown");
            AdminTeamsHelper.ClickElement("partnersEditEveryoneElse");
            AdminTeamsHelper.ClickElement("partnersEditAnyoneFrom");


            //Click on partners Delete team permissions
            AdminTeamsHelper.ClickElement("partnersDeleteAssigneed");
            AdminTeamsHelper.ClickElement("partnersDeleteEveryoneup");
            AdminTeamsHelper.ClickElement("partnersDeleteEveryoneDown");
            AdminTeamsHelper.ClickElement("partnersDeleteEveryoneElse");
            AdminTeamsHelper.ClickElement("partnersDeleteAnyoneFrom");

            //---------------------------------Report----------------------------------,n.

            //Click  on Report view team permissions
            AdminTeamsHelper.ClickElement("ReportViewAssigneed");
            AdminTeamsHelper.ClickElement("ReportViewEveryoneup");
            AdminTeamsHelper.ClickElement("ReportViewEveryoneDown");
            AdminTeamsHelper.ClickElement("ReportdViewEveryoneElse");
            AdminTeamsHelper.ClickElement("ReportViewViewAnyoneFrom");

            //Click on Report edit team permissions
            AdminTeamsHelper.ClickElement("ReportEditAssigneed");
            AdminTeamsHelper.ClickElement("ReportEditEveryoneup");
            AdminTeamsHelper.ClickElement("ReportEditEveryoneDown");
            AdminTeamsHelper.ClickElement("ReportEditEveryoneElse");
            AdminTeamsHelper.ClickElement("ReportEditAnyoneFrom");


            //Click on Report Delete team permissions
            AdminTeamsHelper.ClickElement("ReportDeleteAssigneed");
            AdminTeamsHelper.ClickElement("ReportDeleteEveryoneup");
            AdminTeamsHelper.ClickElement("ReportDeleteEveryoneDown");
            AdminTeamsHelper.ClickElement("ReportDeleteEveryoneElse");
            AdminTeamsHelper.ClickElement("ReportDeleteAnyoneFrom");

            //---------------------------------Vendor----------------------------------,n.

            //Click  on Vendor view team permissions
            AdminTeamsHelper.ClickElement("VendorViewAssigneed");
            AdminTeamsHelper.ClickElement("VendorViewEveryoneup");
            AdminTeamsHelper.ClickElement("VendorViewEveryoneDown");
            AdminTeamsHelper.ClickElement("VendordViewEveryoneElse");
            AdminTeamsHelper.ClickElement("VendorViewViewAnyoneFrom");

            //Click on Vendor edit team permissions
            AdminTeamsHelper.ClickElement("VendorEditAssigneed");
            AdminTeamsHelper.ClickElement("VendorEditEveryoneup");
            AdminTeamsHelper.ClickElement("VendorEditEveryoneDown");
            AdminTeamsHelper.ClickElement("VendorEditEveryoneElse");
            AdminTeamsHelper.ClickElement("VendorEditAnyoneFrom");


            //Click on Vendor Delete team permissions
            AdminTeamsHelper.ClickElement("VendorDeleteAssigneed");
            AdminTeamsHelper.ClickElement("VendorDeleteEveryoneup");
            AdminTeamsHelper.ClickElement("VendorDeleteEveryoneDown");
            AdminTeamsHelper.ClickElement("VendorDeleteEveryoneElse");
            AdminTeamsHelper.ClickElement("VendorDeleteAnyoneFrom");


            //---------------------------------Email----------------------------------,n.

            //Click  on Email view team permissions
            AdminTeamsHelper.ClickElement("EmailViewAssigneed");
            AdminTeamsHelper.ClickElement("EmailViewEveryoneup");
            AdminTeamsHelper.ClickElement("EmailViewEveryoneDown");
            AdminTeamsHelper.ClickElement("EmaildViewEveryoneElse");
            AdminTeamsHelper.ClickElement("EmailViewViewAnyoneFrom");

            //Click on Email edit team permissions
            AdminTeamsHelper.ClickElement("EmailEditAssigneed");
            AdminTeamsHelper.ClickElement("EmailEditEveryoneup");
            AdminTeamsHelper.ClickElement("EmailEditEveryoneDown");
            AdminTeamsHelper.ClickElement("EmailEditEveryoneElse");
            AdminTeamsHelper.ClickElement("EmailEditAnyoneFrom");


            //Click on Email Delete team permissions
            AdminTeamsHelper.ClickElement("EmailDeleteAssigneed");
            AdminTeamsHelper.ClickElement("EmailDeleteEveryoneup");
            AdminTeamsHelper.ClickElement("EmailDeleteEveryoneDown");
            AdminTeamsHelper.ClickElement("EmailDeleteEveryoneElse");
            AdminTeamsHelper.ClickElement("EmailDeleteAnyoneFrom");


            //---------------------------------Library----------------------------------,n.

            //Click  on Library view team permissions
            AdminTeamsHelper.ClickElement("LibraryViewAssigneed");
            AdminTeamsHelper.ClickElement("LibraryViewEveryoneup");
            AdminTeamsHelper.ClickElement("LibraryViewEveryoneDown");
            AdminTeamsHelper.ClickElement("LibrarydViewEveryoneElse");
            AdminTeamsHelper.ClickElement("LibraryViewViewAnyoneFrom");

            //Click on Library edit team permissions
            AdminTeamsHelper.ClickElement("LibraryEditAssigneed");
            AdminTeamsHelper.ClickElement("LibraryEditEveryoneup");
            AdminTeamsHelper.ClickElement("LibraryEditEveryoneDown");
            AdminTeamsHelper.ClickElement("LibraryEditEveryoneElse");
            AdminTeamsHelper.ClickElement("LibraryEditAnyoneFrom");


            //Click on Library Delete team permissions
            AdminTeamsHelper.ClickElement("LibraryDeleteAssigneed");
            AdminTeamsHelper.ClickElement("LibraryDeleteEveryoneup");
            AdminTeamsHelper.ClickElement("LibraryDeleteEveryoneDown");
            AdminTeamsHelper.ClickElement("LibraryDeleteEveryoneElse");
            AdminTeamsHelper.ClickElement("LibraryDeleteAnyoneFrom");



            //Click on Save button
            AdminTeamsHelper.ClickElement("SavePermissions");



        }
    }
}