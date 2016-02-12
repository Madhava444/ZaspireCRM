using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class EditVendor : DriverTestCase
    {
        [TestMethod]
        public void editVendor()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var VendorHelper = new VendorHelper(GetWebDriver());


            //Variable

            var FirstName = "vendor" + RandomNumber(1, 99);
            var LastName = "master" + RandomNumber(1, 99);
            var PhoneNumber = "123456789" + RandomNumber(10, 99);
            var Companyname = "Vendor" + RandomNumber(1, 20);
            var Website = "www.vendor.com" + RandomNumber(1, 10);
            var VendorName = "Jhon" + RandomNumber(1, 30);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Dashboard in menu
            VendorHelper.ClickElement("Vendor");

            //############# Add vendor ####################################

            //Click on vendor record to view
            VendorHelper.ClickElement("VendorView");

            //Click on new button
            VendorHelper.ClickElement("VendorEdit");

            //Select Owner
            //VendorHelper.Select("VendorOwner", "17");

            //Select manager
            //VendorHelper.Select("VendorManager", "28");

            //Enter VendorName
            VendorHelper.TypeText("VendorName", VendorName);

            //Enter company name
            VendorHelper.TypeText("VendorCompanyname", Companyname);

            //Enter website
            VendorHelper.TypeText("VendorWebsite", Website);

            // Enter Vendorcode
            VendorHelper.TypeText("Vendorcode", "1234");

            //Enter linked url
            VendorHelper.TypeText("VendorLinkedURL", "");

            //Enter Facebook url
            VendorHelper.TypeText("VendorFacebookUrl", "");

            //Enter Twitter url
            VendorHelper.TypeText("VendorTwitterURL", "");


            //Enter Adress type
            VendorHelper.Select("VendorAdressType", "Corporate");

            //Enter Adress line1
            VendorHelper.TypeText("VendorAdressLine1", "Road1");

            //Enter Adressline2
            VendorHelper.TypeText("VendorAdressLine2", "Line5");

            //Enter City
            VendorHelper.TypeText("VendorCity", "York");

            //select state
            VendorHelper.Select("VendorState", "AL");

            //Select country
            VendorHelper.Select("VendorCountry", "USA");

            //Enter Zipcode
            VendorHelper.TypeText("VendorZipcode", "4325");

            //Select salutation
            VendorHelper.Select("VendorSalutation", "Mr");

            //Enter First name
            VendorHelper.TypeText("VendorFirstname", FirstName);

            //Enter Middle name
            VendorHelper.TypeText("VendorMiddlename", "robert");

            //Enter Last name
            VendorHelper.TypeText("VendorLastname", LastName);

            //Select phonetype
            VendorHelper.Select("VendorPhonetype", "Home");

            //Enter phonenumber
            VendorHelper.TypeText("VendorPhonetext", PhoneNumber);

            //Click on check box
            VendorHelper.ClickElement("VendorDonotCall");

            //Select Email type
            VendorHelper.Select("VendorEmailtype", "Home");

            //Enter email adress
            VendorHelper.TypeText("VendorEmailText", "kavitha@gmail.com");

            //Click on checkbox
            VendorHelper.ClickElement("VendorOptedout");

            //Select Social link type
            VendorHelper.Select("VendorSociallinktype", "Facebook");

            //Enter sociallink
            VendorHelper.TypeText("VendorSociallinktext", "asd@yahoo.com");

            //Click on checkbox
            VendorHelper.ClickElement("VendorSociallinoptedout");

            //Click on save
            VendorHelper.ClickElement("EditSave");

            //Click on Cancel
            // VendorHelper.ClickElement("VendorCancel");

            

        }
    }
}


