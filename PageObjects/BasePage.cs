using OpenQA.Selenium;
using System;

namespace Ipswitch_Selenium_Tests.PageObjects
{
    public class BasePage

    {
        protected readonly IWebDriver driver;
        public virtual string PageUrl { get; }

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Manage().Window.Maximize();
        }

        public IWebElement ElementPageHeading =>
            driver.FindElement(By.CssSelector("#Content_C338_Col00 > h1"));
        public void Open()
        {
            driver.Navigate().GoToUrl(this.PageUrl);
        }

        public bool IsOpen()
        {
            return driver.Url == this.PageUrl;
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }
        public string GetPageHeadingText()
        {
            return ElementPageHeading.Text;
        }
    }
}