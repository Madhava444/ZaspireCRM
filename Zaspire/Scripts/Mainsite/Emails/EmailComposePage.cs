using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite

    {
        [TestClass]
        public class EmailComposePage : DriverTestCase
        {
            [TestMethod]
            public void emailcomposepage()
            {
                string[] username = null;
                string[] password = null;

                XMLParse oXMLData = new XMLParse();
                oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

                username = oXMLData.getData("settings/Credentials", "username");
                password = oXMLData.getData("settings/Credentials", "password");

                //Initializing the objects
                LoginHelper loginHelper = new LoginHelper(GetWebDriver());
                EmailHelper EmailHelper = new EmailHelper(GetWebDriver());

                //Login with valid username and password
                Login(username[0], password[0]);
                Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

                //Verify Page title
                VerifyTitle("Dashboard");
                Console.WriteLine("Redirected at Dashboard screen.");
                EmailHelper.WaitForWorkAround(4000);

                EmailHelper.ClickElement("ClickOnActivitiestab");

                EmailHelper.ClickElement("ClickOnEmailbutton");
                

                
                EmailHelper.ClickElement("ClickOnComposeButton");
                EmailHelper.WaitForWorkAround(4000);

            //**************** Email From Drop down *******************

                //EmailHelper.Select("SelectEmailFromm", "EnterOther");

//                EmailHelper.TypeText("EnterOthermail", "Enter Other");

               // EmailHelper.TypeText("Entermailid", "vipin.purushotam@infozeal.com");


                //EmailHelper.Select("SelectEmailFrom", "Me");

                

                //******************** To Address ******************************

                //***************** Employee Link Popup **************************
                
                //*********** Add Button ************

               

                //Select Related To

                EmailHelper.Select("RelatedTo", "9");

                //Related To Template

                EmailHelper.ClickElement("ClickOnRelatedTo");

                EmailHelper.TypeText("NameorIdSearchFilter", "johnson");

                EmailHelper.ClickElement("ClickOnResettbutton");

                EmailHelper.TypeText("NameorIdSearchFilter", "johnson");

                EmailHelper.ClickElement("ClickOnSearchbutton");

                EmailHelper.ClickElement("ClickOntheLink");

                //Select Email Template
                //EmailHelper.Select("EmailTemplate", "new");


                //Select Email Signature
                EmailHelper.Select("SelectEmailSignature", "2");

                EmailHelper.ClickElement("ClickOnEmployeesLink");

              // EmailHelper.TypeText("SearchByEmailIdFilter", "kavitha");

               // EmailHelper.ClickElement("ClickOnResetButton");

              //  EmailHelper.TypeText("SearchByEmailIdFilter", "kavitha");

              //  EmailHelper.ClickElement("ClickOnSearchButton");

                EmailHelper.ClickElement("EnabletheCheckbox");

                EmailHelper.ClickElement("EnabletheCheckbox1");

                EmailHelper.ClickElement("EnabletheCheckbox2");


                //EmailHelper.TypeText("SearchByEmailIdFilter", "kavitha");

               // EmailHelper.ClickElement("ClickOnSearchButton");

               // EmailHelper.ClickElement("EnabletheCheckbox1");

               // EmailHelper.TypeText("SearchByEmailIdFilter", "madhava");

                //EmailHelper.ClickElement("ClickOnSearchButton");

               // EmailHelper.ClickElement("EnabletheCheckbox2");

                EmailHelper.ClickElement("ClickOnAddButton");

                //************** Close button ************

                EmailHelper.ClickElement("ClickOnEmployeesLink");

                EmailHelper.ClickElement("ClickOnCloseButton"); 

                // ************ To Address Manually ***********

                //EmailHelper.TypeText("EnterToAddress", "vipin.purushotam@infozeal.com");


                // ************ Using CC and BCC Options ****************

                //EmailHelper.ClickElement("ClickOnCCLink");

                //EmailHelper.ClickElement("ClickOnBCCLink");

                //Enter Email Cc Address
                //EmailHelper.TypeText("EnterEmailCcAddress", "nthamishetty@chraterglobal.com");

                //Enter Email Bcc Address
                //EmailHelper.TypeText("EnterEmailBccAddress", "nthamishetty@chraterglobal.com");

                //Enter Email Subject
                EmailHelper.TypeText("EnterEmailSubject", "Test Email");

                //Click On Priority
                EmailHelper.ClickElement("ClickOnPriority");

               

                //Select Send Via
                //EmailHelper.Select("Sendvia", "ZaspireMail");

                //EmailHelper.TypeText("Description", "This is Sample mail");

                //Assigned To
                EmailHelper.Select("AssignedTo1", "104");

                //Click On Send Button
                EmailHelper.ClickElement("ClickOnSendButton");
                EmailHelper.WaitForWorkAround(10000);

                //**************** Draft ******************

               // EmailHelper.ClickElement("ClickOnComposeButton");
               // EmailHelper.WaitForWorkAround(4000);

                EmailHelper.ClickElement("ClickOnEmployeesLink");

                EmailHelper.ClickElement("EnabletheCheckbox");

                EmailHelper.ClickElement("ClickOnAddButton");

                EmailHelper.TypeText("EnterEmailSubject", "Test Email");


               // EmailHelper.TypeText("Description", "This is Sample mail");

                EmailHelper.ClickElement("ClickOnDraftButton");

                //*************** Cancel ********************

                //EmailHelper.ClickElement("ClickOnComposeButton");
               // EmailHelper.WaitForWorkAround(4000);

                EmailHelper.ClickElement("ClickOnCancelButton");


            }
        }
    }
