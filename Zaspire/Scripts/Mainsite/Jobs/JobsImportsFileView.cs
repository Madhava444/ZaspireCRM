using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts.MainSite
{
    [TestClass]
    public class JobsImportsFileView : DriverTestCase
    {
        [TestMethod]
        public void jobsimportsfileview()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username1");
            password = oXMLData.getData("settings/Credentials", "password1");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var JobsimportsHelper = new JobsImportsHelper(GetWebDriver());


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");



            //Click on Leads
            JobsimportsHelper.ClickElement("ClickonJobs");


            //Click on jobs Imports
            JobsimportsHelper.ClickElement("ClickOnImports");
            JobsimportsHelper.WaitForWorkAround(3000);

           

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs");
            //JobsimportsHelper.WaitForWorkAround(7000);
            
            //Click on Leads Imports
            //JobsimportsHelper.ClickElement("ClickOnImports");

            //Upload file
            JobsimportsHelper.upload1("locator");
            JobsimportsHelper.WaitForWorkAround(3000);

            ///Click on Leads Imports
            JobsimportsHelper.ClickElement("ClickOnImports1");
            JobsimportsHelper.WaitForWorkAround(3000);


            //Click on Import savebutton
            JobsimportsHelper.ClickElement("Importsavebutton");
            JobsimportsHelper.WaitForWorkAround(20000); 


            //Click on Import file
            JobsimportsHelper.ClickElement("Importfielview");
            JobsimportsHelper.WaitForWorkAround(3000); 

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs/imports");

            //Deleteimport file
            JobsimportsHelper.ClickElement("ClickOnDeleteIcon");

            //JobsimportsHelper.DismissAlert();
            //JobsimportsHelper.WaitForWorkAround(3000); 


            JobsimportsHelper.AcceptAlert();
            JobsimportsHelper.WaitForWorkAround(3000); 

           
            //JobsimportsHelper.WaitForWorkAround(3000);

           // GetWebDriver().Navigate().GoToUrl("http://zaspire.com/glassdoor/jobs/imports");
            //JobsimportsHelper.WaitForWorkAround(7000);

            //Click on First File Name
           // JobsimportsHelper.ClickElement("ClickOnFirstFileName");


          



        }
    }
}
