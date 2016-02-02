﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class JobsBulkEmailForGroupView : DriverTestCase
    {
        [TestMethod]
        public void jobsbulkemailforgroupview()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var jobsBulkActionsForGroupViewHelper = new JobsBulkActionsForGroupViewHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Leads
            jobsBulkActionsForGroupViewHelper.ClickElement("ClickOnCandidates");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/candidates");
            //jobsBulkActionsForGroupViewHelper.WaitForWorkAround(7000);


            //Click On Groups
            //jobsBulkActionsForGroupViewHelper.ClickElement("ClickOnGroups");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/candidates/groups");
            jobsBulkActionsForGroupViewHelper.WaitForWorkAround(7000);

            //Open Group
            jobsBulkActionsForGroupViewHelper.ClickElement("FirstCandidateGroupNameLink");


            //################### BULK UPDATE LEADS FOR GROUPS VIEW  #########################


            //Click on Master Check Box
            jobsBulkActionsForGroupViewHelper.ClickElement("CheckMasterCheckBox");

            //Mouse Over
            jobsBulkActionsForGroupViewHelper.MouseOver("locator");

            //Click on Bulk Email
            jobsBulkActionsForGroupViewHelper.ClickElement("ClickOnBulkEmail");
            jobsBulkActionsForGroupViewHelper.WaitForWorkAround(4000);

            //Enter Email Cc Address
            jobsBulkActionsForGroupViewHelper.TypeText("EnterEmailCcAddress", "");

            //Enter Email Bcc Address
            jobsBulkActionsForGroupViewHelper.TypeText("EnterEmailBccAddress", "");

            //Enter Email Subject
            jobsBulkActionsForGroupViewHelper.TypeText("EnterEmailSubject", "Test Email");

            //Click On Prioroty
            jobsBulkActionsForGroupViewHelper.ClickElement("ClickOnPriority");

            //Click On Copy To CC Check Box
            jobsBulkActionsForGroupViewHelper.ClickElement("ClickOnCopyToCCCheckBox");

            //Select Copy To CC
            jobsBulkActionsForGroupViewHelper.Select("SelectCopyToCC", "owners");

            //Click On Copy To BCC Check Box
            jobsBulkActionsForGroupViewHelper.ClickElement("ClickOnCopyToBCCCheckBox");

            //Select Copy To BCC
            jobsBulkActionsForGroupViewHelper.Select("SelectCopyToBCC", "Managers");

            //Select Email Signature
            jobsBulkActionsForGroupViewHelper.Select("SelectEmailSignature", "");

            //Click On Send Button
            jobsBulkActionsForGroupViewHelper.ClickElement("ClickOnSendButton");
            jobsBulkActionsForGroupViewHelper.WaitForWorkAround(10000);







        }
    }
}
