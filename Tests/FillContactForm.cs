using Ipswitch_Selenium_Tests.PageObjects;
using NUnit.Framework;

namespace Ipswitch_Selenium_Tests.Tests
{
    class FillContactForm : BaseTest
    {
        [Test]
        public void Test_FillContactForm_Content()
        {
            var page = new ContactFormPage(driver);
            page.Open();
            Assert.AreEqual("Test Ipswitch form page", page.GetPageTitle());
            Assert.AreEqual("Contact our Team", page.GetPageHeadingText());
            Assert.AreEqual("", page.FieldFirstName.Text);
            Assert.AreEqual("", page.FieldLastName.Text);
            Assert.AreEqual("", page.FieldPhoneNumber.Text);
            Assert.AreEqual("", page.FieldEmail.Text);
            Assert.AreEqual("", page.FieldCompany.Text);
            Assert.IsTrue(page.FieldProductInterest.Text.Contains("..."));
            Assert.IsTrue(page.FieldCountry.Text.Contains("..."));
            Assert.AreEqual("", page.FieldMessage.Text);
            Assert.AreEqual("CONTACT US", page.ButtonSubmit.Text);
        }

        [Test]
        public void Test_FillContactForm_ValidData()
        {
            var page = new ContactFormPage(driver);
            page.Open();
            string email = "testov@t.com";
            string phone = "345-543-545";
            string country = "Bulgaria";
            page.FillContactForm(email, phone, country);
            page.MessageSuccessfullySubmitedForm.Click();
            Assert.AreEqual("Thank you for filling out this great form!", page.MessageSuccessfullySubmitedForm.Text);
        }

        [Test]
        public void Test_FillContactForm_ValidData_And_State()
        {
            var page = new ContactFormPage(driver);
            page.Open();
            string email = "testov@t.com";
            string phone = "345-543-545";
            string country = "USA";
            page.FillContactFormWithState(email, phone, country);
            page.MessageSuccessfullySubmitedForm.Click();
            Assert.AreEqual("Thank you for filling out this great form!", page.MessageSuccessfullySubmitedForm.Text);
        }

        [Test]
        public void Test_FillContactForm_InvalidEmail()
        {
            var page = new ContactFormPage(driver);
            page.Open();
            string email = "testov";
            string phone = "345-543-545";
            string country = "Bulgaria";
            page.FillContactForm(email, phone, country);
            Assert.IsTrue(page.ErrorMessage_Invalid_Email.Text.Contains("Enter a Valid Business Email"));
        }

        [Test]
        public void Test_FillContactForm_InvalidPhoneNumber()
        {
            var page = new ContactFormPage(driver);
            page.Open();
            string email = "testov@t.com";
            string phone = "test_number_876";
            string country = "Bulgaria";
            page.FillContactForm(email, phone, country);
            Assert.IsTrue(page.ErrorMessage_Invalid_PhoneNumber.Text.Contains("Phone Number field input is invalid"));
        }
    }
}
