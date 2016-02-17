using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Zaspire.Locators;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;
using OpenQA.Selenium.Interactions;

namespace Zaspire.PageHelpers.Com
{
    public class VendorHelper : DriverHelper
    {
        public LocatorReader locatorReader;

        public VendorHelper(IWebDriver idriver)
            : base(idriver)
        {
            locatorReader = new LocatorReader("Vendor.xml");
        }


        // ###########################  XML  ##############


        //Type into given xml node
        public void TypeText(string Field, string text)
        {
            var locator = locatorReader.ReadLocator(Field);
            WaitForElementPresent(locator, 20);
            SendKeys(locator, text);
        }

        public void MouseHover(string locator)
        {
            var el = GetWebDriver().FindElement(ByLocator("//*[@id='vendors_grid_wrapper']/div[1]/div/div/button"));

            var builder = new Actions(GetWebDriver());
            builder.MoveToElement(el).Build().Perform();
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

        public void DudlicateClick()
        {
            var Save = "//*[@id='VendorAddnewForm']/div[2]/div/ul/li[5]/button";
            var Dublicate = "//*[@id='VendorAddnewForm']/div[3]/div/div[5]/div/div/button";
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




        public void Mouseover(string Field)
        {
            var locator = locatorReader.ReadLocator(Field);
            WaitForWorkAround(4000);
            MouseOver(locator);
         }

        internal void Upload(string Field, string FileName)
        {
            var locator = locatorReader.ReadLocator(Field);
            Console.WriteLine(FileName);
            GetWebDriver().FindElement(ByLocator(locator)).SendKeys(FileName);
            WaitForWorkAround(3000);

        }

    }

}


