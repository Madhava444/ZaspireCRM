using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.Admin
{
    [TestClass]
    public class OrganizationProfileViewPage : DriverTestCase
    {
        [TestMethod]
        public void organizationprofileviewpage()
        {
            string[] username = null;
            string[] password = null;

            XMLParse oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

            username = oXMLData.getData("settings/Credentials", "username1");
            password = oXMLData.getData("settings/Credentials", "password1");

            //Initializing the objects
            LoginHelper loginHelper = new LoginHelper(GetWebDriver());
            //ClientsHelper clientHelper = new ClientsHelper(GetWebDriver());
            //AddContactHelper AddAccountHelper = new AddContactHelper(GetWebDriver());
            OrganizationProfilePageHelper OrganizationProfilePageHelper = new OrganizationProfilePageHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);


            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            OrganizationProfilePageHelper.WaitForWorkAround(4000);

            //Click On Client Tab
            //UserTrashViewPageHelper.ClickElement("ClickContactsTab");
            //UserTrashViewPageHelper.WaitForWorkAround(4000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/admin/users/organization");
            OrganizationProfilePageHelper.WaitForWorkAround(7000);


            //*************   User Admin Organization Profile Page Functionalities     ******************

            // Update Detail Function
            OrganizationProfilePageHelper.ClickElement("OrganizationUpdateDetail");
            OrganizationProfilePageHelper.WaitForWorkAround(5000);
            OrganizationProfilePageHelper.ClickElement("OrganizationUpdateDetailCancel");

            //  Add/Edit Contact Function  
            OrganizationProfilePageHelper.ClickElement("OrganizationAddOrEditContact");
            OrganizationProfilePageHelper.WaitForWorkAround(5000);
            OrganizationProfilePageHelper.ClickElement("OrganizationAddOrEditContactCancel");

            //  Add Address Function
            OrganizationProfilePageHelper.ClickElement("OrganizationAddAddress");
            OrganizationProfilePageHelper.WaitForWorkAround(5000);
            OrganizationProfilePageHelper.ClickElement("OrganizationAddAddressCancel");


            //Edit Address Function

            // OrganizationProfilePageHelper.ClickElement("OrganizationEditAddress");
            //OrganizationProfilePageHelper.ClickElement("OrganizationEditAddressCancel");
            OrganizationProfilePageHelper.WaitForWorkAround(5000);

            //Delete Address Function
            //  OrganizationProfilePageHelper.ClickElement("OrganizationDeleteAddress");
            // OrganizationProfilePageHelper.Dismiss();


            //Delete Contact Function
            OrganizationProfilePageHelper.ClickElement("OrganizationDeleteContactWindow");
            OrganizationProfilePageHelper.WaitForWorkAround(5000);
            OrganizationProfilePageHelper.ClickElement("OrganizationDeleteContact");
            OrganizationProfilePageHelper.DismissAlert();
            OrganizationProfilePageHelper.WaitForWorkAround(5000);
            OrganizationProfilePageHelper.ClickElement("OrganizationDeleteContactCancel");

            //Update Address Function
            OrganizationProfilePageHelper.ClickElement("OrganizationUpdateAddress");
            OrganizationProfilePageHelper.WaitForWorkAround(5000);
            //OrganizationProfilePageHelper.Dismiss();
            OrganizationProfilePageHelper.ClickElement("OrganizationUpdateAddressCancel");

        }
    }
}
