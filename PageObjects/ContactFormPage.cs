using Ipswitch_Selenium_Tests.Constants;
using OpenQA.Selenium;


namespace Ipswitch_Selenium_Tests.PageObjects
{
    public class ContactFormPage : BasePage

    {
        public ContactFormPage(IWebDriver driver) : base(driver)
        {
        }
        public override string PageUrl =>
            "https://www.ipswitch.com/test-form-page";

        public IWebElement FieldFirstName =>
            driver.FindElement(By.CssSelector("#Textbox-1"));

        public IWebElement FieldLastName =>
            driver.FindElement(By.CssSelector("#Textbox-4"));

        public IWebElement FieldEmail =>
            driver.FindElement(By.CssSelector("#Email-1"));

        public IWebElement FieldPhoneNumber =>
            driver.FindElement(By.CssSelector("#Textbox-5"));

        public IWebElement FieldJobTitle =>
            driver.FindElement(By.CssSelector("#Textbox-3"));

        public IWebElement FieldCompany =>
            driver.FindElement(By.CssSelector("#Textbox-2"));

        public IWebElement FieldMessage =>
            driver.FindElement(By.CssSelector("#Textarea-1"));

        public IWebElement FieldProductInterest =>
            driver.FindElement(By.CssSelector("#Dropdown-1"));

        public IWebElement FieldCountry =>
            driver.FindElement(By.CssSelector("#Country-1"));

        public IWebElement FieldState =>
            driver.FindElement(By.CssSelector("#State-1"));

        public IWebElement ButtonSubmit =>
            driver.FindElement(By.XPath("//div/button"));

        public IWebElement MessageSuccessfullySubmitedForm =>
            driver.FindElement(By.XPath("//span[contains(@data-sf-role,'success-message')]"));

        public IWebElement ErrorMessage_Invalid_Email =>
            driver.FindElement(By.XPath("(//p[@data-sf-role='error-message'])[2]"));

        public IWebElement ErrorMessage_Invalid_PhoneNumber =>
            driver.FindElement(By.XPath("(//p[@role='alert'])[6]"));

        public void FillContactForm(string email, string phone, string country)
        {
            FieldFirstName.SendKeys(GlobalTestConstants.firstName);
            FieldLastName.SendKeys(GlobalTestConstants.lastName);
            FieldEmail.SendKeys(email);
            FieldPhoneNumber.SendKeys(phone);
            FieldCompany.SendKeys(GlobalTestConstants.company);
            FieldJobTitle.SendKeys(GlobalTestConstants.jobTitle);
            FieldProductInterest.SendKeys(GlobalTestConstants.productInterest);
            FieldCountry.SendKeys(country);
            FieldMessage.SendKeys(GlobalTestConstants.message);
            ButtonSubmit.Click();
        }
        public void FillContactFormWithState(string email, string phone, string country)
        {
            FieldFirstName.SendKeys(GlobalTestConstants.firstName);
            FieldLastName.SendKeys(GlobalTestConstants.lastName);
            FieldEmail.SendKeys(email);
            FieldPhoneNumber.SendKeys(phone);
            FieldCompany.SendKeys(GlobalTestConstants.company);
            FieldJobTitle.SendKeys(GlobalTestConstants.jobTitle);
            FieldProductInterest.SendKeys(GlobalTestConstants.productInterest);
            FieldCountry.SendKeys(country);
            FieldState.SendKeys(GlobalTestConstants.state);
            FieldMessage.SendKeys(GlobalTestConstants.message);
            ButtonSubmit.Click();
        }
    }
}