using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Zaspire.Locators;
using Zaspire.PageHelpers.Com;
using OpenQA.Selenium.Interactions;

namespace Zaspire.PageHelpers.Com
{
    public class NotesTrashIndexHelper : DriverHelper
    {
        public LocatorReader locatorReader;

        public NotesTrashIndexHelper(IWebDriver idriver)
            : base(idriver)
        {
            locatorReader = new LocatorReader("NotesTrashIndex.xml");
        }

        // ###########################  XML  ##############


        //Type into given xml node
        public void TypeText(string Field, string text)
        {
            var locator = locatorReader.ReadLocator(Field);
            WaitForElementPresent(locator, 20);
            SendKeys(locator, text);
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

        public void MouseOver(string locator)
        {
            var el = GetWebDriver().FindElement(ByLocator("//*[@id='normal']"));

            var builder = new Actions(GetWebDriver());
            builder.MoveToElement(el).Build().Perform();
        }

        public void MouseOver1(string locator1)
        {
            var el = GetWebDriver().FindElement(ByLocator("//*[@id='notes_grid_wrapper']/div[1]/div/div/button"));

            var builder = new Actions(GetWebDriver());
            builder.MoveToElement(el).Build().Perform();
        }

        public void MouseHover(string Field)
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