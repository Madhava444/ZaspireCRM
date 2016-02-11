using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class AddContact : DriverTestCase
    {
        [TestMethod]
        public void addcontact()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AddContactHelper = new AddContactHelper(GetWebDriver());
           // var addContactHelper = new AddContactHelper(GetWebDriver());

            //Variable
            var mail1 = "Test" + RandomNumber(1, 99) + "@yopmail.com";
            var mail2 = "Test" + RandomNumber(11, 49) + "@gmail.com";
            //var numb = "0123456789" + RandomNumber(0, 9);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);
            AddContactHelper.WaitForWorkAround(10000);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Clients in Topmenu
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            AddContactHelper.WaitForWorkAround(7000);

            //AddContactHelper.ClickElement("ClickOnContactsTab");
            //AddContactHelper.WaitForWorkAround(5000);
             
            //################################# CREATE A CONTACT   #############################################

            //Click On Create
            //AddContactHelper.ClickElement("ClickOnAddNew");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts/addnew");
            AddContactHelper.WaitForWorkAround(5000);


            //Select Status
             AddContactHelper.Select("SelectStatus", "In Progress");

            //Select Source
            AddContactHelper.Select("SelectSource", "Email");
            AddContactHelper.WaitForWorkAround(2000);

            //Select Category
            AddContactHelper.Select("SelectCategory", "12396");
            AddContactHelper.WaitForWorkAround(2000);

            //Select Owner
            AddContactHelper.Select("SelectOwner", "17");


        
          //#############################Contact Information ############################

            // Select Salutation
            AddContactHelper.Select("Salutation", "Mr");
            
            //Enter First Name
            AddContactHelper.TypeText("FirstNAME", "John");

           //Enter Last Name
            AddContactHelper.TypeText("LastName", "peter");

            AddContactHelper.TypeText("ContactTitle", "Peter");

            AddContactHelper.TypeText("Department", "IT");

            AddContactHelper.TypeText("CompanyName", "TestCompany");

            //AddContactHelper.ClickElement("ClickOnCompanyLogo");

          
        
            //######################## PHONE ###########################


            //SelectPhoneType
            AddContactHelper.Select("PhoneType", "Cell");

            //Enter Phone Number
            AddContactHelper.TypeText("PhoneNumber", "(789) 541-2549");

            AddContactHelper.ClickElement("PrimaryButton");

            //Click on DoNotCall
            AddContactHelper.ClickElement("DoNotCall");

            AddContactHelper.ClickElement("ClickOnAddPhoneLink");

            //####################### EMAIL AND INTERNET    ##########################################

            //Select Email Type
            AddContactHelper.Select("SelectEmailType", "Work");

            //Enter Eaddrress
            AddContactHelper.TypeText("Eaddrress", mail1);

            AddContactHelper.ClickElement("PrimaryButton1");

            //Click on DoNotCall
            AddContactHelper.ClickElement("OptedOut");


           //$$$$$$$$$$$$$$$$$$$$$$$$$ Social Links

            //Select Social Link Type
            AddContactHelper.Select("SocialLinkType", "Facebook");

            //Select Social Link id
            AddContactHelper.TypeText("Socialid", mail1);

            //Click on DoNotCall
            AddContactHelper.ClickElement("ClickOnOptedOut");

           // AddContactHelper.ClickElement("ClickOnAddSocialLink");

            //############################# ADDRESS   ##################################3

            //Select Address Type
            AddContactHelper.Select("AddressType", "Corporate");

            //Enter Address Line1
            AddContactHelper.TypeText("AddressLine1", "301 ibmbldng");

            //Enter Address Line2
            AddContactHelper.TypeText("AddressLine2", "James Street");

            //Enter City
            AddContactHelper.TypeText("City", "Ohio");

           //Select Address State
            AddContactHelper.Select("AddressState", "AK");

            //Select Country
            AddContactHelper.Select("SelectCountry", "USA");
            AddContactHelper.WaitForWorkAround(3000);

            //Select Zip Code
            AddContactHelper.TypeText("ZipCode", "14589");
            AddContactHelper.WaitForWorkAround(2000);

            //################# CONTACT TAGS ########################

           // AddContactHelper.TypeText("EnterContactTags", "Active");
            


            //#######################  Description    ########################

            //AddContactHelper.TypeText("Description","This is first description information");

            //CLICK DoNotSolicit
            AddContactHelper.ClickElement("SaveAccountbtn");
            AddContactHelper.WaitForWorkAround(7000);
            
            

        }
    }
}
