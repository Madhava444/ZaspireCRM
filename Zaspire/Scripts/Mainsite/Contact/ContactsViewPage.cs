using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Comm;

namespace Zaspire.Scripts.Mainsite
{
    [TestClass]
    public class ContactsViewPage : DriverTestCase
    {
        [TestMethod]
        public void contactsviewpage()
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

            //********************* Inline Edit ***************************
            addcontacHelper.ClickElement("ClickOnFirstRecord");
            addcontacHelper.WaitForWorkAround(3000);

            addcontacHelper.ClickElement("ClickOnOwner");

            addcontacHelper.Select("SelectOwner", "17");

            addcontacHelper.ClickElement("ClickOnOkOption");


            addcontacHelper.ClickElement("ClickOnSource");

            addcontacHelper.Select("SelectSource", "Campaign/2bd63c");

            addcontacHelper.ClickElement("ClickOnOkOptions");

            addcontacHelper.ClickElement("ClickOnCategory");

            addcontacHelper.Select("SelectCategory", "12396/a86038");

            addcontacHelper.ClickElement("ClickOnOkOptionss");

              // ************** Edit Option ***********************
            addcontacHelper.ClickElement("ClickOnFirstRecord");
            addcontacHelper.WaitForWorkAround(3000);

            addcontacHelper.ClickElement("ClickOnEditButtonfunction");

            addcontacHelper.ClickElement("ClickOnSaveButtons");

            // *******************Add New Function *******************

            addcontacHelper.ClickElement("ClickOnAddNewButtons");

            addcontacHelper.ClickElement("ClickOnCancelButtons");


            //###################### Time Line ####################
            addcontacHelper.ClickElement("ClickOnFirstRecord");

            addcontacHelper.ClickElement("ClickListView");

            addcontacHelper.ClickElement("ClickGraphicalView");

            addcontacHelper.ClickElement("ClickOnMoreActivity");

            //###################  View Tabs #################
            addcontacHelper.ClickElement("ClickOnContactInfotab");

            addcontacHelper.ClickElement("ClickOnDescriptiontab");

            addcontacHelper.ClickElement("ClickOnCampaignstab");

            addcontacHelper.ClickElement("ClickOnFirstCampaignRecord");

            //********************** Activities Tab ******************
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            addcontacHelper.WaitForWorkAround(7000);

            addcontacHelper.ClickElement("ClickOnFirstRecord");
            
            addcontacHelper.ClickElement("ClickOnActivitiestab");

            addcontacHelper.TypeText("SearchFilterBox", "Hold");
            addcontacHelper.WaitForWorkAround(4000);

            addcontacHelper.ClickElement("ClickOnResetButton");

            //***Activities tab for Task ########
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            addcontacHelper.WaitForWorkAround(7000);

            addcontacHelper.ClickElement("ClickOnFirstRecord");

            addcontacHelper.ClickElement("ClickOnActivitiestab");

            addcontacHelper.MouseOver2("Locator");

            addcontacHelper.ClickElement("ClickOnTaskQuickLink");

            addcontacHelper.Select("Quicklinksdropdown", "SelectViews");

            //******** Activities tab for Meeting ************
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            addcontacHelper.WaitForWorkAround(7000);

            addcontacHelper.ClickElement("ClickOnFirstRecord");

            addcontacHelper.ClickElement("ClickOnActivitiestab");


            addcontacHelper.MouseOver3("Locator");

            addcontacHelper.ClickElement("ClickOnTaskQuickLinks");

            addcontacHelper.Select("Quicklinksdropdown", "ClickOnSelectViews");

            //************** Activities tab for Appointment **************
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            addcontacHelper.WaitForWorkAround(7000);

            addcontacHelper.ClickElement("ClickOnFirstRecord");

            addcontacHelper.ClickElement("ClickOnActivitiestab");

            addcontacHelper.MouseOver4("Locator");

            addcontacHelper.ClickElement("ClickOnTaskQuickLinks");

