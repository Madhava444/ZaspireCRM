using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class ContactOtherContactViewEditPage : DriverTestCase
    {
        [TestMethod]
        public void contactothercontactvieweditpage()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var addcontacHelper = new AddContactHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);
            addcontacHelper.WaitForWorkAround(10000);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");


            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            addcontacHelper.WaitForWorkAround(7000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/allcontacts");
            addcontacHelper.WaitForWorkAround(7000);

            //addcontacHelper.TypeText("SearchByStatus", "New");

            addcontacHelper.ClickElement("ClickOnSelectedRecord");

            //#################### Edit Functionality ########################

            addcontacHelper.ClickElement("ClickOnEditFunctionality");

            //********** Edit Form ************

            // ####################### Contact Details ########################

            addcontacHelper.Select("Salutation1", "Mr");

            addcontacHelper.TypeText("FirstNAME1", "John");

            addcontacHelper.TypeText("MiddleNAME1", "k");

            addcontacHelper.TypeText("LastName1", "peter");

            //################ Phone Type ##############################
           
            //SelectPhoneType
            addcontacHelper.Select("PhoneType1", "Cell");

            //Enter Phone Number
            addcontacHelper.TypeText("PhoneNumber1", "(789) 541-2549");

            addcontacHelper.ClickElement("PrimaryButton2");

            //Click on DoNotCall
            addcontacHelper.ClickElement("DoNotCall1");

            addcontacHelper.ClickElement("ClickOnAddPhoneLink1");

            //################## Email ######################


            addcontacHelper.Select("SelectEmailType1", "Work");

            addcontacHelper.TypeText("Eaddrress1", "nthamishetty@charterglobal.com");

            addcontacHelper.ClickElement("PrimaryButton11");

            addcontacHelper.ClickElement("OptedOut1");

            addcontacHelper.ClickElement("ClickOnAddEmailLink1");

            //################## Social Links ##############


            addcontacHelper.Select("SocialLinkType1", "Facebook");

            addcontacHelper.TypeText("Socialid1", "nthamishetty@charterglobal.com");

            addcontacHelper.ClickElement("ClickOnOptedOut11");

            addcontacHelper.ClickElement("ClickOnAddSocialLink1");


            //#################### Address ####################

            addcontacHelper.ClickElement("ClickOnAddressLink1");

            //Select Address Type
            addcontacHelper.Select("AddressType1", "Corporate");

            //Enter Address Line1
            addcontacHelper.TypeText("AddressLines1", "301 ibmbldng");

            //Enter Address Line2
            addcontacHelper.TypeText("AddressLines2", "James Street");

            //Enter City
            addcontacHelper.TypeText("City1", "Ohio");

            //Select Address State
            addcontacHelper.Select("AddressStates", "AK");

            //Select Country
            addcontacHelper.Select("SelectCountrys", "USA");
            addcontacHelper.WaitForWorkAround(3000);

            //Select Zip Code
            addcontacHelper.TypeText("ZipCodes", "14589");
            addcontacHelper.WaitForWorkAround(2000);


            // ############## Related To Link ###############

            addcontacHelper.ClickElement("ClickOnRelatedToLinks");


        }
    }
}