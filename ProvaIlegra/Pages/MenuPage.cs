using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaIlegra.Pages
{
    class MenuPage
    {
        private IWebDriver WebDriver;

        public MenuPage(IWebDriver WebDriver)
        {
            this.WebDriver = WebDriver;
        }

        public IWebElement GetLogoutButton()
        {
            return WebDriver.FindElement(By.ClassName("logout"));
        }

        public void ClickLogoutButton()
        {
            GetLogoutButton().Click();
        }

        public void ValidateLogout()
        {
            if (!WebDriver.Url.Contains("http://automationpractice.com/index.php"))
            {
                Assert.Fail("Something went wrong, please validate the logout button setup.");
            }
            else
            {
                Console.WriteLine("Login steps followed successfully.");
            }
        }

    }
}
