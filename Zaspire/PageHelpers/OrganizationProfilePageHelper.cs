using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Zaspire.Locators;
using OpenQA.Selenium.Interactions;
using Zaspire.PageHelpers.Com;


namespace Zaspire.PageHelpers.Com
{
    public class OrganizationProfilePageHelper : DriverHelper
    {
        public LocatorReader locatorReader;

        public OrganizationProfilePageHelper(IWebDriver idriver)
            : base(idriver)
        {
            locatorReader = new LocatorReader("OrganizationProfilePage.xml");
        }

        // ###########################  XML  ##############


        //Type into given xml node
        public void TypeText(string Field, string text)
        {
            var locator = locatorReader.ReadLocator(Field);
            WaitForElementPresent(locator, 20);
            SendKeys(locator, text);
        }
        public void OpenAccount()
        {
            var locator = locatorReader.ReadLocator("FirstClientNameLink");
            Click(locator);
        }


        //Verify text of given xml node
        public void VerifyText(string XmlNode, string text)
        {
            var locator = locatorReader.ReadLocator(XmlNode);
            var value = GetText(locator);
            Assert.IsTrue(value.Contains(text));
        }

        //Select by value
        public void Select(string xmlNode, string value)
        {
            var locator = locatorReader.ReadLocator(xmlNode);
            SelectDropDown(locator, value);
        }

        //Click 

        public void ClickElement(string xmlNode)
        {
            var locator = locatorReader.ReadLocator(xmlNode);
            WaitForElementPresent(locator, 20);
            Click(locator);
            WaitForWorkAround(3000);

        }

        public void DublicateClick()
        {
            var Save = "//*[@id='LeadCreateForm']/div[2]/div[3]/a[1]/span[1]";
            var Dublicate = "//*[@id='message']/div[4]/div/a[1]/span[2]";
            Click(Save);
            WaitForWorkAround(3000);

            if (IsElementPresent(Dublicate))
            {
                Click(Dublicate);
                WaitForWorkAround(3000);
            }
        }



        //Verify method Present method

        public void verifytext(System.Boolean flag, string Company)
        {
            //  var locator = locatorReader.ReadLocator(Company);
            if (flag == true)
            {
                Assert.IsTrue(IsElementPresent(Company));
            }
            else
            {
                Assert.IsFalse(IsElementPresent(Company));
            }

        }

        public void MouseHover10(string locator)
        {
            var el = GetWebDriver().FindElement(ByLocator("//*[@id='actionicons1']/a/i[2]"));

            var builder = new Actions(GetWebDriver());
            builder.MoveToElement(el).Build().Perform();
        }


        public void MouseHover(string locator)
        {
            var el = GetWebDriver().FindElement(ByLocator("html/body/div[2]/div/ul/li[1]/a"));
            var builder = new Actions(GetWebDriver());
            builder.MoveToElement(el).Build().Perform();
        }

        public void MouseHover1(string locator)
        {
            var el = GetWebDriver().FindElement(ByLocator("//*[@id='normal']"));

            var builder = new Actions(GetWebDriver());
            builder.MoveToElement(el).Build().Perform();
        }

        public void MouseOver11(string locator)
        {
            var el = GetWebDriver().FindElement(ByLocator("html/body/div[4]/div[2]/div[2]/div/div/div/div[2]/div"));

            var builder = new Actions(GetWebDriver());
            builder.MoveToElement(el).Build().Perform();
        }

        public void MouseOver12(string locator)
        {
            var el = GetWebDriver().FindElement(ByLocator("html/body/div[4]/div[2]/div[2]/div/div/div/table/tbody/tr[1]/td[1]/div/div/a/i[1]"));

            var builder = new Actions(GetWebDriver());
            builder.MoveToElement(el).Build().Perform();
        }

        public void MouseOver13(string locator)
        {
            var el = GetWebDriver().FindElement(ByLocator("html/body/div[4]/div[2]/div[2]/div/ul/li[6]/div/div/a"));

            var builder = new Actions(GetWebDriver());
            builder.MoveToElement(el).Build().Perform();
        }

        public void MouseHover2(string locator)
        {
            var el = GetWebDriver().FindElement(ByLocator("html/body/div[4]/div[2]/div[2]/div/div/div/div[1]/div/div/button"));

            var builder = new Actions(GetWebDriver());
            builder.MoveToElement(el).Build().Perform();
        }

        public void MouseHover3(string locator)
        {
            var el = GetWebDriver().FindElement(ByLocator("html/body/div[4]/div[2]/div[2]/div/div/div/table/tbody/tr[1]/td[1]/div/div/a/i[2]"));

            var builder = new Actions(GetWebDriver());
            builder.MoveToElement(el).Build().Perform();
        }

    }


}