            addcontacHelper.Select("Quicklinksdropdowns", "ClickOnSelectViews");

            //******** Activities tab for Emails#############
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            addcontacHelper.WaitForWorkAround(7000);

            addcontacHelper.ClickElement("ClickOnFirstRecord");

            addcontacHelper.ClickElement("ClickOnActivitiestab");

            addcontacHelper.MouseOver5("Locator");

            addcontacHelper.ClickElement("ClickOnTaskQuickLinks1");

            addcontacHelper.Select("Qucklinks1dropdown", "SelectAttachment");

            addcontacHelper.Select("Qucklinks1dropdown", "SelectViewss");

            //********** Activities for Notes############
            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            addcontacHelper.WaitForWorkAround(7000);

            addcontacHelper.ClickElement("ClickOnFirstRecord");

            addcontacHelper.ClickElement("ClickOnActivitiestab");

            addcontacHelper.MouseOver6("Locator");

            addcontacHelper.ClickElement("ClickOnTaskQuickLinks2");

            addcontacHelper.Select("Qucklinks1dropdown", "SelectAttachment1");

            addcontacHelper.ClickElement("ClickOnTaskQuickLinks2");

            addcontacHelper.Select("Qucklinks1dropdown", "SelectEmailthis");

            addcontacHelper.TypeText("ToAddress", "vipin.purushotam@infozeal.com");

            addcontacHelper.ClickElement("ClickonSendOption");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/contacts");
            addcontacHelper.WaitForWorkAround(7000);

            addcontacHelper.ClickElement("ClickOnFirstRecord");

            addcontacHelper.ClickElement("ClickOnActivitiestab");

            addcontacHelper.MouseOver6("Locator");

            addcontacHelper.Select("Qucklinks1dropdown", "SelectViewOptions");



           //################### Add To Group ########################

            addcontacHelper.Select("Selectaddtogroup", "group");
            addcontacHelper.WaitForWorkAround(4000);

            addcontacHelper.ClickElement("ClickOnOkbutton");

            addcontacHelper.Select("Selectaddtogroup", "group");
            addcontacHelper.WaitForWorkAround(4000);

            addcontacHelper.ClickElement("ClickOnNobutton");

            addcontacHelper.TypeText("Selectaddtogroup","Newgroup");

            //########################## Manage Tags#######################
            addcontacHelper.ClickElement("ClickOnManageLinks");
            addcontacHelper.ClickElement("ClickOnSystemGeneratedTab");

            addcontacHelper.ClickElement("ClickonEditOption");

            addcontacHelper.ClickElement("UncheckCity");

            addcontacHelper.ClickElement("UncheckIndustry");

            addcontacHelper.ClickElement("ClickOnRecreateOption");

            //######## Delete Option########
            addcontacHelper.ClickElement("ClickOnManageLinks");
            addcontacHelper.ClickElement("ClickOnSystemGeneratedTab");
            addcontacHelper.ClickElement("ClickOnDeleteOption");

            //####### Cancel Option ######
            addcontacHelper.ClickElement("ClickOnManageLinks");
            addcontacHelper.ClickElement("ClickOnSystemGeneratedTab");
            addcontacHelper.ClickElement("ClickOnCancelOption");

            //###########Your tags #######
            addcontacHelper.ClickElement("ClickOnManageLinks");
            addcontacHelper.ClickElement("ClickOnYourTags");

            addcontacHelper.TypeText("ClickonYourTags", "new");

            addcontacHelper.ClickElement("ClickOnSaveOptions");

            //######################## View Widget ####################

            addcontacHelper.MouseOver11("Locator");

            addcontacHelper.Select("Viewdropdown", "Upcoming");
            addcontacHelper.WaitForWorkAround(10000);

            addcontacHelper.Select("Viewdropdown", "All");
            addcontacHelper.WaitForWorkAround(10000);

            addcontacHelper.Select("Viewdropdown", "Calendar");
            addcontacHelper.WaitForWorkAround(10000);

        }
    }
}
