using System;
using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class GroupTrashViewPage : DriverTestCase
    {
        [TestMethod]
        public void grouptrashviewpage()
        {
            string[] username = null;
            string[] password = null;

            XMLParse oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/ApplicationSettings.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            LoginHelper loginHelper = new LoginHelper(GetWebDriver());
            //ClientsHelper clientHelper = new ClientsHelper(GetWebDriver());
            AddAccountHelper AddAccountHelper = new AddAccountHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");
            AddAccountHelper.WaitForWorkAround(4000);


            AddAccountHelper.ClickElement("ClickAccountsTab");
            AddAccountHelper.WaitForWorkAround(4000);



            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/trash");
            AddAccountHelper.WaitForWorkAround(3000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/groups/trash");
            AddAccountHelper.WaitForWorkAround(3000);

            AddAccountHelper.ClickElement("ClicOnTrashRecordViewPage");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/groups/view/10");
            AddAccountHelper.WaitForWorkAround(5000);

            AddAccountHelper.TypeText("SearchByStatuses", "New");

            AddAccountHelper.ClickElement("ClickOnRestoreOptionButton");

            AddAccountHelper.ClickElement("ClickOnFirstRecordOption");

            AddAccountHelper.ClickElement("ClickOnBackButtonOption");

            //################# Restore Option ###############################
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/groups/view/10");
            AddAccountHelper.WaitForWorkAround(5000);


            AddAccountHelper.ClickElement("ClickOnRestoreButtonOptions");

            AddAccountHelper.AcceptAlert();
            AddAccountHelper.WaitForWorkAround(3000);

            //######################### Delete Option ##################
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/trash");
            AddAccountHelper.WaitForWorkAround(3000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/groups/trash");
            AddAccountHelper.WaitForWorkAround(3000);

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/accounts/groups/view/10");
            AddAccountHelper.WaitForWorkAround(5000);

            AddAccountHelper.ClickElement("ClcikOnDeleteButtonOption");

            AddAccountHelper.AcceptAlert();
            AddAccountHelper.WaitForWorkAround(3000);

        }
    }
}