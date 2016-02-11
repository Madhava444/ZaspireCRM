using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite

    {
        [TestClass]
        public class EmailSignatureCreatePage : DriverTestCase
        {
            [TestMethod]
            public void emailsignaturecreatepage()
            {
                string[] username = null;
                string[] password = null;

                XMLParse oXMLData = new XMLParse();
                oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

                username = oXMLData.getData("settings/Credentials", "username");
                password = oXMLData.getData("settings/Credentials", "password");

                //Initializing the objects
                LoginHelper loginHelper = new LoginHelper(GetWebDriver());
                EmailSignatureHelper EmailSignatureHelper = new EmailSignatureHelper(GetWebDriver());

                //Login with valid username and password
                Login(username[0], password[0]);
                Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

                //Verify Page title
                VerifyTitle("Dashboard");
                Console.WriteLine("Redirected at Dashboard screen.");
                EmailSignatureHelper.WaitForWorkAround(4000);

                EmailSignatureHelper.ClickElement("ClickOnActivitiestab");
                EmailSignatureHelper.WaitForWorkAround(4000);

                //EmailSignatureHelper.ClickElement("ClickOnExpandEmailOption");
                //EmailSignatureHelper.WaitForWorkAround(4000);

                GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/mails/email_signature");

                //EmailSignatureHelper.ClickElement("ClickOnSignatureListOption");

                EmailSignatureHelper.ClickElement("ClickOnSignatureNewbutton");

                EmailSignatureHelper.TypeText("SignatureName", "Vipin1");

               // EmailSignatureHelper.TypeText("Description", "Regards,");

                EmailSignatureHelper.ClickElement("ClickOnSignatureSaveOption");


                //Permission
                EmailSignatureHelper.ClickElement("ClickOnSignatureNewbutton");

                EmailSignatureHelper.ClickElement("ClickOnPermissionbutton");

               // EmailSignatureHelper.Select("PermissionPopup","Enabletheselectedcheckbox");

                EmailSignatureHelper.ClickElement("ClickOnCancelbutton");

                EmailSignatureHelper.ClickElement("ClickOnCancellbutton");





               

            }
        }
}