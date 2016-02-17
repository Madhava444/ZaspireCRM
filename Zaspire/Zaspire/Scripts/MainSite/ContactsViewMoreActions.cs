using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
   [TestClass]
    public class ContactsViewMoreActions : DriverTestCase
        {
            [TestMethod]
            public void contactsviewmoreactions()
            {
                string[] username = null;
                string[] password = null;

                XMLParse oXMLData = new XMLParse();
                oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

                username = oXMLData.getData("settings/Credentials", "username");
                password = oXMLData.getData("settings/Credentials", "password");

                //Initializing the objects
                LoginHelper loginHelper = new LoginHelper(GetWebDriver());
                AddContactHelper addcontacHelper = new AddContactHelper(GetWebDriver());
                
                //Login with valid username and password
                Login(username[0], password[0]);
                Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

                //Verify Page title
                VerifyTitle("Dashboard");
                Console.WriteLine("Redirected at Dashboard screen.");
                addcontacHelper.WaitForWorkAround(4000);

                GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
                addcontacHelper.WaitForWorkAround(7000);

                addcontacHelper.ClickElement("ClickOnFirstRecord1");
                addcontacHelper.WaitForWorkAround(3000);

        //********************   More Action_Copy Option ***********
    
                addcontacHelper.MouseOver23("Locator");

                addcontacHelper.ClickElement("ClickOnCopyButton");

                addcontacHelper.AcceptAlert();
                addcontacHelper.WaitForWorkAround(7000);

        
       //*************** ***** More Actions_Add to Campaing*****************

                addcontacHelper.MouseOver23("Locator");

                addcontacHelper.ClickElement("ClickOnAddtoCampaignOption");

                addcontacHelper.ClickElement("CampaignNameButton");

                addcontacHelper.TypeText("CampaingNameSearchFilter", "Cam1");

                addcontacHelper.ClickElement("ClickOnResetButton");

                addcontacHelper.TypeText("CampaingNameSearchFilter", "Cam1");

                addcontacHelper.ClickElement("ClickOnSearchButton");

                addcontacHelper.ClickElement("ClickOntheLink");

                addcontacHelper.Select("Campaigngroups", "new");

                addcontacHelper.ClickElement("ClickOnOkButton");

                addcontacHelper.ClickElement("AddContacts");
                addcontacHelper.WaitForWorkAround(5000);

                addcontacHelper.MouseOver23("Locator");

                addcontacHelper.ClickElement("ClickOnAddtoCampaignOption");
                
                addcontacHelper.TypeText("AddNewCampaignGroupName","NewCampaing");

                addcontacHelper.ClickElement("AddContacts");
                addcontacHelper.WaitForWorkAround(3000);

                addcontacHelper.MouseOver23("Locator");

                addcontacHelper.ClickElement("ClickOnAddtoCampaignOption");

                addcontacHelper.ClickElement("ClickOnCancelOption");

       //************************* More Actions_Download VCard Option****************

                addcontacHelper.MouseOver23("Locator");

                addcontacHelper.ClickElement("ClickOnDownloadVCardOption");
                addcontacHelper.WaitForWorkAround(3000);

                addcontacHelper.AcceptAlert();
                addcontacHelper.WaitForWorkAround(2000);

      //**************************** More Actions_Send Email***********************

                addcontacHelper.MouseOver23("Locator");

                addcontacHelper.ClickElement("ClickOnSendE-MailOption");
                addcontacHelper.WaitForWorkAround(3000);

                addcontacHelper.ClickElement("ClickonEmployeeLink");

                addcontacHelper.TypeText("EmployeeSearchFilter", "vipinp");

                addcontacHelper.ClickElement("ClickOnSearchButton");

                addcontacHelper.ClickElement("EnableCheckboxes");

                addcontacHelper.ClickElement("ClickOnAddButton");

                //Click on Send email button
                addcontacHelper.ClickElement("ClickOnSendOption");

                GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
                addcontacHelper.WaitForWorkAround(7000);

                addcontacHelper.ClickElement("ClickOnFirstRecord1");
                addcontacHelper.WaitForWorkAround(3000);

                addcontacHelper.MouseOver23("Locator");

                addcontacHelper.ClickElement("ClickOnSendE-MailOption");
                addcontacHelper.WaitForWorkAround(3000);

                addcontacHelper.ClickElement("ClickonEmployeeLink");

                addcontacHelper.ClickElement("ClickOnCloseButton");

                GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
                addcontacHelper.WaitForWorkAround(7000);

                addcontacHelper.ClickElement("ClickOnFirstRecord1");
                addcontacHelper.WaitForWorkAround(3000);

                addcontacHelper.MouseOver23("Locator");

                addcontacHelper.ClickElement("ClickOnSendE-MailOption");
                addcontacHelper.WaitForWorkAround(3000);


                //Enter Email to Address
                addcontacHelper.TypeText("ToAddress", "vipin.purushotam@infozeal.com");

                //Click on Send email button
                addcontacHelper.ClickElement("ClickOnSendOption");

    //********************************* More Actions_Add Note ************************

                GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
                addcontacHelper.WaitForWorkAround(7000);

                addcontacHelper.ClickElement("ClickOnFirstRecord1");
                addcontacHelper.WaitForWorkAround(3000);

                addcontacHelper.MouseOver23("Locator");

                addcontacHelper.ClickElement("ClickOnAddNoteOption");
                addcontacHelper.WaitForWorkAround(3000);

                addcontacHelper.TypeText("Subject", "Contact Note");

                addcontacHelper.ClickElement("SaveButton");

                addcontacHelper.MouseOver23("Locator");

                addcontacHelper.ClickElement("ClickOnAddNoteOption");
                addcontacHelper.WaitForWorkAround(3000);

                addcontacHelper.ClickElement("ClickOnCancelOption");

   //****************************** More Actions_Add File ***********************

                addcontacHelper.MouseOver23("Locator");

                addcontacHelper.ClickElement("ClickOnAddFileOption");
                addcontacHelper.WaitForWorkAround(3000);

                addcontacHelper.TypeText("FileName", "File1");

                addcontacHelper.Select("Category", ".txt");

                addcontacHelper.ClickElement("AddFile");

                addcontacHelper.TypeText("Description", "This is sample file");

                addcontacHelper.ClickElement("ClickOnSaveOption");

                addcontacHelper.MouseOver23("Locator");

                addcontacHelper.ClickElement("ClickOnAddFileOption");
                addcontacHelper.WaitForWorkAround(3000);

                addcontacHelper.ClickElement("ClickOnCancelOption");

        //****************************** More Actions_Add Task *****************
                addcontacHelper.MouseOver23("Locator");

                addcontacHelper.ClickElement("ClickOnAddTaskOption");
                addcontacHelper.WaitForWorkAround(3000);

                addcontacHelper.TypeText("Location", "Kentucky");

                addcontacHelper.TypeText("Subject", "NewTask");

                addcontacHelper.TypeText("StartDate", "2016-01-25");

                addcontacHelper.TypeText("EndtDate", "2016-01-25");

                addcontacHelper.ClickElement("EnableRemindersCheckbox");

                addcontacHelper.Select("ReminderPopup", "30minutersprior");

                addcontacHelper.ClickElement("EnableEmailCheckbox");

                addcontacHelper.Select("EmailPopup", "30minutersprior");

                addcontacHelper.ClickElement("EnableEmailCheckbox");

                addcontacHelper.ClickElement("EnableRecurringEventCheckbox");

                addcontacHelper.Select("EveryNumber", "10");

                addcontacHelper.Select("selectdays", "days");

                addcontacHelper.TypeText("until", "2016-01-30");


                addcontacHelper.ClickElement("EnterDescription");

                addcontacHelper.TypeText("Description", "Thisissampledescription");

                addcontacHelper.ClickElement("ClickOnSaveButton");

                addcontacHelper.MouseOver23("Locator");

                addcontacHelper.ClickElement("ClickOnAddTaskOption");
                addcontacHelper.WaitForWorkAround(3000);

                addcontacHelper.ClickElement("ClickOnCancelOption");

           //****************************** More Actions_Setup Appointment *****************
                addcontacHelper.MouseOver23("Locator");

                addcontacHelper.ClickElement("ClickOnSetupAppointmentOption");
                addcontacHelper.WaitForWorkAround(3000);

                addcontacHelper.TypeText("Location", "Kentucky");

                addcontacHelper.TypeText("Subject", "NewTask");

                addcontacHelper.TypeText("StartDate", "2016-01-25");

                addcontacHelper.TypeText("EndtDate", "2016-01-25");

                addcontacHelper.ClickElement("EnableRemindersCheckbox");

                addcontacHelper.Select("ReminderPopup", "30minutersprior");

                addcontacHelper.ClickElement("EnableEmailCheckbox");

                addcontacHelper.Select("EmailPopup", "30minutersprior");

                addcontacHelper.ClickElement("EnableEmailCheckbox");

                addcontacHelper.ClickElement("EnableRecurringEventCheckbox");

                addcontacHelper.Select("EveryNumber", "10");

                addcontacHelper.Select("selectdays", "days");

                addcontacHelper.TypeText("until", "2016-01-30");


                addcontacHelper.ClickElement("EnterDescription");

                addcontacHelper.TypeText("Description", "Thisissampledescription");

                addcontacHelper.ClickElement("ClickOnSaveButton");

                addcontacHelper.MouseOver23("Locator");

                addcontacHelper.ClickElement("ClickOnAddTaskOption");
                addcontacHelper.WaitForWorkAround(3000);

                addcontacHelper.ClickElement("ClickOnCancelOption");

        //**************************** MoreActions_Setup Meeting *******************
                addcontacHelper.MouseOver23("Locator");

                addcontacHelper.ClickElement("ClickOnSetupMeetingOption");
                addcontacHelper.WaitForWorkAround(3000);

                addcontacHelper.TypeText("Location", "Kentucky");

                addcontacHelper.TypeText("Subject", "NewTask");

                addcontacHelper.TypeText("StartDate", "2016-01-25");

                addcontacHelper.TypeText("EndtDate", "2016-01-25");

                addcontacHelper.ClickElement("EnableRemindersCheckbox");

                addcontacHelper.Select("ReminderPopup", "30minutersprior");

                addcontacHelper.ClickElement("EnableEmailCheckbox");

                addcontacHelper.Select("EmailPopup", "30minutersprior");

                addcontacHelper.ClickElement("EnableEmailCheckbox");

                addcontacHelper.ClickElement("EnableRecurringEventCheckbox");

                addcontacHelper.Select("EveryNumber", "10");

                addcontacHelper.Select("selectdays", "days");

                addcontacHelper.TypeText("until", "2016-01-30");


                addcontacHelper.ClickElement("EnterDescription");

                addcontacHelper.TypeText("Description", "Thisissampledescription");

                addcontacHelper.ClickElement("ClickOnSaveButton");

                addcontacHelper.MouseOver23("Locator");

                addcontacHelper.ClickElement("ClickOnAddTaskOption");
                addcontacHelper.WaitForWorkAround(3000);

                addcontacHelper.ClickElement("ClickOnCancelOption");

            //************************** More Actions_ Log Call ********************


                addcontacHelper.MouseOver23("Locator");

                addcontacHelper.ClickElement("ClickOnLogCallOption");
                addcontacHelper.WaitForWorkAround(3000);

                //Enter note subject
                addcontacHelper.TypeText("CallSubject", "LogACall-1");

                addcontacHelper.Select("CallType", "Outbound");

                addcontacHelper.TypeText("CallDate", "2015-10-29");

                addcontacHelper.Select("CallFrom", "Vipin");

                addcontacHelper.Select("CallTo", "PaulAnderson");

                addcontacHelper.TypeText("EnterNumberFrom", "(789) 541-2549");

                addcontacHelper.TypeText("EnterNumberTo", "(789) 541-2549");

                addcontacHelper.Click("CallStartTime");

                addcontacHelper.TypeText("TimeinHrs", "02");

                addcontacHelper.TypeText("TimeinMins", "20");

                addcontacHelper.TypeText("TimeinSecs", "30");

                addcontacHelper.ClickElement("ClickOnEnterDescription");

                addcontacHelper.TypeText("Description", "This is demo file description");

                //Click on Save button
                addcontacHelper.ClickButtonText("SaveOption");


                addcontacHelper.MouseOver23("Locator");

                addcontacHelper.ClickElement("ClickOnLogCallOption");
                addcontacHelper.WaitForWorkAround(3000);

                addcontacHelper.ClickElement("ClickOnCancelOptions");

                // ******************** More Actions_Delete*******************

                addcontacHelper.MouseOver23("Locator");

                addcontacHelper.ClickElement("ClickOnDeleteButton");

                addcontacHelper.AcceptAlert();
                addcontacHelper.WaitForWorkAround(7000);


            }
        }
    }
