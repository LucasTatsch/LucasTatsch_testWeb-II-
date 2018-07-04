using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace ProvaIlegra
{
    [TestClass]
    public class LoginPage
    {
        private IWebDriver WebDriver;

        public LoginPage(IWebDriver WebDriver)
        {
            this.WebDriver = WebDriver;
        }

        public IWebElement GetUsernameText()
        {
            return WebDriver.FindElement(By.Id("email"));
        }

        public void SetUsernameText(string Username)
        {
            GetUsernameText().Clear();
            GetUsernameText().SendKeys(Username);
        }
        public IWebElement GetPasswordText()
        {
            return WebDriver.FindElement(By.Id("passwd"));
        }

        public void SetPasswordText(string Password)
        {
            GetPasswordText().Clear();
            GetPasswordText().SendKeys(Password);
        }

        public IWebElement GetLoginButton()
        {
            return WebDriver.FindElement(By.Id("SubmitLogin"));
        }

        public void ClickLoginButton()
        {
            GetLoginButton().Click();
        }

        public void ValidateLogin()
        {
            if (!WebDriver.Url.Contains("my-account"))
            {
                Assert.Fail("Something went wrong, please validate the login information provided.");
            }
            else
            {
                Console.WriteLine("Login steps followed successfully.");
            }
        }
    }
}
